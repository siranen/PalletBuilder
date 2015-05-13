#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using TreeDim.StackBuilder.Basics;
using Sharp3D.Math.Core;

using log4net;
#endregion

namespace TreeDim.StackBuilder.Engine
{
    #region PackPalletSolver
    /// <summary>
    /// PackPalletSolver
    /// </summary>
    public class PackPalletSolver : IPackPalletAnalysisSolver
    {
        #region Data members
        private static List<LayerPattern> _patterns = new List<LayerPattern>();
        private PackProperties _packProperties;
        private PalletProperties _palletProperties;
        private InterlayerProperties _interlayerProperties;
        private PackPalletConstraintSet _constraintSet;
        #endregion

        #region Constructor
        public PackPalletSolver()
        {
            PackPalletSolver.LoadPatterns();
        }
        #endregion

        #region IPackPalletAnalysisSolver
        public void ProcessAnalysis(PackPalletAnalysis analysis)
        {
            _packProperties = analysis.PackProperties;
            _palletProperties = analysis.PalletProperties;
            _interlayerProperties = analysis.InterlayerProperties;
            _constraintSet = analysis.ConstraintSet;
            analysis.Solutions = GenerateSolutions();
        }
        #endregion

        #region Private methods
        private List<PackPalletSolution> GenerateSolutions()
        {
            List<PackPalletSolution> solutions = new List<PackPalletSolution>();

            HalfAxis.HAxis[] axes = { HalfAxis.HAxis.AXIS_Z_N, HalfAxis.HAxis.AXIS_Z_P };
            // loop throught all patterns
            foreach (LayerPattern pattern in _patterns)
            {
                // loop throught all axes
                foreach (HalfAxis.HAxis axis in axes) // axis
                {
                    // loop through
                    Layer layer = new Layer(_packProperties, _palletProperties, _constraintSet, axis, false);
                    double actualLength = 0.0, actualWidth = 0.0;
                    pattern.GetLayerDimensionsChecked(layer, out actualLength, out actualWidth);
                    pattern.GenerateLayer(layer, actualLength, actualWidth);

                    // filter by layer weight
                    if (_constraintSet.MaximumLayerWeight.Activated
                        && (layer.Count * _packProperties.Weight > _constraintSet.MaximumLayerWeight.Value))
                        continue;
                    // filter by maximum space
                    if (_constraintSet.MaximumSpaceAllowed.Activated
                        && layer.MaximumSpace > _constraintSet.MaximumSpaceAllowed.Value)
                        continue;
                    double layerHeight = layer.BoxHeight;

                    string title = string.Format("{0}-{1}", pattern.Name, axis.ToString());
                    double zLayer = 0.0;
                    BoxLayer boxLayer = new BoxLayer(zLayer, "");
                    foreach (LayerPosition layerPos in layer)
                    {
                        LayerPosition layerPosTemp = AdjustLayerPosition(layerPos);
                        BoxPosition boxPos = new BoxPosition(
                            layerPosTemp.Position
                                - (0.5 * _constraintSet.OverhangX) * Vector3D.XAxis
                                - (0.5 * _constraintSet.OverhangY) * Vector3D.YAxis
                                + zLayer * Vector3D.ZAxis
                            , layerPosTemp.LengthAxis
                            , layerPosTemp.WidthAxis
                            );
                        boxLayer.Add(boxPos);
                    }
                    boxLayer.MaximumSpace = layer.MaximumSpace;
                    BBox3D layerBBox = boxLayer.BoundingBox(_packProperties);
                    // filter by overhangX
                    if (_constraintSet.MinOverhangX.Activated
                        && (0.5 * (layerBBox.Length - _palletProperties.Length) < _constraintSet.MinOverhangX.Value))
                        continue;
                    // filter by overhangY
                    if (_constraintSet.MinOverhangY.Activated
                        && (0.5 * (layerBBox.Width - _palletProperties.Width) < _constraintSet.MinOverhangY.Value))
                        continue;

                    double interlayerThickness = null != _interlayerProperties ? _interlayerProperties.Thickness : 0;
                    double interlayerWeight = null != _interlayerProperties ? _interlayerProperties.Weight : 0;

                    PackPalletSolution sol = new PackPalletSolution(null, title, boxLayer);
                    int noLayer = 1,
                        noInterlayer = (null != _interlayerProperties && _constraintSet.HasFirstInterlayer) ? 1 : 0;

                    bool maxHeightReached = _constraintSet.MaximumPalletHeight.Activated
                        && (_packProperties.Height
                        + noInterlayer * interlayerThickness
                        + noLayer * layer.BoxHeight) > _constraintSet.MaximumPalletHeight.Value;
                    bool maxWeightReached = _constraintSet.MaximumPalletWeight.Activated
                        && (_palletProperties.Weight
                        + noInterlayer * interlayerWeight
                        + noLayer * boxLayer.Count * _packProperties.Weight > _constraintSet.MaximumPalletWeight.Value);

                    noLayer = 0; noInterlayer = 0;
                    int iCountInterlayer = 0, iCountSwap = 1;
                    bool bSwap = false;
                    while (!maxHeightReached && !maxWeightReached)
                    {
                        bool bInterlayer = (0 == iCountInterlayer) && ((noLayer != 0) || _constraintSet.HasFirstInterlayer);
                        // actually insert new layer
                        sol.AddLayer(bSwap, bInterlayer);
                        // increment number of layers
                        noLayer++;
                        noInterlayer += (bInterlayer ? 1 : 0);
                        // update iCountInterlayer && iCountSwap
                        ++iCountInterlayer;
                        if (iCountInterlayer >= _constraintSet.InterlayerPeriod) iCountInterlayer = 0;
                        ++iCountSwap;
                        if (iCountSwap > _constraintSet.LayerSwapPeriod) { iCountSwap = 1; bSwap = !bSwap; }
                        // update maxHeightReached & maxWeightReached
                        maxHeightReached = _constraintSet.MaximumPalletHeight.Activated
                            && (_palletProperties.Height
                            + (noInterlayer + (iCountInterlayer == 0 ? 1 : 0)) * interlayerThickness
                            + (noLayer + 1) * layer.BoxHeight) > _constraintSet.MaximumPalletHeight.Value;
                        maxWeightReached = _constraintSet.MaximumPalletWeight.Activated
                            && (_palletProperties.Weight
                            + (noInterlayer + (iCountInterlayer == 0 ? 1 : 0)) * interlayerWeight
                            + (noLayer + 1) * boxLayer.Count * _packProperties.Weight > _constraintSet.MaximumPalletWeight.Value);
                    }

                    if (sol.PackCount > 0)
                        solutions.Add(sol);
                } // axis
            } // pattern
            solutions.Sort();
            return solutions;
        }

        /// <summary>
        /// if box bottom oriented to Z+, reverse box
        /// </summary>
        private LayerPosition AdjustLayerPosition(LayerPosition layerPos)
        {
            LayerPosition layerPosTemp = layerPos;
            if (layerPosTemp.HeightAxis == HalfAxis.HAxis.AXIS_Z_N)
            {
                if (layerPosTemp.LengthAxis == HalfAxis.HAxis.AXIS_X_P)
                {
                    layerPosTemp.WidthAxis = HalfAxis.HAxis.AXIS_Y_P;
                    layerPosTemp.Position += new Vector3D(0.0, -_packProperties.Width, -_packProperties.Height);
                }
                else if (layerPos.LengthAxis == HalfAxis.HAxis.AXIS_Y_P)
                {
                    layerPosTemp.WidthAxis = HalfAxis.HAxis.AXIS_X_N;
                    layerPosTemp.Position += new Vector3D(_packProperties.Width, 0.0, -_packProperties.Height);
                }
                else if (layerPos.LengthAxis == HalfAxis.HAxis.AXIS_X_N)
                {
                    layerPosTemp.LengthAxis = HalfAxis.HAxis.AXIS_X_P;
                    layerPosTemp.Position += new Vector3D(-_packProperties.Length, 0.0, -_packProperties.Height);
                }
                else if (layerPos.LengthAxis == HalfAxis.HAxis.AXIS_Y_N)
                {
                    layerPosTemp.WidthAxis = HalfAxis.HAxis.AXIS_X_P;
                    layerPosTemp.Position += new Vector3D(-_packProperties.Width, 0.0, -_packProperties.Height);
                }
            }
            return layerPosTemp;
        }
        #endregion

        #region Static methods
        private static void LoadPatterns()
        {
            if (0 == _patterns.Count)
            {
                _patterns.Add(new LayerPatternColumn());
                _patterns.Add(new LayerPatternInterlocked());
                _patterns.Add(new LayerPatternDiagonale());
                _patterns.Add(new LayerPatternTrilock());
                _patterns.Add(new LayerPatternSpirale());
                _patterns.Add(new LayerPatternEnlargedSpirale());
            }
        }
        #endregion
    }
    #endregion
}
