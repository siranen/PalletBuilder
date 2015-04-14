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
        #endregion
        #region Drawable implementation
        public override void Draw(Graphics3D graphics)
        {
            // back faces
            if (_packProperties.Wrap.Type == PackWrapper.WType.WT_TRAY)
            { 
            }

            // inner boxes
            List<Box> boxes = new List<Box>();
            uint pickId = 0;
            for (int i = 0; i < _arrangement._iLength; ++i)
                for (int j = 0; j < _arrangement._iWidth; ++j)
                    for (int k = 0; k < _arrangement._iHeight; ++k)
                        boxes.Add(new Box(pickId++, _packProperties.Box, GetPosition(i, j, k, _packProperties.Dim0, _packProperties.Dim1)));
            boxes.Sort(new BoxComparerSimplifiedPainterAlgo(graphics.GetWorldToEyeTransformation()));
            foreach (Box b in boxes)
                b.Draw(graphics);
            
            // last faces
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

            // apply global transformation using _dir0 / _dir1
            return BoxPosition.Transform(
                new BoxPosition(vPosition + new Vector3D(i * boxLength, j * boxWidth, k * boxHeight), dirLength, dirWidth)
                , GlobalTransformation
                );
        }

        Transform3D GlobalTransformation
        {
            get
            {
                return new Transform3D();
            }
        }

        #endregion

        #region Data members
        private Box _innerBox;
        private PackArrangement _arrangement;
        private PackProperties _packProperties;
        #endregion
    }
}
