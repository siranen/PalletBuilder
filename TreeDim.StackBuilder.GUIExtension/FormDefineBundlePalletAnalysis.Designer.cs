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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gridSolutions = new SourceGrid.Grid();
            this.graphCtrlSolution = new TreeDim.StackBuilder.Graphics.Graphics3DControl();
            this.bnRefresh = new System.Windows.Forms.Button();
            this.saveFileDialogAsStb = new System.Windows.Forms.SaveFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 740);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReport,
            this.toolStripButtonStackBuilder});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(624, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
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
            this.gbFlatDim.Size = new System.Drawing.Size(527, 68);
            this.gbFlatDim.TabIndex = 2;
            this.gbFlatDim.TabStop = false;
            this.gbFlatDim.Text = "Flat/Bundle";
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
            this.nudFlatWeight.Name = "nudFlatWeight";
            this.nudFlatWeight.Size = new System.Drawing.Size(70, 20);
            this.nudFlatWeight.TabIndex = 9;
            this.nudFlatWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatWeight.ValueChanged += new System.EventHandler(this.DimensionsChanged);
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
            this.nudNumberOfFlats.ValueChanged += new System.EventHandler(this.DimensionsChanged);
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
            this.nudFlatThickness.Size = new System.Drawing.Size(69, 20);
            this.nudFlatThickness.TabIndex = 5;
            this.nudFlatThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFlatThickness.ValueChanged += new System.EventHandler(this.DimensionsChanged);
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
            this.nudFlatWidth.ValueChanged += new System.EventHandler(this.DimensionsChanged);
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
            this.nudFlatLength.ValueChanged += new System.EventHandler(this.DimensionsChanged);
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
            // bnClose
            // 
            this.bnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnClose.Location = new System.Drawing.Point(537, 29);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(75, 23);
            this.bnClose.TabIndex = 3;
            this.bnClose.Text = "Close";
            this.bnClose.UseVisualStyleBackColor = true;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // gbPallet
            // 
            this.gbPallet.Controls.Add(this.nudMaxPalletHeight);
            this.gbPallet.Controls.Add(this.lbMaximumPalletHeight);
            this.gbPallet.Controls.Add(this.lbPalletDescription);
            this.gbPallet.Controls.Add(this.lbDescription);
            this.gbPallet.Controls.Add(this.cbPallet);
            this.gbPallet.Controls.Add(this.graphCtrlPallet);
            this.gbPallet.Controls.Add(this.label1);
            this.gbPallet.Location = new System.Drawing.Point(4, 101);
            this.gbPallet.Name = "gbPallet";
            this.gbPallet.Size = new System.Drawing.Size(608, 100);
            this.gbPallet.TabIndex = 4;
            this.gbPallet.TabStop = false;
            this.gbPallet.Text = "Pallet";
            // 
            // nudMaxPalletHeight
            // 
            this.nudMaxPalletHeight.DecimalPlaces = 2;
            this.nudMaxPalletHeight.Location = new System.Drawing.Point(146, 71);
            this.nudMaxPalletHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxPalletHeight.Name = "nudMaxPalletHeight";
            this.nudMaxPalletHeight.Size = new System.Drawing.Size(78, 20);
            this.nudMaxPalletHeight.TabIndex = 6;
            // 
            // lbMaximumPalletHeight
            // 
            this.lbMaximumPalletHeight.AutoSize = true;
            this.lbMaximumPalletHeight.Location = new System.Drawing.Point(12, 73);
            this.lbMaximumPalletHeight.Name = "lbMaximumPalletHeight";
            this.lbMaximumPalletHeight.Size = new System.Drawing.Size(111, 13);
            this.lbMaximumPalletHeight.TabIndex = 5;
            this.lbMaximumPalletHeight.Text = "Maximum pallet height";
            // 
            // lbPalletDescription
            // 
            this.lbPalletDescription.AutoSize = true;
            this.lbPalletDescription.Location = new System.Drawing.Point(146, 43);
            this.lbPalletDescription.Name = "lbPalletDescription";
            this.lbPalletDescription.Size = new System.Drawing.Size(94, 13);
            this.lbPalletDescription.TabIndex = 4;
            this.lbPalletDescription.Text = "lbPalletDescription";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(12, 43);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "Description";
            // 
            // cbPallet
            // 
            this.cbPallet.AllowDrop = true;
            this.cbPallet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPallet.FormattingEnabled = true;
            this.cbPallet.Location = new System.Drawing.Point(146, 14);
            this.cbPallet.Name = "cbPallet";
            this.cbPallet.Size = new System.Drawing.Size(255, 21);
            this.cbPallet.TabIndex = 2;
            this.cbPallet.SelectedIndexChanged += new System.EventHandler(this.cbPallet_SelectedIndexChanged);
            // 
            // graphCtrlPallet
            // 
            this.graphCtrlPallet.Location = new System.Drawing.Point(415, 12);
            this.graphCtrlPallet.Name = "graphCtrlPallet";
            this.graphCtrlPallet.Size = new System.Drawing.Size(187, 82);
            this.graphCtrlPallet.TabIndex = 1;
            this.graphCtrlPallet.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pallet";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(4, 208);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gridSolutions);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.graphCtrlSolution);
            this.splitContainer.Size = new System.Drawing.Size(620, 529);
            this.splitContainer.SplitterDistance = 153;
            this.splitContainer.TabIndex = 5;
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
            this.gridSolutions.Size = new System.Drawing.Size(620, 153);
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
            this.graphCtrlSolution.Size = new System.Drawing.Size(620, 372);
            this.graphCtrlSolution.TabIndex = 0;
            this.graphCtrlSolution.TabStop = false;
            // 
            // bnRefresh
            // 
            this.bnRefresh.Location = new System.Drawing.Point(538, 72);
            this.bnRefresh.Name = "bnRefresh";
            this.bnRefresh.Size = new System.Drawing.Size(75, 23);
            this.bnRefresh.TabIndex = 6;
            this.bnRefresh.Text = "Refresh";
            this.bnRefresh.UseVisualStyleBackColor = true;
            // 
            // saveFileDialogAsStb
            // 
            this.saveFileDialogAsStb.DefaultExt = "stb";
            this.saveFileDialogAsStb.Filter = "StackBuilder (*.stb)|*.stb";
            this.saveFileDialogAsStb.Title = "Save as StackBuilder project...";
            // 
            // FormDefineBundlePalletAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnClose;
            this.ClientSize = new System.Drawing.Size(624, 762);
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
            this.Text = "Bundle/pallet analysis...";
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
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlSolution)).EndInit();
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