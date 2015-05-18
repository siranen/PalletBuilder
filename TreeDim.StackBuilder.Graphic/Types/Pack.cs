#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TreeDim.StackBuilder.Basics;

using Sharp3D.Math.Core;
#endregion

namespace TreeDim.StackBuilder.Graphics
{
    public class Pack : Box
    {
        #region Constructor
        public Pack(uint pickId, PackProperties packProperties)
            : base(pickId, packProperties.Length, packProperties.Width, packProperties.Height)
        {
            _packProperties = packProperties;
            _arrangement = _packProperties.Arrangement;
            _innerBox = new Box(0, packProperties.Box);
        }
        public Pack(uint pickId, PackProperties packProperties, BoxPosition position)
            : base(pickId, packProperties, position)
        {
            _packProperties = packProperties;
            _arrangement = _packProperties.Arrangement;
            _innerBox = new Box(0, packProperties.Box);
        }
        #endregion

        #region Public properties
        public bool ForceTransparency
        {
            get { return _forceTransparency; }
            set { _forceTransparency = true; }
        }
        #endregion

        #region Drawable implementation
        public override void Draw(Graphics3D graphics)
        {
            // draw tray back faces
            if (_packProperties.Wrap.Type == PackWrapper.WType.WT_TRAY)
            {}
            // draw inner boxes
            if (_packProperties.Wrap.Type == PackWrapper.WType.WT_POLYETHILENE
                || _packProperties.Wrap.Type == PackWrapper.WType.WT_TRAY
                || _forceTransparency)
            {
                List<Box> boxes = InnerBoxes;
                boxes.Sort( new BoxComparerSimplifiedPainterAlgo(graphics.GetWorldToEyeTransformation()) );
                foreach (Box b in boxes)
                    graphics.Draw(b);
            }
            if (_packProperties.Wrap.Type != PackWrapper.WType.WT_TRAY)
            {
                // draw front faces
                foreach (Face f in Faces)
                {
                    graphics.Draw(
                        f
                        , Graphics3D.FaceDir.FRONT
                        , _packProperties.Wrap.Color
                        , _packProperties.Wrap.Transparent || _forceTransparency);
                }
            }
            else
            {
                // draw tray front faces
                foreach (Face f in TrayFaces)
                {
                    graphics.Draw(
                        f
                        , Graphics3D.FaceDir.FRONT
                        , _packProperties.Wrap.Color
                        , _packProperties.Wrap.Transparent);
                }
            }
        }

        private Face[] TrayFaces
        {
            get
            {
                double height = _dim[2];
                WrapperTray tray = _packProperties.Wrap as WrapperTray;
                if (null != tray) height = tray.Height;
                if (height <= 1.0)
                    height = 40.0;

                Vector3D heightAxis = Vector3D.CrossProduct(_lengthAxis, _widthAxis);
                Vector3D[] points = new Vector3D[8];
                points[0] = _position;
                points[1] = _position + _dim[0] * _lengthAxis;
                points[2] = _position + _dim[0] * _lengthAxis + _dim[1] * _widthAxis;
                points[3] = _position + _dim[1] * _widthAxis;

                points[4] = _position + height * heightAxis;
                points[5] = _position + height * heightAxis + _dim[0] * _lengthAxis;
                points[6] = _position + height * heightAxis + _dim[0] * _lengthAxis + _dim[1] * _widthAxis;
                points[7] = _position + height * heightAxis + _dim[1] * _widthAxis;

                Face[] faces = new Face[5];
                faces[0] = new Face(_pickId, new Vector3D[] { points[3], points[0], points[4], points[7] }, false); // AXIS_X_N
                faces[1] = new Face(_pickId, new Vector3D[] { points[1], points[2], points[6], points[5] }, false); // AXIS_X_P
                faces[2] = new Face(_pickId, new Vector3D[] { points[0], points[1], points[5], points[4] }, false); // AXIS_Y_N
                faces[3] = new Face(_pickId, new Vector3D[] { points[2], points[3], points[7], points[6] }, false); // AXIS_Y_P
                faces[4] = new Face(_pickId, new Vector3D[] { points[3], points[2], points[1], points[0] }, false); // AXIS_Z_N

                return faces;
            }
        }

        public List<Box> InnerBoxes
        {
            get
            { 
                List<Box> boxes = new List<Box>();
                uint pickId = 0;
                for (int i = 0; i < _arrangement._iLength; ++i)
                    for (int j = 0; j < _arrangement._iWidth; ++j)
                        for (int k = 0; k < _arrangement._iHeight; ++k)
                            boxes.Add(new Box(pickId++, _packProperties.Box, GetPosition(i, j, k, _packProperties.Dim0, _packProperties.Dim1)));
                return boxes;
            }
        }

        BoxPosition GetPosition(int i, int j, int k, int dim0, int dim1)
        {
            BoxProperties boxProperties = _packProperties.Box;
            double boxLength = boxProperties.Dim(dim0);
            double boxWidth =  boxProperties.Dim(dim1);
            double boxHeight =  boxProperties.Dim(3 - dim0 - dim1);
            HalfAxis.HAxis dirLength = HalfAxis.HAxis.AXIS_X_P;
            HalfAxis.HAxis dirWidth = HalfAxis.HAxis.AXIS_Y_P;
            Vector3D vPosition = Vector3D.Zero;
            if (0 == dim0 && 1 == dim1)
            {
                dirLength = HalfAxis.HAxis.AXIS_X_P;
                dirWidth = HalfAxis.HAxis.AXIS_Y_P;
                vPosition = Vector3D.Zero;
            }
            else if (0 == dim0 && 2 == dim1)
            {
                dirLength = HalfAxis.HAxis.AXIS_X_P;
                dirWidth = HalfAxis.HAxis.AXIS_Z_N;
                vPosition = new Vector3D(0.0, 0.0, boxProperties.Width);
            }
            else if (1 == dim0 && 0 == dim1)
            {
                dirLength = HalfAxis.HAxis.AXIS_Y_P;
                dirWidth = HalfAxis.HAxis.AXIS_X_N;
                vPosition = new Vector3D(boxProperties.Width, 0.0, 0.0);
            }
            else if (1 == dim0 && 2 == dim1)
            {
                dirLength = HalfAxis.HAxis.AXIS_Z_N;
                dirWidth = HalfAxis.HAxis.AXIS_X_P;
                vPosition = new Vector3D(0.0, boxProperties.Height, boxProperties.Length);
            }
            else if (2 == dim0 && 0 == dim1)
            {
                dirLength = HalfAxis.HAxis.AXIS_Y_P;
                dirWidth = HalfAxis.HAxis.AXIS_Z_N;
                vPosition = new Vector3D(boxProperties.Height, 0.0, boxProperties.Width);
            }
            else if (2 == dim0 && 1 == dim1)
            {
                dirLength = HalfAxis.HAxis.AXIS_Z_P;
                dirWidth = HalfAxis.HAxis.AXIS_Y_P;
                vPosition = new Vector3D(boxProperties.Height, 0.0, 0.0);
            }
            // add offset
            vPosition += Vector3D.Zero;

            Vector3D vOffset = new Vector3D(
                0.5 * (_packProperties.Length - _packProperties.InnerLength)
                , 0.5 * (_packProperties.Width - _packProperties.InnerWidth)
                , 0.5 * (_packProperties.Height - _packProperties.InnerHeight)
                );

            // apply global transformation using _dir0 / _dir1
            return BoxPosition.Transform(
                new BoxPosition(
                    vPosition + vOffset + new Vector3D(i * boxLength, j * boxWidth, k * boxHeight)
                    , dirLength
                    , dirWidth)
                , GlobalTransformation
                );
        }

        Transform3D GlobalTransformation
        {
            get
            {
                BoxPosition bp = new BoxPosition(Position, HalfAxis.ToHalfAxis(LengthAxis), HalfAxis.ToHalfAxis(WidthAxis));
                return bp.Transformation;
            }
        }

        #endregion

        #region Data members
        private Box _innerBox;
        private PackArrangement _arrangement;
        private PackProperties _packProperties;
        private bool _forceTransparency = false;
        #endregion
    }
}
