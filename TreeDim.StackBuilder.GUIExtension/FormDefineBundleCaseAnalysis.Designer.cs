namespace TreeDim.StackBuilder.GUIExtension
{
    partial class FormDefineBundleCaseAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDefineBundleCaseAnalysis));
            this.splitContainerHoriz = new System.Windows.Forms.SplitContainer();
            this.gridSolutions = new SourceGrid.Grid();
            this.graphCtrlSolution = new TreeDim.StackBuilder.Graphics.Graphics3DControl();
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
            this.gbCaseDim = new System.Windows.Forms.GroupBox();
            this.nudCaseWeight = new System.Windows.Forms.NumericUpDown();
            this.lbCaseWeight = new System.Windows.Forms.Label();
            this.nudCaseHeight = new System.Windows.Forms.NumericUpDown();
            this.nudCaseWidth = new System.Windows.Forms.NumericUpDown();
            this.nudCaseLength = new System.Windows.Forms.NumericUpDown();
            this.lbCaseHeight = new System.Windows.Forms.Label();
            this.lbCaseWidth = new System.Windows.Forms.Label();
            this.lbCaseLength = new System.Windows.Forms.Label();
            this.toolStripTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStackBuilder = new System.Windows.Forms.ToolStripButton();
            this.bnClose = new System.Windows.Forms.Button();
            this.bnRefreh = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogAsStb = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHoriz)).BeginInit();
            this.splitContainerHoriz.Panel1.SuspendLayout();
            this.splitContainerHoriz.Panel2.SuspendLayout();
            this.splitContainerHoriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlSolution)).BeginInit();
            this.gbFlatDim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfFlats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatLength)).BeginInit();
            this.gbCaseDim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaseWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaseHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaseWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaseLength)).BeginInit();
            this.toolStripTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerHoriz
            // 
            resources.ApplyResources(this.splitContainerHoriz, "splitContainerHoriz");
            this.splitContainerHoriz.Name = "splitContainerHoriz";
            // 
            // splitContainerHoriz.Panel1
            // 
            resources.ApplyResources(this.splitContainerHoriz.Panel1, "splitContainerHoriz.Panel1");
            this.splitContainerHoriz.Panel1.Controls.Add(this.gridSolutions);
            // 
            // splitContainerHoriz.Panel2
            // 
            resources.ApplyResources(this.splitContainerHoriz.Panel2, "splitContainerHoriz.Panel2");
            this.splitContainerHoriz.Panel2.Controls.Add(this.graphCtrlSolution);
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
            this.nudFlatWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatWeight.Name = "nudFlatWeight";
            this.nudFlatWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatWeight.ValueChanged += new System.EventHandler(this.DimensionChanged);
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
            this.nudNumberOfFlats.ValueChanged += new System.EventHandler(this.DimensionChanged);
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
            this.nudFlatThickness.ValueChanged += new System.EventHandler(this.DimensionChanged);
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
            this.nudFlatWidth.ValueChanged += new System.EventHandler(this.DimensionChanged);
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
            this.nudFlatLength.ValueChanged += new System.EventHandler(this.DimensionChanged);
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
            // gbCaseDim
            // 
            resources.ApplyResources(this.gbCaseDim, "gbCaseDim");
            this.gbCaseDim.Controls.Add(this.nudCaseWeight);
            this.gbCaseDim.Controls.Add(this.lbCaseWeight);
            this.gbCaseDim.Controls.Add(this.nudCaseHeight);
            this.gbCaseDim.Controls.Add(this.nudCaseWidth);
            this.gbCaseDim.Controls.Add(this.nudCaseLength);
            this.gbCaseDim.Controls.Add(this.lbCaseHeight);
            this.gbCaseDim.Controls.Add(this.lbCaseWidth);
            this.gbCaseDim.Controls.Add(this.lbCaseLength);
            this.gbCaseDim.Name = "gbCaseDim";
            this.gbCaseDim.TabStop = false;
            // 
            // nudCaseWeight
            // 
            resources.ApplyResources(this.nudCaseWeight, "nudCaseWeight");
            this.nudCaseWeight.DecimalPlaces = 2;
            this.nudCaseWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCaseWeight.Name = "nudCaseWeight";
            this.nudCaseWeight.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // lbCaseWeight
            // 
            resources.ApplyResources(this.lbCaseWeight, "lbCaseWeight");
            this.lbCaseWeight.Name = "lbCaseWeight";
            // 
            // nudCaseHeight
            // 
            resources.ApplyResources(this.nudCaseHeight, "nudCaseHeight");
            this.nudCaseHeight.DecimalPlaces = 2;
            this.nudCaseHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCaseHeight.Name = "nudCaseHeight";
            this.nudCaseHeight.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // nudCaseWidth
            // 
            resources.ApplyResources(this.nudCaseWidth, "nudCaseWidth");
            this.nudCaseWidth.DecimalPlaces = 2;
            this.nudCaseWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCaseWidth.Name = "nudCaseWidth";
            this.nudCaseWidth.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // nudCaseLength
            // 
            resources.ApplyResources(this.nudCaseLength, "nudCaseLength");
            this.nudCaseLength.DecimalPlaces = 2;
            this.nudCaseLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCaseLength.Name = "nudCaseLength";
            this.nudCaseLength.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // lbCaseHeight
            // 
            resources.ApplyResources(this.lbCaseHeight, "lbCaseHeight");
            this.lbCaseHeight.Name = "lbCaseHeight";
            // 
            // lbCaseWidth
            // 
            resources.ApplyResources(this.lbCaseWidth, "lbCaseWidth");
            this.lbCaseWidth.Name = "lbCaseWidth";
            // 
            // lbCaseLength
            // 
            resources.ApplyResources(this.lbCaseLength, "lbCaseLength");
            this.lbCaseLength.Name = "lbCaseLength";
            // 
            // toolStripTools
            // 
            resources.ApplyResources(this.toolStripTools, "toolStripTools");
            this.toolStripTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReport,
            this.toolStripButtonStackBuilder});
            this.toolStripTools.Name = "toolStripTools";
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
            // bnClose
            // 
            resources.ApplyResources(this.bnClose, "bnClose");
            this.bnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnClose.Name = "bnClose";
            this.bnClose.UseVisualStyleBackColor = true;
            // 
            // bnRefreh
            // 
            resources.ApplyResources(this.bnRefreh, "bnRefreh");
            this.bnRefreh.Name = "bnRefreh";
            this.bnRefreh.UseVisualStyleBackColor = true;
            this.bnRefreh.Click += new System.EventHandler(this.bnRefresh_Click);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // saveFileDialogAsStb
            // 
            this.saveFileDialogAsStb.DefaultExt = "stb";
            resources.ApplyResources(this.saveFileDialogAsStb, "saveFileDialogAsStb");
            // 
            // FormDefineBundleCaseAnalysis
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnClose;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.bnRefreh);
            this.Controls.Add(this.splitContainerHoriz);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.toolStripTools);
            this.Controls.Add(this.gbCaseDim);
            this.Controls.Add(this.gbFlatDim);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDefineBundleCaseAnalysis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.splitContainerHoriz.Panel1.ResumeLayout(false);
            this.splitContainerHoriz.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHoriz)).EndInit();
            this.splitContainerHoriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlSolution)).EndInit();
            this.gbFlatDim.ResumeLayout(false);
            this.gbFlatDim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfFlats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlatLength)).EndInit();
            this.gbCaseDim.ResumeLayout(false);
            this.gbCaseDim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaseWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaseHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaseWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaseLength)).EndInit();
            this.toolStripTools.ResumeLayout(false);
            this.toolStripTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerHoriz;
        private TreeDim.StackBuilder.Graphics.Graphics3DControl graphCtrlSolution;
        private SourceGrid.Grid gridSolutions;
        private System.Windows.Forms.GroupBox gbFlatDim;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.NumericUpDown nudFlatThickness;
        private System.Windows.Forms.NumericUpDown nudFlatWidth;
        private System.Windows.Forms.NumericUpDown nudFlatLength;
        private System.Windows.Forms.Label lbThickness;
        private System.Windows.Forms.NumericUpDown nudNumberOfFlats;
        private System.Windows.Forms.Label lbNumberOfFlats;
        private System.Windows.Forms.GroupBox gbCaseDim;
        private System.Windows.Forms.NumericUpDown nudCaseHeight;
        private System.Windows.Forms.NumericUpDown nudCaseWidth;
        private System.Windows.Forms.NumericUpDown nudCaseLength;
        private System.Windows.Forms.Label lbCaseHeight;
        private System.Windows.Forms.Label lbCaseWidth;
        private System.Windows.Forms.Label lbCaseLength;
        private System.Windows.Forms.NumericUpDown nudFlatWeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.ToolStrip toolStripTools;
        private System.Windows.Forms.ToolStripButton toolStripButtonReport;
        private System.Windows.Forms.ToolStripButton toolStripButtonStackBuilder;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.NumericUpDown nudCaseWeight;
        private System.Windows.Forms.Label lbCaseWeight;
        private System.Windows.Forms.Button bnRefreh;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.SaveFileDialog saveFileDialogAsStb;
    }
}