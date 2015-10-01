#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace treeDiM.StackBuilder.Basics
{
    public class PackPalletConstraintSet
    {
        #region Data members
        #region Stop conditions
        // pallet height
        private OptDouble _maxPalletHeight = OptDouble.Zero;
        // pallet weight
        private OptDouble _maxPalletWeight = OptDouble.Zero;
        #endregion
        #region Layout contraints
        // min space
        private OptDouble _minSpace;
        // overhang x / y
        private double _overhangX= 0.0, _overhangY = 0.0; 
        // interlayer period 
        private int _interlayerPeriod;
        // layer swap period
        private int _layerSwapPeriod;
        // interlayer
        private bool _hasFirstInterlayer;
        #endregion
        #region Solution filtering
        // layer weight
        private OptDouble _layerWeight;
        // max space
        private OptDouble _maxSpaceAllowed;
        // min overhang x/y
        private OptDouble _minOverhangX, _minOverhangY;
        #endregion
        #endregion

        #region Constructor
        public PackPalletConstraintSet()
        {}
        #endregion

        #region Validity
        public bool IsValid
        { get { return (_maxPalletHeight.Activated || _maxPalletWeight.Activated); } }
        #endregion

        #region Stop conditions
        public OptDouble MaximumPalletHeight { get { return _maxPalletHeight; } set { _maxPalletHeight = value; } }
        public OptDouble MaximumPalletWeight { get { return _maxPalletWeight; } set { _maxPalletWeight = value; } }
        #endregion

        #region Layout constraints
        public OptDouble MinimumSpace { get { return _minSpace; } set { _minSpace = value; } }
        public double OverhangX { get { return _overhangX; } set { _overhangX = value; } }
        public double OverhangY { get { return _overhangY; } set { _overhangY = value; } }
        public int InterlayerPeriod { get { return _interlayerPeriod; } set { _interlayerPeriod = value; } }
        public int LayerSwapPeriod { get { return _layerSwapPeriod; } set { _layerSwapPeriod = value; } }
        public bool HasFirstInterlayer { get { return _hasFirstInterlayer; } set { _hasFirstInterlayer = value; } }
        #endregion

        #region Solution filtering
        public OptDouble MaximumLayerWeight { get { return _layerWeight; } set { _layerWeight = value; } }
        public OptDouble MaximumSpaceAllowed { get { return _maxSpaceAllowed; } set { _maxSpaceAllowed = value; } }
        public OptDouble MinOverhangX { get { return _minOverhangX; } set { _minOverhangX = value; } }
        public OptDouble MinOverhangY { get { return _minOverhangY; } set { _minOverhangY = value; } }
        #endregion

        #region Object method override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }
        #endregion
    }
}
