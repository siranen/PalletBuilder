#region Using directives
using System;
using System.Collections.Generic;
using System.Text;

using Sharp3D.Math.Core;
using TreeDim.StackBuilder.Basics;
#endregion

namespace TreeDim.StackBuilder.Engine
{
    class LayerPatternInterlockedFilled : LayerPattern
    {
        #region Implementation of LayerPattern abstract properties and methods
        public override string Name { get { return "Interlocked Filled"; } }

        public override bool GetLayerDimensions(Layer layer, out double actualLength, out double actualWidth)
        {
            double boxLength = layer.BoxLength;
            double boxWidth = layer.BoxWidth;
            double palletLength = GetPalletLength(layer);
            double palletWidth = GetPalletWidth(layer);

            int maxSizeXLength = 0, maxSizeXWidth = 0, maxSizeYLength = 0, maxSizeYWidth = 0;
            int fillSizeXLength = 0, fillSizeYLength = 0, fillSizeXWidth = 0, fillSizeYWidth = 0;

            GetSizeXY(boxLength, boxWidth, palletLength, palletWidth
                , out maxSizeXLength, out maxSizeYLength, out maxSizeXWidth, out maxSizeYWidth
                , out fillSizeXLength, out fillSizeYLength, out fillSizeXWidth, out fillSizeYWidth);

            actualLength = Math.Max(maxSizeXLength * boxLength, fillSizeXLength * boxWidth) + Math.Max(maxSizeXWidth * boxWidth, fillSizeXWidth * boxLength);
            actualWidth = Math.Max(maxSizeYLength * boxWidth + fillSizeYLength * boxLength, maxSizeYWidth * boxLength + fillSizeYWidth * boxWidth);

            return maxSizeXLength > 0 && maxSizeYLength > 0
                && maxSizeXWidth > 0 && maxSizeYWidth > 0
                && (
                    ((maxSizeYLength % 2 == 0) && (fillSizeXLength * fillSizeYLength > 0))
                    || ((maxSizeYWidth % 2 == 0) && (fillSizeXWidth * fillSizeYWidth > 0))
                    );
        }
        public override void GenerateLayer(Layer layer, double actualLength, double actualWidth)
        {
            layer.Clear();

            double boxLength = layer.BoxLength;
            double boxWidth = layer.BoxWidth;
            double palletLength = GetPalletLength(layer);
            double palletWidth = GetPalletWidth(layer);

            int maxSizeXLength = 0, maxSizeXWidth = 0, maxSizeYLength = 0, maxSizeYWidth = 0;
            int fillSizeXLength = 0, fillSizeYLength = 0, fillSizeXWidth = 0, fillSizeYWidth = 0;
            GetSizeXY(boxLength, boxWidth, palletLength, palletWidth
                , out maxSizeXLength, out maxSizeYLength, out maxSizeXWidth, out maxSizeYWidth
                , out fillSizeXLength, out fillSizeYLength, out fillSizeXWidth, out fillSizeYWidth);

            double offsetX = 0.5 * (palletLength - actualLength);
            double offsetY = 0.5 * (palletWidth - actualWidth);

            double spaceX = maxSizeXLength + maxSizeXWidth > 1 ? (actualLength - (maxSizeXLength * boxLength + maxSizeXWidth * boxWidth)) / (maxSizeXLength + maxSizeXWidth - 1) : 0.0;
            double spaceYLength = maxSizeYLength > 1 ? (actualWidth - maxSizeYLength * boxWidth - fillSizeYLength * boxLength) / (maxSizeYLength + fillSizeYLength - 1) : 0.0;
            double spaceYWidth = maxSizeYWidth > 1 ? (actualWidth - maxSizeYWidth * boxLength - fillSizeYWidth * boxWidth) / (maxSizeYWidth + fillSizeYWidth - 1) : 0.0;

            if (1 == maxSizeYLength % 2)
            {
                // LENGTH
                for (int i = 0; i < maxSizeXLength; ++i)
                    for (int j = 0; j < maxSizeYLength; ++j)
                    {
                        AddPosition(
                            layer
                            , new Vector2D(
                                offsetX + i * (boxLength + spaceX)
                                , offsetY + j * (boxWidth + spaceYLength))
                            , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P);
                    }
            }
            else
            {
                // LENGTH
                for (int i = 0; i < maxSizeXLength; ++i)
                    for (int j = 0; j < maxSizeYLength / 2; ++j)
                    {
                        AddPosition(
                            layer
                            , new Vector2D(
                                offsetX + i * (boxLength + spaceX)
                                , offsetY + j * (boxWidth + spaceYLength))
                            , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P);
                    }
                for (int i = 0; i < maxSizeXLength; ++i)
                    for (int j = maxSizeYLength / 2; j < maxSizeYLength; ++j)
                    {
                        AddPosition(
                            layer
                            , new Vector2D(
                                offsetX + i * (boxLength + spaceX)
                                , offsetY + j * (boxWidth + spaceYLength) + (fillSizeYLength > 0 ? (spaceYLength + boxLength) : 0.0))
                            , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P);
                    }
                for (int i = 0; i < fillSizeXLength; ++i)
                    for (int j = 0; j < fillSizeYLength; ++j)
                    {
                        AddPosition(
                            layer
                            , new Vector2D(
                                offsetX + (i + 1) * boxWidth
                                , offsetY + (maxSizeYLength / 2) * (boxWidth + spaceYLength) + j * boxLength)
                            , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N
                            );
                    }
            }
            // WIDTH
            if (1 == maxSizeYWidth % 2)
            {
                for (int i = 0; i < maxSizeXWidth; ++i)
                    for (int j = 0; j < maxSizeYWidth; ++j)
                    {
                        AddPosition(
                            layer
                            , new Vector2D(
                                offsetX + maxSizeXLength * (boxLength + spaceX) + i * (boxWidth + spaceX) + boxWidth
                                , offsetY + j * (boxLength + spaceYWidth))
                            , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N);
                    }
            }
            else
            {
                for (int i = 0; i < maxSizeXWidth; ++i)
                    for (int j = 0; j < maxSizeYWidth / 2; ++j)
                    {
                        AddPosition(
                            layer
                            , new Vector2D(
                                offsetX + maxSizeXLength * (boxLength + spaceX) + i * (boxWidth + spaceX) + boxWidth
                                , offsetY + j * (boxLength + spaceYWidth))
                            , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N);
                    }

                for (int i = 0; i < maxSizeXWidth; ++i)
                    for (int j = maxSizeYWidth / 2; j < maxSizeYWidth; ++j)
                    {
                        AddPosition(
                            layer
                            , new Vector2D(
                                offsetX + maxSizeXLength * (boxLength + spaceX) + i * (boxWidth + spaceX) + boxWidth
                                , offsetY + j * (boxLength + spaceYWidth) + (fillSizeYWidth > 0 ? (boxWidth + spaceYWidth) : 0.0))
                            , HalfAxis.HAxis.AXIS_Y_P, HalfAxis.HAxis.AXIS_X_N);
                    }
                for (int i = 0; i < fillSizeXWidth; ++i)
                    for (int j = 0; j < fillSizeYWidth; ++j)
                    {
                        AddPosition(
                            layer
                            , new Vector2D(
                                offsetX + maxSizeXLength * (boxLength + spaceX) + i * boxLength
                                , offsetY + (maxSizeYWidth / 2) * (boxLength + spaceYWidth) + j * boxWidth)
                            , HalfAxis.HAxis.AXIS_X_P, HalfAxis.HAxis.AXIS_Y_P
                            );
                    }
            }
            // maximum space
            layer.UpdateMaxSpace(spaceYLength);
            layer.UpdateMaxSpace(spaceYWidth);
            layer.UpdateMaxSpace(spaceX);
        }
        private void GetSizeXY(double boxLength, double boxWidth, double palletLength, double palletWidth,
            out int optSizeXLength,  out int optSizeYLength, out int optSizeXWidth, out int optSizeYWidth,
            out int optFillSizeXLength, out int optFillSizeYLength, out int optFillSizeXWidth, out int optFillSizeYWidth)
        {
            /*

            ┌─────────────┬─────────┐
            |             |         |
            |             |         |
   YLength  |             |         | YWidth
            |             |         |
            |             |         |
            └─────────────┴─────────┘
                XLength     XWidth
            */
            int optFound = 0;
            optSizeXLength = 0; optSizeXWidth = 0;
            optSizeYLength = 0; optSizeYWidth = 0;
            optFillSizeXLength = 0; optFillSizeYLength = 0;
            optFillSizeXWidth = 0; optFillSizeYWidth = 0;

            // get maximum number of box in length
            int sizeXLength = (int)Math.Floor(palletLength / boxLength);
            // make sure that we can actually add one column of turned boxes
            --sizeXLength;
            while (sizeXLength >= 1)
            {
                // get number of column of turned boxes
                int sizeXWidth = (int)Math.Floor((palletLength - sizeXLength * boxLength) / boxWidth);
                // get maximum number in width
                // for boxes with length aligned with pallet length
                int sizeYLength = (int)Math.Floor(palletWidth / boxWidth);
                // for turned boxes
                int sizeYWidth = (int)Math.Floor(palletWidth / boxLength);

                double spaceXLength = palletLength - sizeXWidth * boxWidth;
                int fillSizeXLength = (int)Math.Floor(spaceXLength / boxWidth);
                double spaceYLength = palletWidth - sizeYLength * boxWidth;
                int fillSizeYLength = (int)Math.Floor(spaceYLength / boxLength);

                double spaceXWidth = palletLength - sizeXLength * boxLength;
                int fillSizeXWidth = (int)Math.Floor(spaceXWidth / boxLength);
                double spaceYWidth = palletWidth - sizeYWidth * boxLength;
                int fillSizeYWidth = (int)Math.Floor(spaceYLength / boxWidth);

                int countLayer = sizeXLength * sizeYLength + sizeXWidth * sizeYWidth
                    + fillSizeYLength * fillSizeXLength + fillSizeYWidth * fillSizeXWidth;

                if (countLayer >= optFound)
                {
                    optFound = countLayer;
                    optSizeXLength = sizeXLength;
                    optSizeXWidth = sizeXWidth;
                    optSizeYLength = sizeYLength;
                    optSizeYWidth = sizeYWidth;

                    bool filledLength = (fillSizeXLength * fillSizeYLength > 0);
                    optFillSizeXLength = filledLength ? fillSizeXLength : 0;
                    optFillSizeYLength = filledLength ? fillSizeYLength : 0;
                    bool filledWidth = (fillSizeXWidth * fillSizeYWidth > 0);
                    optFillSizeXWidth = filledWidth ? fillSizeXWidth : 0;
                    optFillSizeYWidth = filledWidth ? fillSizeYWidth : 0;
                }
                --sizeXLength;
            }
        }
        public override int GetNumberOfVariants(Layer layer) { return 1; }
        public override bool CanBeSwapped { get { return true; } }
        public override bool CanBeInverted { get { return true; } }
        #endregion
    }
}
