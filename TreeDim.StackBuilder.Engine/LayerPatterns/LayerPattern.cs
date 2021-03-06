﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using treeDiM.StackBuilder.Basics;

using Sharp3D.Math.Core;
using log4net;
#endregion

namespace treeDiM.StackBuilder.Engine
{
    /// <summary>
    /// Layer pattern abstract class
    /// </summary>
    internal abstract class LayerPattern
    {
        #region Abstract methods
        abstract public string Name { get; }
        abstract public bool GetLayerDimensions(Layer layer, out double actualLength, out double actualWidth);
        abstract public void GenerateLayer(Layer layer, double actualLength, double actualWidth);
        abstract public int GetNumberOfVariants(Layer layer);
        abstract public bool CanBeSwapped { get; }
        abstract public bool CanBeInverted { get; }
        #endregion

        #region Public properties
        public int VariantIndex
        {
            get { return _variantIndex; }
            set { _variantIndex = value; }
        }
        public bool Swapped
        {
            get { return _swapped; }
            set
            {
                _swapped = value;
                if (!CanBeSwapped && _swapped)
                    throw new EngineException(string.Format("Pattern {0} can not be swapped.", Name));
            }
        }
        #endregion

        #region Private methods
        protected double GetPalletLength(Layer layer)
        {
            if (!_swapped)
                return layer.PalletLength;
            else
                return layer.PalletWidth;
        }

        protected double GetPalletWidth(Layer layer)
        { 
            if (!_swapped)
                return layer.PalletWidth;
            else
                return layer.PalletLength;        
        }

        public bool GetLayerDimensionsChecked(Layer layer, out double actualLength, out double actualWidth)
        {
            bool result = GetLayerDimensions(layer, out actualLength, out actualWidth);
            if (actualLength > GetPalletLength(layer))
                throw new EngineException(string.Format("Pattern name={0} : actualLength={1} > palletLength={2} ?"
                    , this.Name, actualLength, GetPalletLength(layer)));
            if (actualWidth > GetPalletWidth(layer))
                throw new EngineException(string.Format("Pattern name={0} : actualWidth={1} > palletWidth={2} ?"
                    , this.Name, actualWidth, GetPalletWidth(layer)));
            return result;
        }

        public void AddPosition(Layer layer, Vector2D vPosition, HalfAxis.HAxis lengthAxis, HalfAxis.HAxis widthAxis)
        {
            Matrix4D matRot = Matrix4D.Identity;
            Vector3D vTranslation = Vector3D.Zero;

            if (_swapped && !layer.Inversed)
            {
                matRot = new Matrix4D(
                    0.0, -1.0, 0.0, 0.0
                    , 1.0, 0.0, 0.0, 0.0
                    , 0.0, 0.0, 1.0, 0.0
                    , 0.0, 0.0, 0.0, 1.0
                    );
                vTranslation = new Vector3D(layer.PalletLength, 0.0, 0.0);
            }
            else if (!_swapped && layer.Inversed)
            {
                matRot = new Matrix4D(
                    -1.0, 0.0, 0.0, 0.0
                    , 0.0, -1.0, 0.0, 0.0
                    , 0.0, 0.0, 1.0, 0.0
                    , 0.0, 0.0, 0.0, 1.0
                    );
                vTranslation = new Vector3D(layer.PalletLength, layer.PalletWidth, 0.0);
            }
            else if (_swapped && layer.Inversed)
            {
                matRot = new Matrix4D(
                    0.0, 1.0, 0.0, 0.0
                    , -1.0, 0.0, 0.0, 0.0
                    , 0.0, 0.0, 1.0, 0.0
                    , 0.0, 0.0, 0.0, 1.0
                    );
                vTranslation = new Vector3D(0.0, layer.PalletWidth, 0.0);
            }
            Transform3D transfRot = new Transform3D(matRot);
            HalfAxis.HAxis lengthAxisSwapped = StackBuilder.Basics.HalfAxis.ToHalfAxis(transfRot.transform(StackBuilder.Basics.HalfAxis.ToVector3D(lengthAxis)));
            HalfAxis.HAxis widthAxisSwapped = StackBuilder.Basics.HalfAxis.ToHalfAxis(transfRot.transform(StackBuilder.Basics.HalfAxis.ToVector3D(widthAxis)));

            matRot.M14 = vTranslation[0];
            matRot.M24 = vTranslation[1];
            matRot.M34 = vTranslation[2];

            Transform3D transfRotTranslation = new Transform3D(matRot);
            Vector3D vPositionSwapped = transfRotTranslation.transform(new Vector3D(vPosition.X, vPosition.Y, 0.0));

            if (!layer.IsValidPosition(new Vector2D(vPositionSwapped.X, vPositionSwapped.Y), lengthAxisSwapped, widthAxisSwapped))
            {
                _log.Warn(string.Format("Attempt to add an invalid position in pattern = {0}, Variant = {1}, Swapped = true", this.Name, _variantIndex));
                return;
            }
            layer.AddPosition(new Vector2D(vPositionSwapped.X, vPositionSwapped.Y), lengthAxisSwapped, widthAxisSwapped);
        }
        #endregion

        #region Data members
        private int _variantIndex = 0;
        private bool _swapped = false;
        protected static readonly ILog _log = LogManager.GetLogger(typeof(LayerPattern));
        #endregion
    }
}
