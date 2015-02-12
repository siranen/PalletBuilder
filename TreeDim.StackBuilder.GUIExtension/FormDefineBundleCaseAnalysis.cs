#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using TreeDim.StackBuilder.GUIExtension.Properties;

using TreeDim.StackBuilder.Basics;
using TreeDim.StackBuilder.Graphics;
using TreeDim.StackBuilder.Engine;
using TreeDim.StackBuilder.Reporting;

using log4net;
#endregion

namespace TreeDim.StackBuilder.GUIExtension
{
    public partial class FormDefineBundleCaseAnalysis : Form, IDrawingContainer
    {
        #region Data members
        private string _name;
        private static readonly ILog _log = LogManager.GetLogger(typeof(FormDefineBundleCaseAnalysis));
        private BoxCaseAnalysis _analysis = null;
        private Document _doc = null;
        #endregion

        #region Constructor
        public FormDefineBundleCaseAnalysis()
        {
            InitializeComponent();
        }
        #endregion

        #region Form override
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FlatWeight = Settings.Default.BoxFlatWeight;
            NoFlats = Settings.Default.NoFlatsInBundle;
            
            CaseInsideLength = Settings.Default.CaseLength;
            CaseInsideWidth = Settings.Default.CaseWidth;
            CaseInsideHeight = Settings.Default.CaseHeight;
            CaseWeight = Settings.Default.CaseWeight;

            graphCtrlSolution.DrawingContainer = this;

            Compute();
            gridSolutions.Selection.SelectionChanged += onGridSolutionSelectionChanged;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Settings.Default.BoxFlatWeight = FlatWeight;
            Settings.Default.NoFlatsInBundle = NoFlats;

            Settings.Default.CaseLength = CaseInsideLength;
            Settings.Default.CaseWidth = CaseInsideWidth;
            Settings.Default.CaseHeight = CaseInsideHeight;
            Settings.Default.CaseWeight = CaseWeight;
        }
        #endregion

        #region Public properties
        public string BundleName
        {
            get { return _name; }
            set { _name = value; }
        }
        public double BundleLength
        {
            get { return (double)nudFlatLength.Value; }
            set { nudFlatLength.Value = (decimal)value; }
        }
        public double BundleWidth
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
        public double CaseInsideLength
        {
            get { return (double)nudCaseLength.Value; }
            set { nudCaseLength.Value = (decimal)value; }
        }
        public double CaseInsideWidth
        {
            get { return (double)nudCaseWidth.Value; }
            set { nudCaseWidth.Value = (decimal)value; }
        }
        public double CaseInsideHeight
        {
            get { return (double)nudCaseHeight.Value; }
            set { nudCaseHeight.Value = (decimal)value; }
        }
        public double CaseWeight
        {
            get { return (double)nudCaseWeight.Value; }
            set { nudCaseWeight.Value = (decimal)value; }
        }
        #endregion

        #region IDrawingContainer implementation
        public void Draw(Graphics3DControl ctrl, Graphics3D graphics)
        {
            if (null == CurrentSolution) return;
            BoxCaseSolutionViewer sv = new BoxCaseSolutionViewer(CurrentSolution);
            sv.Draw(graphics);
        }
        #endregion

        #region Grid
        protected void Compute()
        {
            try
            {
                const double thickness = 4.0;
                _doc = new Document(_name, "", "", DateTime.Now, null);
                // colors
                Color[] colors = new Color[6];
                for (int i = 0; i < 6; ++i) colors[i] = Color.Chocolate;
                // bundle
                BundleProperties bundleProperties = _doc.CreateNewBundle(_name, _name, BundleLength, BundleWidth, FlatThickness, FlatWeight, Color.Beige, NoFlats);
                // case
                BoxProperties caseProperties = _doc.CreateNewCase(_name, _name
                    , CaseInsideLength + 2.0 * thickness, CaseInsideWidth + 2.0 * thickness, CaseInsideHeight + 2.0 * thickness
                    , CaseInsideLength, CaseInsideWidth, CaseInsideHeight
                    , CaseWeight, colors);
                // constraint set
                BundleCaseConstraintSet constraintSet = new BundleCaseConstraintSet();
                // maximum case weight
                constraintSet.UseMaximumCaseWeight = false;
                constraintSet.MaximumCaseWeight = 0.0;
                // maximum number of items
                constraintSet.UseMaximumNumberOfBoxes = false;
                constraintSet.MaximumNumberOfBoxes = 0;

                _analysis = _doc.CreateNewBoxCaseAnalysis(
                    _name, _name
                    , bundleProperties, caseProperties
                    , constraintSet
                    , new BoxCaseSolver());
                // fill grid
                FillGrid();
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
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

            columnHeader = new SourceGrid.Cells.ColumnHeader(Resources.ID_CASEWEIGHT);
            columnHeader.AutomaticSortEnabled = false;
            columnHeader.View = viewColumnHeader;
            gridSolutions[0, 4] = columnHeader;

            // data rows
            int iIndex = 0;
            foreach (BoxCaseSolution sol in _analysis.Solutions)
            {
                // build case count string
                string sBoxCount = string.Empty;
                sBoxCount = string.Format("{0}\n({1} * {2})", sol.BoxPerCaseCount, sol.BoxPerLayerCount, sol.Count);
                // insert row
                gridSolutions.Rows.Insert(++iIndex);
                // filling columns
                gridSolutions[iIndex, 0] = new SourceGrid.Cells.Cell(string.Format("{0}", iIndex));
                {
                    Graphics2DImage graphics = new Graphics2DImage(new Size(80, 40));
                    BoxCaseSolutionViewer sv = new BoxCaseSolutionViewer(sol);
                    sv.Draw(graphics);
                    gridSolutions[iIndex, 1] = new SourceGrid.Cells.Image(graphics.Bitmap);
                }
                gridSolutions[iIndex, 2] = new SourceGrid.Cells.Cell(sBoxCount);
                gridSolutions[iIndex, 3] = new SourceGrid.Cells.Cell(string.Format("{0:F}", sol.VolumeEfficiencyBoxes));
                gridSolutions[iIndex, 4] = new SourceGrid.Cells.Cell(string.Format("{0:F}", sol.CaseWeight));

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
        #endregion

        #region Helpers
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
        private BoxCaseSolution CurrentSolution
        {
            get
            {
                int iIndexSol = CurrentSolutionIndex;
                if (-1 == iIndexSol) return null;
                else return _analysis.Solutions[iIndexSol];
            }
        }
        #endregion

        #region Event handlers
        /// <summary>
        /// SourceGrid row selection change handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onGridSolutionSelectionChanged(object sender, SourceGrid.RangeRegionChangedEventArgs e)
        {
            SourceGrid.RangeRegion region = gridSolutions.Selection.GetSelectionRegion();
            int[] indexes = region.GetRowsIndex();
            // no selection -> exit
            if (indexes.Length == 0) return;
            // redraw
            graphCtrlSolution.Invalidate();
        }
        private void DimensionChanged(object sender, EventArgs e)
        {
            gridSolutions.Rows.Clear();
            // restart timer
            timerRefresh.Stop();
            timerRefresh.Start();
        }
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            timerRefresh.Stop();
            // compute analysis
            Compute();
        }
        private void bnRefresh_Click(object sender, EventArgs e)
        {
            Compute();
        }
        private void ToolsGenerateReport(object sender, EventArgs e)
        {
            try
            {
                FormDefineReport formReport = new FormDefineReport();
                formReport.ProjectName = _analysis.Name;
                if (DialogResult.OK != formReport.ShowDialog())
                    return;
                // selected solution
                SelBoxCaseSolution selSolution = new SelBoxCaseSolution(_doc, _analysis, CurrentSolution);
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
            {
                _log.Error(ex.ToString());
            }
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
                    _doc.Write(saveFileDialogAsStb.FileName);
                    // open file
                    Process.Start(new ProcessStartInfo(saveFileDialogAsStb.FileName));
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }
        }
        #endregion
    }
}
