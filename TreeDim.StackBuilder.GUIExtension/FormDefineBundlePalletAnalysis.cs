#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using Sharp3D.Math.Core;

using TreeDim.StackBuilder.Basics;
using TreeDim.StackBuilder.Graphics;
using TreeDim.StackBuilder.Engine;
using TreeDim.StackBuilder.GUIExtension.Properties;
using TreeDim.StackBuilder.Reporting;

using log4net;
#endregion

namespace TreeDim.StackBuilder.GUIExtension
{
    public partial class FormDefineBundlePalletAnalysis : Form, IDrawingContainer
    {
        #region Data members
        private string _name;
        private List<PalletProperties> _pallets;
        private static readonly ILog _log = LogManager.GetLogger(typeof(FormDefineBundlePalletAnalysis));
        /// <summary>
        /// Document
        /// </summary>
        private Document _document;
        /// <summary>
        /// Case / Pallet analysis
        /// </summary>
        private CasePalletAnalysis _analysis;
        #endregion

        #region Constructor
        public FormDefineBundlePalletAnalysis()
        {
            InitializeComponent();
        }
        #endregion

        #region Form override
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // initialisation
            FlatWeight = Settings.Default.CaseWeight;
            NoFlats = Settings.Default.NoFlatsInBundle;
            MaximumPalletHeight = Settings.Default.PalletHeight;
            // graphic constainer initialization
            graphCtrlSolution.DrawingContainer = this;
            graphCtrlPallet.DrawingContainer = this;
            // load pallets
            LoadPallets();
            // compute
            Compute();
            gridSolutions.Selection.SelectionChanged += onGridSolutionSelectionChanged;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            // settings
            Settings.Default.PalletName = CurrentPallet.Name;
            Settings.Default.CaseWeight = FlatWeight;
            Settings.Default.NoFlatsInBundle = NoFlats;
            Settings.Default.PalletHeight = MaximumPalletHeight;
        }
        #endregion

        #region Implementation IDrawingContainer
        public void Draw(Graphics3DControl ctrl, Graphics3D graphics)
        {
            if (ctrl == graphCtrlPallet)
            {
                PalletProperties pp = CurrentPallet;
                Pallet pallet = new Pallet(pp);
                pallet.Draw(graphics, Transform3D.Identity);
                DimensionCube dc = new DimensionCube(pp.Length, pp.Width, pp.Height) { FontSize = 6.0f };
                graphics.AddDimensions(dc); 
            }
            else if (ctrl == graphCtrlSolution)
            {
                if (null == CurrentSolution) return;
                CasePalletSolutionViewer sv = new CasePalletSolutionViewer(CurrentSolution);
                sv.Draw(graphics);
            }
        }
        #endregion

        #region Grid
        private void Compute()
        {
            try
            {
                _document = new Document(_name, _name, "", DateTime.Now, null);
                _analysis = null;
                // bundle
                BundleProperties bundleProperties = _document.CreateNewBundle(_name, _name, FlatLength, FlatWidth, FlatThickness, FlatWeight, Color.Beige, NoFlats);
                // pallet
                PalletProperties palletProp = _document.CreateNewPallet(CurrentPallet);
                // constraint set
                BundlePalletConstraintSet constraintSet = new BundlePalletConstraintSet();
                constraintSet.OverhangX = 0.0;
                constraintSet.OverhangY = 0.0;
                constraintSet.UseMaximumNumberOfCases = false;
                constraintSet.UseMaximumPalletWeight = false;
                constraintSet.UseMaximumWeightOnBox = false;
                constraintSet.UseMaximumHeight = true;
                constraintSet.MaximumHeight = MaximumPalletHeight;
                constraintSet.AllowAlignedLayers = true;
                constraintSet.AllowAlternateLayers = true;
                constraintSet.AllowedPatternString = "Column,Diagonale,Interlocked,Trilock,Spirale";

                _analysis = _document.CreateNewCasePalletAnalysis(
                    _name, _name
                    ,bundleProperties , palletProp
                    , null /*interlayer */, null /* interlayerAntiSlip */
                    , null /* palletCorners */, null  /*palletCap */, null /* palletFilm */
                    , constraintSet
                    , new CasePalletSolver()
                    );
                // fill grid
                FillGrid();
            }
            catch (Exception ex)
            {
                _log.Error( ex.ToString());
            }
        }
        private void FillGrid()
        {
            // fill grid solutions
            gridSolutions.Rows.Clear();

            // border
            DevAge.Drawing.BorderLine border = new DevAge.Drawing.BorderLine(Color.DarkBlue, 1);
            DevAge.Drawing.RectangleBorder cellBorder = new DevAge.Drawing.RectangleBorder(border, border);

            // views
            CellBackColorAlternate viewNormal = new CellBackColorAlternate(Color.LightBlue, Color.White);
            viewNormal.Border = cellBorder;

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

            gridSolutions.ColumnsCount = 5;
            gridSolutions.FixedRows = 1;
            gridSolutions.Rows.Insert(0);

            // header
            SourceGrid.Cells.ColumnHeader columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(Resources.ID_INDEX);
            columnHeader.AutomaticSortEnabled = false;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 0] = columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(Resources.ID_LAYERPATTERN);
            columnHeader.AutomaticSortEnabled = false;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 1] = columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(Resources.ID_BUNDLECOUNT);
            columnHeader.AutomaticSortEnabled = false;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 2] = columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(Resources.ID_VOLUMEEFFICIENCY);
            columnHeader.AutomaticSortEnabled = false;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 3] = columnHeader;

            columnHeader = new SourceGrid.Cells.ColumnHeader(Resources.ID_PALLETWEIGHT);
            columnHeader.AutomaticSortEnabled = false;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 4] = columnHeader;

            // data rows
            int iIndex = 0;
            foreach (CasePalletSolution sol in _analysis.Solutions)
            {
                // build case count string
                string sBoxCount = string.Empty;
                sBoxCount = string.Format("{0}\n({1} * {2})", sol.CaseCount, sol.CasePerLayerCount, sol.Count);
                // insert row
                gridSolutions.Rows.Insert(++iIndex);
                // filling columns
                gridSolutions[iIndex, 0] = new SourceGrid.Cells.Cell(string.Format("{0}", iIndex));
                {
                    Graphics2DImage graphics = new Graphics2DImage(new Size(80, 40));
                    CasePalletSolutionViewer sv = new CasePalletSolutionViewer(sol);
                    sv.Draw(graphics);
                    gridSolutions[iIndex, 1] = new SourceGrid.Cells.Image(graphics.Bitmap);
                }
                gridSolutions[iIndex, 2] = new SourceGrid.Cells.Cell(sBoxCount);
                gridSolutions[iIndex, 3] = new SourceGrid.Cells.Cell(string.Format("{0:F}", sol.VolumeEfficiencyCases));
                gridSolutions[iIndex, 4] = new SourceGrid.Cells.Cell(string.Format("{0:F}", sol.PalletWeight));

                gridSolutions[iIndex, 0].View = viewNormal;
                gridSolutions[iIndex, 1].View = viewNormal;
                gridSolutions[iIndex, 2].View = viewNormal;
                gridSolutions[iIndex, 3].View = viewNormal;
                gridSolutions[iIndex, 4].View = viewNormal;
            }

            gridSolutions.AutoStretchColumnsToFitWidth = true;
            gridSolutions.AutoSizeCells();
            gridSolutions.Columns.StretchToFit();

            // select first solution
            gridSolutions.Selection.SelectRow(1, true);
            // redraw
            graphCtrlSolution.Invalidate();        
        }
        private int CurrentSolutionIndex
        {
            get
            {
                SourceGrid.RangeRegion region = gridSolutions.Selection.GetSelectionRegion();
                int[] indexes = region.GetRowsIndex();
                // no selection -> exit
                if (indexes.Length == 0) return -1;
                // return index
                return indexes[0] - 1; 
            }
        }

        #endregion

        #region Helpers
        private CasePalletSolution CurrentSolution
        {
            get
            {
                int iIndexSol = CurrentSolutionIndex;
                if (-1 == iIndexSol) return null;
                else return _analysis.Solutions[iIndexSol]; 
            }
        }
        private PalletProperties CurrentPallet
        {
            get
            {
                if (-1 == cbPallet.SelectedIndex)
                    return null;
                PalletItem item = cbPallet.Items[cbPallet.SelectedIndex] as PalletItem;
                return item.Item;
            }
        }

        private void LoadPallets()
        {
            string palletName = Properties.Settings.Default.PalletName;
            int selectedIndex = -1;

            int i = 0;
            foreach (PalletProperties pallet in _pallets)
            {
                cbPallet.Items.Add(new PalletItem(pallet));
                if (palletName == pallet.Name)
                    selectedIndex = i;
                ++i;
            }
            cbPallet.SelectedIndex = selectedIndex;
        }
        #endregion

        #region Public properties
        public List<PalletProperties> Pallets
        {
            get { return _pallets; }
            set { _pallets = value; }
        }
        public string BundleName
        {
            get { return _name; }
            set { _name = value; }
        }
        public double FlatLength
        {
            get { return (double)nudFlatLength.Value; }
            set { nudFlatLength.Value = (decimal)value; }
        }
        public double FlatWidth
        {
            get { return (double)nudFlatWidth.Value; }
            set { nudFlatWidth.Value = (decimal)value; }
        }
        public double FlatThickness
        {
            get { return (double)nudFlatThickness.Value; }
            set { nudFlatThickness.Value = (decimal)value; }
        }
        public double FlatWeight
        {
            get { return (double)nudFlatWeight.Value; }
            set { nudFlatWeight.Value = (decimal)value; }
        }
        public int NoFlats
        {
            get { return (int)nudNumberOfFlats.Value; }
            set { nudNumberOfFlats.Value = (decimal)value; }
        }
        public double MaximumPalletHeight
        {
            get { return (double)nudMaxPalletHeight.Value; }
            set { nudMaxPalletHeight.Value = (decimal)value; }
            
        }
        #endregion

        #region Event handlers
        private void onGridSolutionSelectionChanged(object sender, SourceGrid.RangeRegionChangedEventArgs e)
        {
            SourceGrid.RangeRegion region = gridSolutions.Selection.GetSelectionRegion();
            int[] indexes = region.GetRowsIndex();
            // no selection -> exit
            if (indexes.Length == 0) return;
            // redraw
            graphCtrlSolution.Invalidate();
        }

        private void DimensionsChanged(object sender, EventArgs e)
        {
            gridSolutions.Rows.Clear();
            graphCtrlSolution.Invalidate();
            // restart timer
            timerRefresh.Stop();
            timerRefresh.Start();
        }
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            // stop timer
            timerRefresh.Stop();
            // compute analysis
            Compute();
        }
        private void cbPallet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set description
            lbPalletDescription.Text = CurrentPallet.Description;
            // update pallet image
            graphCtrlPallet.Invalidate();
            // force recompute
            DimensionsChanged(cbPallet, null);
        }
        #endregion

        #region Report / StackBuilder project
        private void ToolsGenerateReport(object sender, EventArgs e)
        {
            try
            {
                FormDefineReport formReport = new FormDefineReport();
                formReport.ProjectName = _analysis.Name;
                if (DialogResult.OK != formReport.ShowDialog())
                    return;
                // selected solution
                SelCasePalletSolution selSolution = new SelCasePalletSolution(null, _analysis, CurrentSolution);
                ReportData reportData = new ReportData(_analysis, selSolution);

                Reporter.CompanyLogo = string.Empty;
                Reporter.ImageSizeSetting = Reporter.eImageSize.IMAGESIZE_DEFAULT;
                Reporter reporter;
                if (formReport.FileExtension == "doc")
                {
                    // create "MS Word" report file
                    reporter = new ReporterMSWord(
                        reportData
                        , Settings.Default.ReportTemplatePath
                        , formReport.FilePath
                        , new Margins());
                }
                else if (formReport.FileExtension == "html")
                {
                    // create "html" report file
                    reporter = new ReporterHtml(
                        reportData
                        , Settings.Default.ReportTemplatePath
                        , formReport.FilePath);
                }
                else
                    return;

                // open file
                if (formReport.OpenGeneratedFile)
                    Process.Start(new ProcessStartInfo(formReport.FilePath));
            }
            catch (Exception ex)
            { _log.Error(ex.ToString()); }
        }
        private void ToolsGenerateStackBuilderProject(object sender, EventArgs e)
        {
            try
            {
                // create new selected solution
                _analysis.SelectSolutionByIndex(CurrentSolutionIndex);
                // show "save as" dialog 
                if (DialogResult.OK == saveFileDialogAsStb.ShowDialog())
                {
                    // save as stb document
                    _document.Write(saveFileDialogAsStb.FileName);
                    // open file
                    Process.Start(new ProcessStartInfo(saveFileDialogAsStb.FileName));
                }
            }
            catch (Exception ex)
            { _log.Error(ex.ToString()); }
        }
        #endregion


    }
}
