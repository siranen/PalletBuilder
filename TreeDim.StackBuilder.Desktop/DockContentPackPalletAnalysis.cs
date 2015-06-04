#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Docking
using WeifenLuo.WinFormsUI.Docking;
// log4net
using log4net;
using Sharp3D.Math.Core;
using TreeDim.StackBuilder.Basics;
using TreeDim.StackBuilder.Graphics;
using TreeDim.StackBuilder.Desktop.Properties;
#endregion

namespace TreeDim.StackBuilder.Desktop
{
    public partial class DockContentPackPalletAnalysis : DockContent, IView, IItemListener, IDrawingContainer
    {
        #region Data members
        /// <summary>
        /// document
        /// </summary>
        private IDocument _document;
        /// <summary>
        /// Pack pallet analysis
        /// </summary>
        private PackPalletAnalysis _analysis;
        /// <summary>
        /// Pack pallet analysis solution
        /// </summary>
        private PackPalletSolution _sol;
        /// <summary>
        /// logger
        /// </summary>
        static readonly ILog _log = LogManager.GetLogger(typeof(DockContentPackPalletAnalysis));
        #endregion

        #region Constructor
        public DockContentPackPalletAnalysis(IDocument document, PackPalletAnalysis analysis)
        {
            _document = document;
            _analysis = analysis;
            _analysis.AddListener(this);

            InitializeComponent();

            _analysis.SolutionSelected += new PackPalletAnalysis.SelectSolution(onSolutionSelectionChanged);
            _analysis.SolutionSelectionRemoved += new PackPalletAnalysis.SelectSolution(onSolutionSelectionChanged);
        }

        void onSolutionSelectionChanged(PackPalletAnalysis analysis, SelPackPalletSolution selSolution)
        {
            UpdateSelectButtonText();
            UpdateGridCheckBoxes();
        }
        #endregion

        #region Form override
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // initialize drawing container
            graphCtrlSolution.DrawingContainer = this;
            // set window caption
            this.Text = _analysis.Name + " - " + _analysis.ParentDocument.Name;
            // fill grid
            FillGrid();

            gridSolutions.Selection.SelectionChanged += new SourceGrid.RangeRegionChangedEventHandler(onGridSolutionSelectionChanged);
        }
        #endregion

        #region FillGrid
        private void FillGrid()
        {
            // fill grid solution
            gridSolutions.Rows.Clear();

            // border
            DevAge.Drawing.BorderLine border = new DevAge.Drawing.BorderLine(Color.DarkBlue, 1);
            DevAge.Drawing.RectangleBorder cellBorder = new DevAge.Drawing.RectangleBorder(border, border);

            // views
            CellBackColorAlternate viewNormal = new CellBackColorAlternate(Color.LightBlue, Color.White);
            viewNormal.Border = cellBorder;
            CheckboxBackColorAlternate viewNormalCheck = new CheckboxBackColorAlternate(Color.LightBlue, Color.White);
            viewNormalCheck.Border = cellBorder;

            // column header view
            SourceGrid.Cells.Views.ColumnHeader viewColumnHeader = new SourceGrid.Cells.Views.ColumnHeader();
            DevAge.Drawing.VisualElements.ColumnHeader backHeader = new DevAge.Drawing.VisualElements.ColumnHeader();
            backHeader.BackColor = Color.LightGray;
            backHeader.Border = DevAge.Drawing.RectangleBorder.NoBorder;
            viewColumnHeader.Background = backHeader;
            viewColumnHeader.ForeColor = Color.White;
            viewColumnHeader.Font = new Font("Arial", 10, FontStyle.Bold);
            viewColumnHeader.ElementSort.SortStyle = DevAge.Drawing.HeaderSortStyle.None;

            // create the grid
            gridSolutions.BorderStyle = BorderStyle.FixedSingle;

            gridSolutions.ColumnsCount = 8;
            gridSolutions.FixedRows = 1;
            gridSolutions.Rows.Insert(0);

            // header
            SourceGrid.Cells.ColumnHeader columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(Resources.ID_LAYERPATTERN);
            columnHeader.AutomaticSortEnabled = false;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 0] = columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(Resources.ID_PACKCOUNT);
            columnHeader.AutomaticSortEnabled = false;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 1] = columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(Resources.ID_CONSUMERSALESUNITS);
            columnHeader.AutomaticSortEnabled = true;
            columnHeader.View = viewColumnHeader;
            columnHeader.SortComparer = new SourceGrid.MultiColumnsComparer();
            gridSolutions[0, 2] = columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(string.Format(Resources.ID_LAYERWEIGHT, UnitsManager.MassUnitString));
            columnHeader.AutomaticSortEnabled = true;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 3] = columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(string.Format(Resources.ID_PALLETWEIGHT, UnitsManager.MassUnitString));
            columnHeader.AutomaticSortEnabled = true;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 4] = columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(string.Format(Resources.ID_PALLETHEIGHT, UnitsManager.LengthUnitString));
            columnHeader.AutomaticSortEnabled = true;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 5] = columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(string.Format(Resources.ID_MAXIMUMSPACE, UnitsManager.LengthUnitString));
            columnHeader.AutomaticSortEnabled = true;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 6] = columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(Resources.ID_SELECTED);
            columnHeader.AutomaticSortEnabled = true;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 7] = columnHeader;

            // handling check box click
            SourceGrid.Cells.Controllers.CustomEvents solCheckboxClickEvent = new SourceGrid.Cells.Controllers.CustomEvents();
            solCheckboxClickEvent.Click += new EventHandler(clickEvent_Click);

            // data rows
            int iIndex = 0;
            foreach (PackPalletSolution sol in _analysis.Solutions)
            {
                // build case count string
                string sPackCount = string.Format("{0}\n({1} * {2})", sol.PackCount, sol.PackPerLayer, sol.LayerCount);
                string sCSUCount = string.Format("{0}", sol.CSUCount);
                // insert row
                gridSolutions.Rows.Insert(++iIndex);
                gridSolutions.Rows[iIndex].Tag = sol;

                // filling columns
                {
                    Graphics2DImage graphics = new Graphics2DImage(new Size(100, 50));
                    PackPalletSolutionViewer sv = new PackPalletSolutionViewer(sol);
                    sv.Draw(graphics);
                    gridSolutions[iIndex, 0] = new SourceGrid.Cells.Image(graphics.Bitmap);
                }
                gridSolutions[iIndex, 1] = new SourceGrid.Cells.Cell(sPackCount);
                gridSolutions[iIndex, 2] = new SourceGrid.Cells.Cell(sCSUCount);
                gridSolutions[iIndex, 3] = new SourceGrid.Cells.Cell(Math.Round(sol.LayerWeight, 3));
                gridSolutions[iIndex, 4] = new SourceGrid.Cells.Cell(Math.Round(sol.PalletWeight, 3));
                gridSolutions[iIndex, 5] = new SourceGrid.Cells.Cell(Math.Round(sol.PalletHeight, 1));
                gridSolutions[iIndex, 6] = new SourceGrid.Cells.Cell(Math.Round(sol.MaximumSpace, 1));
                gridSolutions[iIndex, 7] = new SourceGrid.Cells.CheckBox(null, _analysis.HasSolutionSelected(iIndex - 1));

                gridSolutions[iIndex, 0].View = viewNormal;
                gridSolutions[iIndex, 1].View = viewNormal;
                gridSolutions[iIndex, 2].View = viewNormal;
                gridSolutions[iIndex, 3].View = viewNormal;
                gridSolutions[iIndex, 4].View = viewNormal;
                gridSolutions[iIndex, 5].View = viewNormal;
                gridSolutions[iIndex, 6].View = viewNormal;
                gridSolutions[iIndex, 7].View = viewNormalCheck;

                gridSolutions[iIndex, 7].AddController(solCheckboxClickEvent);
            }
            gridSolutions.AutoStretchColumnsToFitWidth = true;
            gridSolutions.AutoSizeCells();
            gridSolutions.Columns.StretchToFit();

            // select first solution
            gridSolutions.Selection.SelectRow(1, true);
            graphCtrlSolution.Invalidate();
        }
        #endregion

        #region Event handlers
        /// <summary>
        /// grid line clicked
        /// </summary>
        private void clickEvent_Click(object sender, EventArgs e)
        {
            SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
            int iSel = context.Position.Row;
            // select row
            gridSolutions.Selection.SelectRow(iSel, true);
            // get selected solution
            PackPalletSolution sol = gridSolutions.Rows[iSel].Tag as PackPalletSolution;
            if (!_analysis.HasSolutionSelected(sol))
                _analysis.SelectSolutionBySol(sol);
            else
                _analysis.UnselectSolutionBySol(sol);        
        }
        private void onGridSolutionSelectionChanged(object sender, SourceGrid.RangeRegionChangedEventArgs e)
        {
            SourceGrid.RangeRegion region = gridSolutions.Selection.GetSelectionRegion();
            int[] indexes = region.GetRowsIndex();
            // no selection -> exit
            if (indexes.Length == 0) return;
            // get selected solution
            _sol = gridSolutions.Rows[indexes[0]].Tag as PackPalletSolution;
            //_sol = _analysis.Solutions[indexes[0]];
            // update select/unselect button text
            UpdateSelectButtonText();
            // redraw
            graphCtrlSolution.Invalidate();
        }
        private void pictureBoxSolution_SizeChanged(object sender, EventArgs e)
        {
            graphCtrlSolution.Height = this.splitContainerHoriz.Panel1.Height - btSelectSolution.Height - 4;
            btSelectSolution.Location = new Point(this.splitContainerHoriz.Panel1.Width - btSelectSolution.Width - 2, this.splitContainerHoriz.Panel1.Height - btSelectSolution.Height - 2);
        }
        private void btSelectSolution_Click(object sender, EventArgs e)
        {
            try
            {
                int iSel = GetCurrentSolutionIndex();
                // get selected solution
                _sol = gridSolutions.Rows[iSel].Tag as PackPalletSolution;
                if (null == _sol) return;
                if (!_analysis.HasSolutionSelected(_sol))
                    _analysis.SelectSolutionBySol(_sol);
                else
                    _analysis.UnselectSolutionBySol(_sol);
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }
        } 
        #endregion

        #region Solution selection
        private void UpdateGridCheckBoxes()
        {
            int iRow = 0;
            foreach (PackPalletSolution sol in _analysis.Solutions)
            {
                ++iRow;
                SourceGrid.Cells.CheckBox checkBox = gridSolutions[iRow, 7] as SourceGrid.Cells.CheckBox;
                if (null != checkBox)
                    checkBox.Checked = _analysis.HasSolutionSelected(iRow - 1);
            }
        }
        private void UpdateSelectButtonText()
        {
            int iSel = GetCurrentSolutionIndex();
            btSelectSolution.Enabled = (iSel != -1);
            if (-1 == iSel) return; // no valid selection
            btSelectSolution.Text = _analysis.HasSolutionSelected(iSel) ? Properties.Resources.ID_DESELECT : Properties.Resources.ID_SELECT;
        }
        private int GetCurrentSolutionIndex()
        {
            PackPalletSolution sol = GetCurrentSolution();
            if (null == sol) return -1;
            // find and return index of sol
            return _analysis.Solutions.IndexOf(sol, 0);
        }
        private PackPalletSolution GetCurrentSolution()
        {
            SourceGrid.RangeRegion region = gridSolutions.Selection.GetSelectionRegion();
            int[] indexes = region.GetRowsIndex();
            // no selection -> exit
            if (indexes.Length == 0) return null;
            else return gridSolutions.Rows[indexes[0]].Tag as PackPalletSolution;
        }
        #endregion

        #region IItemListener implementation
        public void Update(ItemBase item)
        { 
            // update grid
            FillGrid();
            // select first solution
            if (gridSolutions.RowsCount > 0)
                gridSolutions.Selection.SelectRow(1, true);
            if (_analysis.Solutions.Count > 0)
                _sol = _analysis.Solutions[0];
            // draw
            graphCtrlSolution.Invalidate();
        }
        public void Kill(ItemBase item)
        {
            Close();
            _analysis.RemoveListener(this);
        }

        #endregion

        #region IView implementation
        public IDocument Document
        {
            get { return _document; }
        }
        #endregion

        #region Public properties
        public PackPalletAnalysis Analysis
        {
            get { return _analysis; }
        }
        #endregion

        #region IDrawing container
        public void Draw(Graphics3DControl ctrl, Graphics3D graphics)
        { 
            // instantiate solution viewer
            PackPalletSolutionViewer sv = new PackPalletSolutionViewer(GetCurrentSolution());
            sv.Draw(graphics);
        }
        #endregion
    }
}
