namespace TreeDim.StackBuilder.GUIExtension
{
    partial class FormDefineBundlePalletAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDefineBundlePalletAnalysis));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gridSolutions = new SourceGrid.Grid();
            this.graphCtrlSolution = new TreeDim.StackBuilder.Graphics.Graphics3DControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStackBuilder = new System.Windows.Forms.ToolStripButton();
            this.gbFlatDim = new System.Windows.Forms.GroupBox();
            this.nudFlatWeight = new System.Windows.Forms.NumericUpDown();
            this.lbWeight = new System.Windows.Forms.Label();
            this.nudNumberOfFlats = new System.Windows.Forms.NumericUpDown();
            this.lbNumberOfFlats = new System.Windows.Forms.Label();
            this.nudFlatThickness = new System.Windows.Forms.NumericUpDown();
            this.nudFlatWidth = new System.Windows.Forms.NumericUpDown();
            this.nudFlatLength = new System.Windows.Forms.NumericUpDown();
            this.lbThickness = new System.Windows.Forms.Label();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.bnClose = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.gbPallet = new System.Windows.Forms.GroupBox();
            this.nudMaxPalletHeight = new System.Windows.Forms.NumericUpDown();
            this.lbMaximumPalletHeight = new System.Windows.Forms.Label();
            this.lbPalletDescription = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.cbPallet = new System.Windows.Forms.ComboBox();
            this.graphCtrlPallet = new TreeDim.StackBuilder.Graphics.Graphics3DControl();
            this.label1 = new System.Windows.Forms.Label();
            this.bnRefresh = new System.Windows.Forms.Button();
            this.saveFileDialogAsStb = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlSolution)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.gbFlatDim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfFlats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatLength)).BeginInit();
            this.gbPallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPalletHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlPallet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            resources.ApplyResources(this.splitContainer.Panel1, "splitContainer.Panel1");
            this.splitContainer.Panel1.Controls.Add(this.gridSolutions);
            // 
            // splitContainer.Panel2
            // 
            resources.ApplyResources(this.splitContainer.Panel2, "splitContainer.Panel2");
            this.splitContainer.Panel2.Controls.Add(this.graphCtrlSolution);
            // 
            // gridSolutions
            // 
            this.gridSolutions.AcceptsInputChar = false;
            resources.ApplyResources(this.gridSolutions, "gridSolutions");
            this.gridSolutions.EnableSort = false;
            this.gridSolutions.Name = "gridSolutions";
            this.gridSolutions.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridSolutions.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridSolutions.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridSolutions.TabStop = true;
            this.gridSolutions.ToolTipText = "";
            // 
            // graphCtrlSolution
            // 
            resources.ApplyResources(this.graphCtrlSolution, "graphCtrlSolution");
            this.graphCtrlSolution.Name = "graphCtrlSolution";
            this.graphCtrlSolution.TabStop = false;
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // toolStrip
            // 
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReport,
            this.toolStripButtonStackBuilder});
            this.toolStrip.Name = "toolStrip";
            // 
            // toolStripButtonReport
            // 
            resources.ApplyResources(this.toolStripButtonReport, "toolStripButtonReport");
            this.toolStripButtonReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReport.Name = "toolStripButtonReport";
            this.toolStripButtonReport.Click += new System.EventHandler(this.ToolsGenerateReport);
            // 
            // toolStripButtonStackBuilder
            // 
            resources.ApplyResources(this.toolStripButtonStackBuilder, "toolStripButtonStackBuilder");
            this.toolStripButtonStackBuilder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStackBuilder.Name = "toolStripButtonStackBuilder";
            this.toolStripButtonStackBuilder.Click += new System.EventHandler(this.ToolsGenerateStackBuilderProject);
            // 
            // gbFlatDim
            // 
            resources.ApplyResources(this.gbFlatDim, "gbFlatDim");
            this.gbFlatDim.Controls.Add(this.nudFlatWeight);
            this.gbFlatDim.Controls.Add(this.lbWeight);
            this.gbFlatDim.Controls.Add(this.nudNumberOfFlats);
            this.gbFlatDim.Controls.Add(this.lbNumberOfFlats);
            this.gbFlatDim.Controls.Add(this.nudFlatThickness);
            this.gbFlatDim.Controls.Add(this.nudFlatWidth);
            this.gbFlatDim.Controls.Add(this.nudFlatLength);
            this.gbFlatDim.Controls.Add(this.lbThickness);
            this.gbFlatDim.Controls.Add(this.lbWidth);
            this.gbFlatDim.Controls.Add(this.lbLength);
            this.gbFlatDim.Name = "gbFlatDim";
            this.gbFlatDim.TabStop = false;
            // 
            // nudFlatWeight
            // 
            resources.ApplyResources(this.nudFlatWeight, "nudFlatWeight");
            this.nudFlatWeight.DecimalPlaces = 2;
            this.nudFlatWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFlatWeight.Name = "nudFlatWeight";
            this.nudFlatWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatWeight.ValueChanged += new System.EventHandler(this.DimensionsChanged);
            // 
            // lbWeight
            // 
            resources.ApplyResources(this.lbWeight, "lbWeight");
            this.lbWeight.Name = "lbWeight";
            // 
            // nudNumberOfFlats
            // 
            resources.ApplyResources(this.nudNumberOfFlats, "nudNumberOfFlats");
            this.nudNumberOfFlats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfFlats.Name = "nudNumberOfFlats";
            this.nudNumberOfFlats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfFlats.ValueChanged += new System.EventHandler(this.DimensionsChanged);
            // 
            // lbNumberOfFlats
            // 
            resources.ApplyResources(this.lbNumberOfFlats, "lbNumberOfFlats");
            this.lbNumberOfFlats.Name = "lbNumberOfFlats";
            // 
            // nudFlatThickness
            // 
            resources.ApplyResources(this.nudFlatThickness, "nudFlatThickness");
            this.nudFlatThickness.DecimalPlaces = 2;
            this.nudFlatThickness.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFlatThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatThickness.Name = "nudFlatThickness";
            this.nudFlatThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatThickness.ValueChanged += new System.EventHandler(this.DimensionsChanged);
            // 
            // nudFlatWidth
            // 
            resources.ApplyResources(this.nudFlatWidth, "nudFlatWidth");
            this.nudFlatWidth.DecimalPlaces = 2;
            this.nudFlatWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFlatWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatWidth.Name = "nudFlatWidth";
            this.nudFlatWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatWidth.ValueChanged += new System.EventHandler(this.DimensionsChanged);
            // 
            // nudFlatLength
            // 
            resources.ApplyResources(this.nudFlatLength, "nudFlatLength");
            this.nudFlatLength.DecimalPlaces = 2;
            this.nudFlatLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFlatLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatLength.Name = "nudFlatLength";
            this.nudFlatLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatLength.ValueChanged += new System.EventHandler(this.DimensionsChanged);
            // 
            // lbThickness
            // 
            resources.ApplyResources(this.lbThickness, "lbThickness");
            this.lbThickness.Name = "lbThickness";
            // 
            // lbWidth
            // 
            resources.ApplyResources(this.lbWidth, "lbWidth");
            this.lbWidth.Name = "lbWidth";
            // 
            // lbLength
            // 
            resources.ApplyResources(this.lbLength, "lbLength");
            this.lbLength.Name = "lbLength";
            // 
            // bnClose
            // 
            resources.ApplyResources(this.bnClose, "bnClose");
            this.bnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnClose.Name = "bnClose";
            this.bnClose.UseVisualStyleBackColor = true;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // gbPallet
            // 
            resources.ApplyResources(this.gbPallet, "gbPallet");
            this.gbPallet.Controls.Add(this.nudMaxPalletHeight);
            this.gbPallet.Controls.Add(this.lbMaximumPalletHeight);
            this.gbPallet.Controls.Add(this.lbPalletDescription);
            this.gbPallet.Controls.Add(this.lbDescription);
            this.gbPallet.Controls.Add(this.cbPallet);
            this.gbPallet.Controls.Add(this.graphCtrlPallet);
            this.gbPallet.Controls.Add(this.label1);
            this.gbPallet.Name = "gbPallet";
            this.gbPallet.TabStop = false;
            // 
            // nudMaxPalletHeight
            // 
            resources.ApplyResources(this.nudMaxPalletHeight, "nudMaxPalletHeight");
            this.nudMaxPalletHeight.DecimalPlaces = 2;
            this.nudMaxPalletHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxPalletHeight.Name = "nudMaxPalletHeight";
            // 
            // lbMaximumPalletHeight
            // 
            resources.ApplyResources(this.lbMaximumPalletHeight, "lbMaximumPalletHeight");
            this.lbMaximumPalletHeight.Name = "lbMaximumPalletHeight";
            // 
            // lbPalletDescription
            // 
            resources.ApplyResources(this.lbPalletDescription, "lbPalletDescription");
            this.lbPalletDescription.Name = "lbPalletDescription";
            // 
            // lbDescription
            // 
            resources.ApplyResources(this.lbDescription, "lbDescription");
            this.lbDescription.Name = "lbDescription";
            // 
            // cbPallet
            // 
            resources.ApplyResources(this.cbPallet, "cbPallet");
            this.cbPallet.AllowDrop = true;
            this.cbPallet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPallet.FormattingEnabled = true;
            this.cbPallet.Name = "cbPallet";
            this.cbPallet.SelectedIndexChanged += new System.EventHandler(this.cbPallet_SelectedIndexChanged);
            // 
            // graphCtrlPallet
            // 
            resources.ApplyResources(this.graphCtrlPallet, "graphCtrlPallet");
            this.graphCtrlPallet.Name = "graphCtrlPallet";
            this.graphCtrlPallet.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // bnRefresh
            // 
            resources.ApplyResources(this.bnRefresh, "bnRefresh");
            this.bnRefresh.Name = "bnRefresh";
            this.bnRefresh.UseVisualStyleBackColor = true;
            // 
            // saveFileDialogAsStb
            // 
            this.saveFileDialogAsStb.DefaultExt = "stb";
            resources.ApplyResources(this.saveFileDialogAsStb, "saveFileDialogAsStb");
            // 
            // FormDefineBundlePalletAnalysis
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnClose;
            this.Controls.Add(this.bnRefresh);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.gbPallet);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.gbFlatDim);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDefineBundlePalletAnalysis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlSolution)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.gbFlatDim.ResumeLayout(false);
            this.gbFlatDim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfFlats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatLength)).EndInit();
            this.gbPallet.ResumeLayout(false);
            this.gbPallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPalletHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlPallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonReport;
        private System.Windows.Forms.ToolStripButton toolStripButtonStackBuilder;
        private System.Windows.Forms.GroupBox gbFlatDim;
        private System.Windows.Forms.NumericUpDown nudFlatWeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.NumericUpDown nudNumberOfFlats;
        private System.Windows.Forms.Label lbNumberOfFlats;
        private System.Windows.Forms.NumericUpDown nudFlatThickness;
        private System.Windows.Forms.NumericUpDown nudFlatWidth;
        private System.Windows.Forms.NumericUpDown nudFlatLength;
        private System.Windows.Forms.Label lbThickness;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.GroupBox gbPallet;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button bnRefresh;
        private System.Windows.Forms.Label label1;
        private SourceGrid.Grid gridSolutions;
        private TreeDim.StackBuilder.Graphics.Graphics3DControl graphCtrlSolution;
        private TreeDim.StackBuilder.Graphics.Graphics3DControl graphCtrlPallet;
        private System.Windows.Forms.ComboBox cbPallet;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbPalletDescription;
        private System.Windows.Forms.Label lbMaximumPalletHeight;
        private System.Windows.Forms.NumericUpDown nudMaxPalletHeight;
        private System.Windows.Forms.SaveFileDialog saveFileDialogAsStb;
    }
}