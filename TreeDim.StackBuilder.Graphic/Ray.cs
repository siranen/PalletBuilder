#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sharp3D.Math.Core;
#endregion

namespace TreeDim.StackBuilder.Graphics
{
    public class Ray
    {
        #region Constructor
        public Ray(Vector3D vNear, Vector3D vFar)
        {
            _orig = vNear; _dir = (vFar - vNear); _dir.Normalize();
        }
        #endregion

        #region Public properties
        public Vector3D Origin
        {
            get { return _orig; }
            set { _orig = value; }
        }
        public Vector3D Direction
        {
            get { return _dir; }
            set { _dir = value; }
        }
        #endregion

        #region Public methods
        public Vector3D Point(double t)
        { return _orig + t * _dir; }
        #endregion

        #region Data members
        private Vector3D _orig;
        private Vector3D _dir;
        #endregion
    }
}
