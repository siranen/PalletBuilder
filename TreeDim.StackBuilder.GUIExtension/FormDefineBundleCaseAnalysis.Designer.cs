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
            this.splitContainerHoriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerHoriz.Location = new System.Drawing.Point(0, 194);
            this.splitContainerHoriz.Name = "splitContainerHoriz";
            this.splitContainerHoriz.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHoriz.Panel1
            // 
            this.splitContainerHoriz.Panel1.Controls.Add(this.gridSolutions);
            // 
            // splitContainerHoriz.Panel2
            // 
            this.splitContainerHoriz.Panel2.Controls.Add(this.graphCtrlSolution);
            this.splitContainerHoriz.Size = new System.Drawing.Size(624, 543);
            this.splitContainerHoriz.SplitterDistance = 154;
            this.splitContainerHoriz.TabIndex = 4;
            // 
            // gridSolutions
            // 
            this.gridSolutions.AcceptsInputChar = false;
            this.gridSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSolutions.EnableSort = false;
            this.gridSolutions.Location = new System.Drawing.Point(0, 0);
            this.gridSolutions.Name = "gridSolutions";
            this.gridSolutions.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridSolutions.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.gridSolutions.Size = new System.Drawing.Size(624, 154);
            this.gridSolutions.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridSolutions.TabIndex = 0;
            this.gridSolutions.TabStop = true;
            this.gridSolutions.ToolTipText = "";
            // 
            // graphCtrlSolution
            // 
            this.graphCtrlSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphCtrlSolution.Location = new System.Drawing.Point(0, 0);
            this.graphCtrlSolution.Name = "graphCtrlSolution";
            this.graphCtrlSolution.Size = new System.Drawing.Size(624, 385);
            this.graphCtrlSolution.TabIndex = 0;
            this.graphCtrlSolution.TabStop = false;
            // 
            // gbFlatDim
            // 
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
            this.gbFlatDim.Location = new System.Drawing.Point(4, 28);
            this.gbFlatDim.Name = "gbFlatDim";
            this.gbFlatDim.Size = new System.Drawing.Size(508, 68);
            this.gbFlatDim.TabIndex = 0;
            this.gbFlatDim.TabStop = false;
            this.gbFlatDim.Text = "Flat dimensions";
            // 
            // nudFlatWeight
            // 
            this.nudFlatWeight.DecimalPlaces = 2;
            this.nudFlatWeight.Location = new System.Drawing.Point(68, 42);
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
            this.nudFlatWeight.Size = new System.Drawing.Size(70, 20);
            this.nudFlatWeight.TabIndex = 9;
            this.nudFlatWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatWeight.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(7, 46);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(41, 13);
            this.lbWeight.TabIndex = 8;
            this.lbWeight.Text = "Weight";
            // 
            // nudNumberOfFlats
            // 
            this.nudNumberOfFlats.Location = new System.Drawing.Point(415, 43);
            this.nudNumberOfFlats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfFlats.Name = "nudNumberOfFlats";
            this.nudNumberOfFlats.Size = new System.Drawing.Size(69, 20);
            this.nudNumberOfFlats.TabIndex = 7;
            this.nudNumberOfFlats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfFlats.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // lbNumberOfFlats
            // 
            this.lbNumberOfFlats.AutoSize = true;
            this.lbNumberOfFlats.Location = new System.Drawing.Point(335, 47);
            this.lbNumberOfFlats.Name = "lbNumberOfFlats";
            this.lbNumberOfFlats.Size = new System.Drawing.Size(78, 13);
            this.lbNumberOfFlats.TabIndex = 6;
            this.lbNumberOfFlats.Text = "Number of flats";
            // 
            // nudFlatThickness
            // 
            this.nudFlatThickness.DecimalPlaces = 2;
            this.nudFlatThickness.Location = new System.Drawing.Point(415, 16);
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
            this.nudFlatThickness.Size = new System.Drawing.Size(70, 20);
            this.nudFlatThickness.TabIndex = 5;
            this.nudFlatThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatThickness.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // nudFlatWidth
            // 
            this.nudFlatWidth.DecimalPlaces = 2;
            this.nudFlatWidth.Location = new System.Drawing.Point(238, 16);
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
            this.nudFlatWidth.Size = new System.Drawing.Size(70, 20);
            this.nudFlatWidth.TabIndex = 4;
            this.nudFlatWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatWidth.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // nudFlatLength
            // 
            this.nudFlatLength.DecimalPlaces = 2;
            this.nudFlatLength.Location = new System.Drawing.Point(68, 16);
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
            this.nudFlatLength.Size = new System.Drawing.Size(70, 20);
            this.nudFlatLength.TabIndex = 3;
            this.nudFlatLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatLength.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // lbThickness
            // 
            this.lbThickness.AutoSize = true;
            this.lbThickness.Location = new System.Drawing.Point(335, 20);
            this.lbThickness.Name = "lbThickness";
            this.lbThickness.Size = new System.Drawing.Size(56, 13);
            this.lbThickness.TabIndex = 2;
            this.lbThickness.Text = "Thickness";
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(174, 20);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(35, 13);
            this.lbWidth.TabIndex = 1;
            this.lbWidth.Text = "Width";
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(7, 20);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(40, 13);
            this.lbLength.TabIndex = 0;
            this.lbLength.Text = "Length";
            // 
            // gbCaseDim
            // 
            this.gbCaseDim.Controls.Add(this.nudCaseWeight);
            this.gbCaseDim.Controls.Add(this.lbCaseWeight);
            this.gbCaseDim.Controls.Add(this.nudCaseHeight);
            this.gbCaseDim.Controls.Add(this.nudCaseWidth);
            this.gbCaseDim.Controls.Add(this.nudCaseLength);
            this.gbCaseDim.Controls.Add(this.lbCaseHeight);
            this.gbCaseDim.Controls.Add(this.lbCaseWidth);
            this.gbCaseDim.Controls.Add(this.lbCaseLength);
            this.gbCaseDim.Location = new System.Drawing.Point(4, 102);
            this.gbCaseDim.Name = "gbCaseDim";
            this.gbCaseDim.Size = new System.Drawing.Size(508, 74);
            this.gbCaseDim.TabIndex = 1;
            this.gbCaseDim.TabStop = false;
            this.gbCaseDim.Text = "Case inner dimensions";
            // 
            // nudCaseWeight
            // 
            this.nudCaseWeight.DecimalPlaces = 2;
            this.nudCaseWeight.Location = new System.Drawing.Point(68, 43);
            this.nudCaseWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCaseWeight.Name = "nudCaseWeight";
            this.nudCaseWeight.Size = new System.Drawing.Size(70, 20);
            this.nudCaseWeight.TabIndex = 7;
            this.nudCaseWeight.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // lbCaseWeight
            // 
            this.lbCaseWeight.AutoSize = true;
            this.lbCaseWeight.Location = new System.Drawing.Point(10, 46);
            this.lbCaseWeight.Name = "lbCaseWeight";
            this.lbCaseWeight.Size = new System.Drawing.Size(41, 13);
            this.lbCaseWeight.TabIndex = 6;
            this.lbCaseWeight.Text = "Weight";
            // 
            // nudCaseHeight
            // 
            this.nudCaseHeight.DecimalPlaces = 2;
            this.nudCaseHeight.Location = new System.Drawing.Point(415, 16);
            this.nudCaseHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCaseHeight.Name = "nudCaseHeight";
            this.nudCaseHeight.Size = new System.Drawing.Size(70, 20);
            this.nudCaseHeight.TabIndex = 5;
            this.nudCaseHeight.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // nudCaseWidth
            // 
            this.nudCaseWidth.DecimalPlaces = 2;
            this.nudCaseWidth.Location = new System.Drawing.Point(238, 16);
            this.nudCaseWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCaseWidth.Name = "nudCaseWidth";
            this.nudCaseWidth.Size = new System.Drawing.Size(70, 20);
            this.nudCaseWidth.TabIndex = 4;
            this.nudCaseWidth.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // nudCaseLength
            // 
            this.nudCaseLength.DecimalPlaces = 2;
            this.nudCaseLength.Location = new System.Drawing.Point(68, 16);
            this.nudCaseLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCaseLength.Name = "nudCaseLength";
            this.nudCaseLength.Size = new System.Drawing.Size(70, 20);
            this.nudCaseLength.TabIndex = 3;
            this.nudCaseLength.ValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // lbCaseHeight
            // 
            this.lbCaseHeight.AutoSize = true;
            this.lbCaseHeight.Location = new System.Drawing.Point(335, 20);
            this.lbCaseHeight.Name = "lbCaseHeight";
            this.lbCaseHeight.Size = new System.Drawing.Size(38, 13);
            this.lbCaseHeight.TabIndex = 2;
            this.lbCaseHeight.Text = "Height";
            // 
            // lbCaseWidth
            // 
            this.lbCaseWidth.AutoSize = true;
            this.lbCaseWidth.Location = new System.Drawing.Point(174, 20);
            this.lbCaseWidth.Name = "lbCaseWidth";
            this.lbCaseWidth.Size = new System.Drawing.Size(35, 13);
            this.lbCaseWidth.TabIndex = 1;
            this.lbCaseWidth.Text = "Width";
            // 
            // lbCaseLength
            // 
            this.lbCaseLength.AutoSize = true;
            this.lbCaseLength.Location = new System.Drawing.Point(10, 20);
            this.lbCaseLength.Name = "lbCaseLength";
            this.lbCaseLength.Size = new System.Drawing.Size(40, 13);
            this.lbCaseLength.TabIndex = 0;
            this.lbCaseLength.Text = "Length";
            // 
            // toolStripTools
            // 
            this.toolStripTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReport,
            this.toolStripButtonStackBuilder});
            this.toolStripTools.Location = new System.Drawing.Point(0, 0);
            this.toolStripTools.Name = "toolStripTools";
            this.toolStripTools.Size = new System.Drawing.Size(624, 25);
            this.toolStripTools.TabIndex = 2;
            this.toolStripTools.Text = "toolStripTools";
            // 
            // toolStripButtonReport
            // 
            this.toolStripButtonReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReport.Image")));
            this.toolStripButtonReport.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonReport.Name = "toolStripButtonReport";
            this.toolStripButtonReport.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReport.Text = "Generate report...";
            this.toolStripButtonReport.Click += new System.EventHandler(this.ToolsGenerateReport);
            // 
            // toolStripButtonStackBuilder
            // 
            this.toolStripButtonStackBuilder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStackBuilder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStackBuilder.Image")));
            this.toolStripButtonStackBuilder.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonStackBuilder.Name = "toolStripButtonStackBuilder";
            this.toolStripButtonStackBuilder.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStackBuilder.Text = "Generate StackBuilder project...";
            this.toolStripButtonStackBuilder.Click += new System.EventHandler(this.ToolsGenerateStackBuilderProject);
            // 
            // bnClose
            // 
            this.bnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnClose.Location = new System.Drawing.Point(537, 28);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(82, 23);
            this.bnClose.TabIndex = 3;
            this.bnClose.Text = "Close";
            this.bnClose.UseVisualStyleBackColor = true;
            // 
            // bnRefreh
            // 
            this.bnRefreh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnRefreh.Location = new System.Drawing.Point(537, 153);
            this.bnRefreh.Name = "bnRefreh";
            this.bnRefreh.Size = new System.Drawing.Size(82, 23);
            this.bnRefreh.TabIndex = 5;
            this.bnRefreh.Text = "Refresh";
            this.bnRefreh.UseVisualStyleBackColor = true;
            this.bnRefreh.Click += new System.EventHandler(this.bnRefresh_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 740);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // saveFileDialogAsStb
            // 
            this.saveFileDialogAsStb.DefaultExt = "stb";
            this.saveFileDialogAsStb.Filter = "StackBuilder (*.stb)|*.stb";
            this.saveFileDialogAsStb.Title = "Save as StackBuilder project...";
            // 
            // FormDefineBundleCaseAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnClose;
            this.ClientSize = new System.Drawing.Size(624, 762);
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
            this.Text = "Bundle / Case analysis...";
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