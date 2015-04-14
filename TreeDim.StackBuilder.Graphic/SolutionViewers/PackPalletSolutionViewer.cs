#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using TreeDim.StackBuilder.Basics;
using Sharp3D.Math.Core;
#endregion

namespace TreeDim.StackBuilder.Graphics
{
    public class PackPalletSolutionViewer
    {
        #region Data members
        private PackPalletSolution _solution;
        private PackPalletAnalysis _analysis;
        private bool _showDimensions = true;
        #endregion

        #region Constructor
        public PackPalletSolutionViewer(PackPalletSolution solution)
        {
            _analysis = null != solution ? solution.Analysis : null;
            _solution = solution;
        }
        #endregion

        #region Public methods
        public void Draw(Graphics2D graphics)
        { 
        }
        public void Draw(Graphics3D graphics)
        {
            // sanity check
            if (null == _solution) return;
            InterlayerProperties interlayerProperties = _analysis.InterlayerProperties;
            // draw pallet
            Pallet pallet = new Pallet(_analysis.PalletProperties);
            pallet.Draw(graphics, Transform3D.Identity);
            // draw solution
            uint pickid = 0;
            for (int iLayerIndex = 0; iLayerIndex < _solution.LayerCount; ++iLayerIndex)
            {
                bool hasInterlayer = false;
                double zInterlayer = 0.0;
                BoxLayer blayer = _solution.GetBoxLayer(iLayerIndex, ref hasInterlayer, ref zInterlayer);

                if (hasInterlayer && (null != interlayerProperties))
                {
                    // instantiate box
                    Box box = new Box(pickid++, interlayerProperties);
                    // set position
                    box.Position = new Vector3D(
                        0.5 * (_analysis.PalletProperties.Length - interlayerProperties.Length)
                        , 0.5 * (_analysis.PalletProperties.Width - interlayerProperties.Width)
                        , zInterlayer);
                    // draw
                    graphics.AddBox(box);
                }

                foreach (BoxPosition bPosition in blayer)
                    graphics.AddBox(new Box(pickid++, _analysis.PackProperties, bPosition));

                if (_showDimensions)
                {
                    graphics.AddDimensions(
                        new DimensionCube(BoundingBoxDim(Properties.Settings.Default.DimCasePalletSol1)
                        , Color.Black, false));
                    graphics.AddDimensions(
                        new DimensionCube(BoundingBoxDim(Properties.Settings.Default.DimCasePalletSol2)
                        , Color.Red, true));
                }
            }
        }

        private BBox3D BoundingBoxDim(int index)
        {
            switch (index)
            {
                case 0: return _solution.BoundingBox;//_solution.BoundingBox;
                case 1: return _solution.LoadBoundingBox;//_solution.LoadBoundingBox;
                case 2: return _analysis.PalletProperties.BoundingBox;
                case 3: return new BBox3D(0.0, 0.0, 0.0, _analysis.PalletProperties.Length, _analysis.PalletProperties.Width, 0.0);
                default: return _solution.BoundingBox;
            }
        }
        #endregion

    }
}
