﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using Sharp3D.Math.Core;
using System.Drawing;

using TreeDim.StackBuilder.Basics;
#endregion

namespace TreeDim.StackBuilder.Graphics
{
    #region Position
    public struct Position
    {
        #region Data members
        private int _index;
        private Vector3D _xyz;
        private HalfAxis.HAxis _axis1, _axis2;
        #endregion

        #region Constructor
        public Position(int index, Vector3D xyz, HalfAxis.HAxis axis1, HalfAxis.HAxis axis2)
        {
            _index = index; _xyz = xyz; _axis1 = axis1; _axis2 = axis2;
        }
        #endregion

        #region Public properties
        public Vector3D XYZ {   get {return _xyz;}  }
        public HalfAxis.HAxis Axis1 { get { return _axis1; } }
        public HalfAxis.HAxis Axis2 { get { return _axis2; } }
        public int Index { get { return _index; } }
        #endregion
    }
    #endregion

    #region PalletData
    public class PalletData
    {
        #region Data members
        private string _name;
        private string _description;
        private List<Vector3D> _lumbers;
        private List<Position> _positions;
        private Vector3D _defaultDimensions;
        private static List<PalletData> _pool;
        #endregion

        #region Constructor
        private PalletData(string name, string description, Vector3D[] lumbers, Position[] positions, Vector3D dimensions)
        {
            _name = name;
            _description = description;
            _lumbers = new List<Vector3D>(lumbers);
            _positions = new List<Position>(positions);
            _defaultDimensions = dimensions;
        }
        #endregion

        #region Public properties
        public string Name
        {
            get { return _name; }
        }

        #endregion

        #region Static pool methods
        private static void Initialize()
        {
            if (null == _pool)
            {
                _pool = new List<PalletData>();

                // --------------------------------------------------------------------------------
                // Block
                {
                    Vector3D[] lumbers = {
                        new Vector3D(1200, 1000, 150)
                    };
                    Vector3D dimensions = new Vector3D(1200.0, 1000.0, 150.0);
                    Position[] positions = {
                        new Position(0, new Vector3D(0.0, 0.0, 0.0), HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                    };
                    _pool.Add(new PalletData("Block", "Block", lumbers, positions, dimensions));
                }

                // --------------------------------------------------------------------------------
                // Standard UK
                {
                    Vector3D[] lumbers = {
                         new Vector3D(1000.0, 98.0, 18.0)
                         , new Vector3D(138.0, 98.0, 95.0)
                         , new Vector3D(1200.0, 95.0, 18.0)
                         , new Vector3D(1000.0, 120.0, 19.0)
                    };
                    Vector3D dimensions = new Vector3D(1200.0, 1000.0, 150.0);
                    double xStep0 = (dimensions.X - lumbers[0].Y) / 2.0;
                    double xStep1 = (dimensions.X - lumbers[0].Y) / 2.0;
                    double yStep1 = (dimensions.Y - lumbers[1].X) / 2.0;
                    double yStep2 = lumbers[2].Y + (dimensions.Y - 3.0 * lumbers[2].Y) / 2.0;
                    double xStep3 = lumbers[3].Y + (dimensions.X - 7.0 * lumbers[3].Y) / 6.0;
                    Position[] positions = {
                         // first layer
                         new Position(0, new Vector3D(lumbers[0].Y, 0.0, 0.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(0, new Vector3D(lumbers[0].Y + xStep0, 0.0, 0.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(0, new Vector3D(lumbers[0].Y + 2 * xStep0, 0.0, 0.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         // second layer
                         , new Position(1, new Vector3D(lumbers[1].Y, 0.0, 18.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(1, new Vector3D(lumbers[1].Y, yStep1, 18.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(1, new Vector3D(lumbers[1].Y, 2.0 * yStep1, 18.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(1, new Vector3D(lumbers[1].Y + xStep1, 0.0, 18.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(1, new Vector3D(lumbers[1].Y + xStep1, yStep1, 18.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(1, new Vector3D(lumbers[1].Y + xStep1, 2.0 * yStep1, 18.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(1, new Vector3D(lumbers[1].Y + 2.0 * xStep1, 0.0, 18.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(1, new Vector3D(lumbers[1].Y + 2.0 * xStep1, yStep1, 18.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(1, new Vector3D(lumbers[1].Y + 2.0 * xStep1, 2.0 * yStep1, 18.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         // third layer
                         , new Position(2, new Vector3D(0.0, 0.0, 113.0)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(2, new Vector3D(0.0, yStep2, 113.0)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(2, new Vector3D(0.0, 2.0 * yStep2, 113.0)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         // fourth layer
                         , new Position(3, new Vector3D(lumbers[3].Y, 0.0, 131.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(3, new Vector3D(lumbers[3].Y + 1.0 * xStep3, 0.0, 131.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(3, new Vector3D(lumbers[3].Y + 2.0 * xStep3, 0.0, 131.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(3, new Vector3D(lumbers[3].Y + 3.0 * xStep3, 0.0, 131.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(3, new Vector3D(lumbers[3].Y + 4.0 * xStep3, 0.0, 131.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(3, new Vector3D(lumbers[3].Y + 5.0 * xStep3, 0.0, 131.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(3, new Vector3D(lumbers[3].Y + 6.0 * xStep3, 0.0, 131.0)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)

                    };
                    _pool.Add(new PalletData("UK Standard", "UK Standard", lumbers, positions, dimensions));

                }
                // --------------------------------------------------------------------------------
                // EUR

                // --------------------------------------------------------------------------------
                // GMA 48*40
                {
                    Vector3D[] lumbers = {
                            new Vector3D(40.0 * 25.4,   3.5 * 25.4, 0.625 * 25.4)
                            , new Vector3D(40.0 * 25.4, 5.5 * 25.4, 0.625 * 25.4)
                            , new Vector3D(48.0 * 25.4, 1.375 * 25.4, 3.5 * 25.4)
                        };

                    Vector3D dimensions = new Vector3D(48.0 * 25.4, 40.0 * 25.4, 4.75 * 25.4);

                    Position[] positions = {
                            // bottom deck                            
                            new Position(1, new Vector3D(lumbers[1].Y, 0.0, 0.0)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                            , new Position(1, new Vector3D(dimensions.X, 0.0, 0.0)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                            , new Position(0, new Vector3D(0.5 * (dimensions.X - 3 * lumbers[0].Y), 0.0, 0.0)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                            , new Position(0, new Vector3D(0.5 * (dimensions.X + 1 * lumbers[0].Y), 0.0, 0.0)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                            , new Position(0, new Vector3D(0.5 * (dimensions.X + 5 * lumbers[0].Y), 0.0, 0.0)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                            // stringers
                            , new Position(2, new Vector3D(0.0, 0.0, 0.625 * 25.4)
                                , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                            , new Position(2, new Vector3D(0.0, 0.5 * (dimensions.Y - lumbers[2].Y), 0.625 * 25.4)
                                , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                            , new Position(2, new Vector3D(0.0, dimensions.Y - lumbers[2].Y, 0.625 * 25.4)
                                , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                            // top deck
                            , new Position(1, new Vector3D(lumbers[1].Y, 0.0, (0.625+3.5) * 25.4)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                            , new Position(1, new Vector3D(dimensions.X, 0.0, (0.625+3.5) * 25.4)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                            , new Position(0, new Vector3D(0.5 * (dimensions.X - 7 * lumbers[0].Y), 0.0, (0.625+3.5) * 25.4)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                            , new Position(0, new Vector3D(0.5 * (dimensions.X - 3 * lumbers[0].Y), 0.0, (0.625+3.5) * 25.4)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                            , new Position(0, new Vector3D(0.5 * (dimensions.X + 1 * lumbers[0].Y), 0.0, (0.625+3.5) * 25.4)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                            , new Position(0, new Vector3D(0.5 * (dimensions.X + 5 * lumbers[0].Y), 0.0, (0.625+3.5) * 25.4)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                            , new Position(0, new Vector3D(0.5 * (dimensions.X + 9 * lumbers[0].Y), 0.0, (0.625+3.5) * 25.4)
                                , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                    };
 

                    _pool.Add(new PalletData("US GMA 48x40", "Grocery", lumbers, positions, dimensions));
                }
                // --------------------------------------------------------------------------------
                // EUR
                {
                    Vector3D[] lumbers = {
                                 new Vector3D(1200.0, 100.0, 22.0)  // lower plane side
                                 , new Vector3D(1200.0, 145.0, 22.0) // upper plane side 
                                 , new Vector3D(1200.0, 145.0, 22.0) // lower plane central base
                                 , new Vector3D(800.0, 145.0, 22.0) // cross members
                                 , new Vector3D(1200.0, 145.0, 22.0) // upper plant central board
                                 , new Vector3D(1200.0, 100.0, 22.0) // upper plane intermediate boards
                                 , new Vector3D(145.0, 100.0, 78.0) // outside blocks
                                 , new Vector3D(145.0, 145.0, 78.0) // central blocks
                            };
                    Vector3D dimensions = new Vector3D(1200, 800, 144);

                    double yy0 = (dimensions.Y - 2.0 * lumbers[0].Y - lumbers[1].Y) / 2.0;
                    double yy1 = (dimensions.Y - 2.0 * lumbers[6].Y - lumbers[7].Y) / 2.0;
                    double xStep1 = (dimensions.X - lumbers[6].X) / 2.0;
                    double yStep1 = lumbers[6].Y + yy1;
                    double xStep2 = (dimensions.X - lumbers[4].Y) / 2.0;
                    double yy3 = 0.25 * (dimensions.Y - 2.0 * lumbers[1].Y - 2.0 * lumbers[5].Y - lumbers[4].Y);
                    Position[] positions = {
                         // first layer
                         new Position(0, new Vector3D(0.0, 0.0, 0.0)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(2, new Vector3D(0.0, yy0 + lumbers[0].Y, 0.0)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(0, new Vector3D(0.0, 2 * yy0 + lumbers[0].Y + lumbers[2].Y, 0.0)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         // second layer
                         , new Position(6, new Vector3D(0.0, 0.0, lumbers[0].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(7, new Vector3D(0.0, yStep1, lumbers[0].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(6, new Vector3D(0.0,lumbers[6].Y + lumbers[7].Y + 2.0 * yy1, lumbers[0].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(6, new Vector3D(0.0 + xStep1, 0.0, lumbers[0].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(7, new Vector3D(xStep1, yStep1, lumbers[0].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(6, new Vector3D(0.0 + xStep1, lumbers[6].Y + lumbers[7].Y + 2.0 * yy1, lumbers[0].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(6, new Vector3D(0.0 + 2.0 * xStep1, 0.0, lumbers[0].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(7, new Vector3D(2.0 * xStep1, yStep1, lumbers[0].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(6, new Vector3D(0.0 + 2.0 * xStep1, lumbers[6].Y + lumbers[7].Y + 2.0 * yy1, lumbers[0].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         // third layer
                         , new Position(3, new Vector3D(lumbers[3].Y + 0.0, 0.0, lumbers[0].Z + lumbers[6].Z)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(3, new Vector3D(lumbers[3].Y + xStep2, 0.0, lumbers[0].Z + lumbers[6].Z)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         , new Position(3, new Vector3D(lumbers[3].Y + 2.0 * xStep2, 0.0, lumbers[0].Z + lumbers[6].Z)
                             , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N)
                         // fourth layer
                         , new Position(2, new Vector3D(0.0, 0.0, lumbers[0].Z + lumbers[6].Z + lumbers[3].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(5, new Vector3D(0.0, lumbers[1].Y + yy3, lumbers[0].Z + lumbers[6].Z + lumbers[3].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(4, new Vector3D( 0.0, lumbers[1].Y + lumbers[5].Y + 2.0 * yy3,lumbers[0].Z + lumbers[6].Z + lumbers[3].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(5, new Vector3D(0.0, lumbers[1].Y + lumbers[5].Y + lumbers[4].Y + 3.0 * yy3, lumbers[0].Z + lumbers[6].Z + lumbers[3].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)
                         , new Position(2, new Vector3D(0.0, lumbers[1].Y + 2.0 * lumbers[5].Y + lumbers[4].Y + 4.0 * yy3, lumbers[0].Z + lumbers[6].Z + lumbers[3].Z)
                             , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P)

                        };
                    _pool.Add(new PalletData("EUR", "EUR-EPAL ()", lumbers, positions, dimensions));
                }
                // --------------------------------------------------------------------------------
                // EUR2
                {
                    //_pool.Add(new PalletData("EUR2", "EUR2", lumbers, positions, dimensions));
                }
                // --------------------------------------------------------------------------------
                // EUR3
                {
                }
                // --------------------------------------------------------------------------------
                // EUR6
                {
                }
                // --------------------------------------------------------------------------------

            }
        }

        public static PalletData GetByName(string name)
        {
            Initialize();
            return _pool.Find(delegate(PalletData type) { return string.Compare(type._name, name, true) == 0; });
        }

        public static string[] TypeNames
        {
            get
            {
                Initialize();
                List<string> typeNames = new List<string>();
                foreach (PalletData palletType in _pool)
                    typeNames.Add(palletType.Name);
                return typeNames.ToArray();
            }
        }
        #endregion

        #region Drawing
        public void Draw(Graphics3D graphics, Vector3D dimensions, Color color, Transform3D t)
        {
            double coefX = dimensions.X / _defaultDimensions.X;
            double coefY = dimensions.Y / _defaultDimensions.Y;
            double coefZ = dimensions.Z / _defaultDimensions.Z;
            uint pickId = 0;
            foreach (Position pos in _positions)
            {
                double coef0 = coefX, coef1 = coefY, coef2 = coefZ;
                if (pos.Axis1 == HalfAxis.HAxis.AXIS_X_P && pos.Axis2 == HalfAxis.HAxis.AXIS_Y_P)
                { coef0 = coefX; coef1 = coefY; }
                else if (pos.Axis1 == HalfAxis.HAxis.AXIS_Y_P && pos.Axis2 == HalfAxis.HAxis.AXIS_X_N)
                { coef0 = coefY; coef1 = coefX; }
                Vector3D dim = _lumbers[pos.Index];
                Box box = new Box(pickId++, dim.X * coef0, dim.Y * coef1, dim.Z * coef2);
                box.SetAllFacesColor(color);
                box.Position = t.transform(new Vector3D(pos.XYZ.X * coefX, pos.XYZ.Y * coefY, pos.XYZ.Z * coefZ));
                box.LengthAxis = Basics.HalfAxis.ToVector3D(HalfAxis.Transform(pos.Axis1, t)); ;
                box.WidthAxis = Basics.HalfAxis.ToVector3D(HalfAxis.Transform(pos.Axis2, t)); ;
                graphics.AddBox(box);
            }
        }
        #endregion
    }
    #endregion

    #region Pallet
    public class Pallet
    {
        #region Data members
        private double _length, _width, _height;
        private Color _color;
        private string _typeName;
        #endregion

        #region Constructor
        public Pallet(PalletProperties palletProperties)
        {
            _length = palletProperties.Length;
            _width = palletProperties.Width;
            _height = palletProperties.Height;
            _color = palletProperties.Color;
            _typeName = palletProperties.TypeName;
        }
        #endregion

        #region Overrides
        public void Draw(Graphics3D graphics, Transform3D t)
        {
            if (_length == 0.0 || _width == 0.0 || _height == 0.0)
                return;

            PalletData palletType = PalletData.GetByName(_typeName);
            if (null != palletType)
                palletType.Draw(graphics, new Vector3D(_length, _width, _height), _color, t);

        }
        #endregion

        #region Public properties
        public Face[] Faces
        {
            get
            {
                Face[] faces = new Face[6];
                // points
                Vector3D[] points = new Vector3D[8];
                points[0] = Vector3D.Zero;
                points[1] = _length * Vector3D.XAxis;
                points[2] = _length * Vector3D.XAxis + _width * Vector3D.YAxis;
                points[3] = _width * Vector3D.YAxis;
                points[4] = _height * Vector3D.ZAxis;
                points[5] = _length * Vector3D.XAxis + _height * Vector3D.ZAxis;
                points[6] = _length * Vector3D.XAxis + _width * Vector3D.YAxis + _height * Vector3D.ZAxis;
                points[7] = _width * Vector3D.YAxis + _height * Vector3D.ZAxis;

                faces[0] = new Face(0, new Vector3D[] { points[3], points[0], points[4], points[7] }); // AXIS_X_N
                faces[1] = new Face(0, new Vector3D[] { points[1], points[2], points[6], points[5] }); // AXIS_X_P
                faces[2] = new Face(0, new Vector3D[] { points[0], points[1], points[5], points[4] }); // AXIS_Y_N
                faces[3] = new Face(0, new Vector3D[] { points[2], points[3], points[7], points[6] }); // AXIS_Y_P
                faces[4] = new Face(0, new Vector3D[] { points[3], points[2], points[1], points[0] }); // AXIS_Z_N
                faces[5] = new Face(0, new Vector3D[] { points[4], points[5], points[6], points[7] }); // AXIS_Z_P

                foreach (Face face in faces)
                    face.ColorFill = _color;

                return faces;            
            }
        }
        #endregion
    }
    #endregion
}
