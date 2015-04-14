namespace TreeDim.StackBuilder.Desktop
{
    partial class FormNewAnalysisPackPallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewAnalysisPackPallet));
            this.lbPack = new System.Windows.Forms.Label();
            this.lbPallet = new System.Windows.Forms.Label();
            this.cbPack = new System.Windows.Forms.ComboBox();
            this.cbPallet = new System.Windows.Forms.ComboBox();
            this.chkbInterlayer = new System.Windows.Forms.CheckBox();
            this.cbInterlayer = new System.Windows.Forms.ComboBox();
            this.lbInterlayerPeriod = new System.Windows.Forms.Label();
            this.nudInterlayerPeriod = new System.Windows.Forms.NumericUpDown();
            this.chkbInterlayerFirstLayer = new System.Windows.Forms.CheckBox();
            this.lbLayerSwapPeriod = new System.Windows.Forms.Label();
            this.nudSwapPeriod = new System.Windows.Forms.NumericUpDown();
            this.gbOverhang = new System.Windows.Forms.GroupBox();
            this.uCtrlOptOverhangYMin = new TreeDim.StackBuilder.Basics.UCtrlOptDouble();
            this.uCtrlOptOverhangXMin = new TreeDim.StackBuilder.Basics.UCtrlOptDouble();
            this.uCtrlOverhangY = new TreeDim.StackBuilder.Basics.UCtrlDouble();
            this.uCtrlOverhangX = new TreeDim.StackBuilder.Basics.UCtrlDouble();
            this.uCtrlOptMinimumSpace = new TreeDim.StackBuilder.Basics.UCtrlOptDouble();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uCtrlOptMaximumWeight = new TreeDim.StackBuilder.Basics.UCtrlOptDouble();
            this.uCtrlOptMaximumHeight = new TreeDim.StackBuilder.Basics.UCtrlOptDouble();
            this.uCtrlOptMaximumLayerWeight = new TreeDim.StackBuilder.Basics.UCtrlOptDouble();
            this.uCtrlOptMaximumSpace = new TreeDim.StackBuilder.Basics.UCtrlOptDouble();
            this.gbAdditionnalFiltering = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterlayerPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwapPeriod)).BeginInit();
            this.gbOverhang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAdditionnalFiltering.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPack
            // 
            this.lbPack.AutoSize = true;
            this.lbPack.Location = new System.Drawing.Point(13, 79);
            this.lbPack.Name = "lbPack";
            this.lbPack.Size = new System.Drawing.Size(32, 13);
            this.lbPack.TabIndex = 7;
            this.lbPack.Text = "Pack";
            // 
            // lbPallet
            // 
            this.lbPallet.AutoSize = true;
            this.lbPallet.Location = new System.Drawing.Point(327, 79);
            this.lbPallet.Name = "lbPallet";
            this.lbPallet.Size = new System.Drawing.Size(33, 13);
            this.lbPallet.TabIndex = 8;
            this.lbPallet.Text = "Pallet";
            // 
            // cbPack
            // 
            this.cbPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPack.FormattingEnabled = true;
            this.cbPack.Location = new System.Drawing.Point(111, 76);
            this.cbPack.Name = "cbPack";
            this.cbPack.Size = new System.Drawing.Size(164, 21);
            this.cbPack.TabIndex = 9;
            this.cbPack.SelectedIndexChanged += new System.EventHandler(this.onConstraintSetModified);
            // 
            // cbPallet
            // 
            this.cbPallet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPallet.FormattingEnabled = true;
            this.cbPallet.Location = new System.Drawing.Point(407, 76);
            this.cbPallet.Name = "cbPallet";
            this.cbPallet.Size = new System.Drawing.Size(165, 21);
            this.cbPallet.TabIndex = 10;
            this.cbPallet.SelectedIndexChanged += new System.EventHandler(this.onConstraintSetModified);
            // 
            // chkbInterlayer
            // 
            this.chkbInterlayer.AutoSize = true;
            this.chkbInterlayer.Location = new System.Drawing.Point(13, 111);
            this.chkbInterlayer.Name = "chkbInterlayer";
            this.chkbInterlayer.Size = new System.Drawing.Size(69, 17);
            this.chkbInterlayer.TabIndex = 11;
            this.chkbInterlayer.Text = "Interlayer";
            this.chkbInterlayer.UseVisualStyleBackColor = true;
            this.chkbInterlayer.CheckedChanged += new System.EventHandler(this.onInterlayerChecked);
            // 
            // cbInterlayer
            // 
            this.cbInterlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterlayer.FormattingEnabled = true;
            this.cbInterlayer.Location = new System.Drawing.Point(111, 109);
            this.cbInterlayer.Name = "cbInterlayer";
            this.cbInterlayer.Size = new System.Drawing.Size(164, 21);
            this.cbInterlayer.TabIndex = 12;
            this.cbInterlayer.SelectedIndexChanged += new System.EventHandler(this.onConstraintSetModified);
            // 
            // lbInterlayerPeriod
            // 
            this.lbInterlayerPeriod.AutoSize = true;
            this.lbInterlayerPeriod.Location = new System.Drawing.Point(327, 136);
            this.lbInterlayerPeriod.Name = "lbInterlayerPeriod";
            this.lbInterlayerPeriod.Size = new System.Drawing.Size(82, 13);
            this.lbInterlayerPeriod.TabIndex = 13;
            this.lbInterlayerPeriod.Text = "Interlayer period";
            // 
            // nudInterlayerPeriod
            // 
            this.nudInterlayerPeriod.Location = new System.Drawing.Point(469, 134);
            this.nudInterlayerPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInterlayerPeriod.Name = "nudInterlayerPeriod";
            this.nudInterlayerPeriod.Size = new System.Drawing.Size(60, 20);
            this.nudInterlayerPeriod.TabIndex = 14;
            this.nudInterlayerPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkbInterlayerFirstLayer
            // 
            this.chkbInterlayerFirstLayer.AutoSize = true;
            this.chkbInterlayerFirstLayer.Location = new System.Drawing.Point(327, 111);
            this.chkbInterlayerFirstLayer.Name = "chkbInterlayerFirstLayer";
            this.chkbInterlayerFirstLayer.Size = new System.Drawing.Size(129, 17);
            this.chkbInterlayerFirstLayer.TabIndex = 15;
            this.chkbInterlayerFirstLayer.Text = "Insert before first layer";
            this.chkbInterlayerFirstLayer.UseVisualStyleBackColor = true;
            // 
            // lbLayerSwapPeriod
            // 
            this.lbLayerSwapPeriod.AutoSize = true;
            this.lbLayerSwapPeriod.Location = new System.Drawing.Point(13, 168);
            this.lbLayerSwapPeriod.Name = "lbLayerSwapPeriod";
            this.lbLayerSwapPeriod.Size = new System.Drawing.Size(93, 13);
            this.lbLayerSwapPeriod.TabIndex = 16;
            this.lbLayerSwapPeriod.Text = "Layer swap period";
            // 
            // nudSwapPeriod
            // 
            this.nudSwapPeriod.Location = new System.Drawing.Point(111, 164);
            this.nudSwapPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSwapPeriod.Name = "nudSwapPeriod";
            this.nudSwapPeriod.Size = new System.Drawing.Size(60, 20);
            this.nudSwapPeriod.TabIndex = 17;
            this.nudSwapPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSwapPeriod.ValueChanged += new System.EventHandler(this.onConstraintSetModified);
            // 
            // gbOverhang
            // 
            this.gbOverhang.Controls.Add(this.uCtrlOptOverhangYMin);
            this.gbOverhang.Controls.Add(this.uCtrlOptOverhangXMin);
            this.gbOverhang.Controls.Add(this.uCtrlOverhangY);
            this.gbOverhang.Controls.Add(this.uCtrlOverhangX);
            this.gbOverhang.Location = new System.Drawing.Point(0, 194);
            this.gbOverhang.Name = "gbOverhang";
            this.gbOverhang.Size = new System.Drawing.Size(584, 62);
            this.gbOverhang.TabIndex = 18;
            this.gbOverhang.TabStop = false;
            this.gbOverhang.Text = "Overhang";
            // 
            // uCtrlOptOverhangYMin
            // 
            this.uCtrlOptOverhangYMin.Location = new System.Drawing.Point(296, 39);
            this.uCtrlOptOverhangYMin.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOptOverhangYMin.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlOptOverhangYMin.Name = "uCtrlOptOverhangYMin";
            this.uCtrlOptOverhangYMin.Size = new System.Drawing.Size(272, 20);
            this.uCtrlOptOverhangYMin.TabIndex = 2;
            this.uCtrlOptOverhangYMin.Text = "Width (Min.)";
            this.uCtrlOptOverhangYMin.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOptOverhangYMin.Value = ((TreeDim.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptOverhangYMin.Value")));
            this.uCtrlOptOverhangYMin.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOptOverhangXMin
            // 
            this.uCtrlOptOverhangXMin.Location = new System.Drawing.Point(296, 14);
            this.uCtrlOptOverhangXMin.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOptOverhangXMin.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlOptOverhangXMin.Name = "uCtrlOptOverhangXMin";
            this.uCtrlOptOverhangXMin.Size = new System.Drawing.Size(272, 20);
            this.uCtrlOptOverhangXMin.TabIndex = 0;
            this.uCtrlOptOverhangXMin.Text = "Length (Min.)";
            this.uCtrlOptOverhangXMin.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOptOverhangXMin.Value = ((TreeDim.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptOverhangXMin.Value")));
            this.uCtrlOptOverhangXMin.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOverhangY
            // 
            this.uCtrlOverhangY.Location = new System.Drawing.Point(6, 39);
            this.uCtrlOverhangY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOverhangY.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlOverhangY.Name = "uCtrlOverhangY";
            this.uCtrlOverhangY.Size = new System.Drawing.Size(269, 20);
            this.uCtrlOverhangY.TabIndex = 1;
            this.uCtrlOverhangY.Text = "Width (Max.)";
            this.uCtrlOverhangY.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOverhangY.Value = 0D;
            this.uCtrlOverhangY.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOverhangX
            // 
            this.uCtrlOverhangX.Location = new System.Drawing.Point(6, 14);
            this.uCtrlOverhangX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOverhangX.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlOverhangX.Name = "uCtrlOverhangX";
            this.uCtrlOverhangX.Size = new System.Drawing.Size(269, 20);
            this.uCtrlOverhangX.TabIndex = 0;
            this.uCtrlOverhangX.Text = "Length (Max.)";
            this.uCtrlOverhangX.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOverhangX.Value = 0D;
            this.uCtrlOverhangX.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOptMinimumSpace
            // 
            this.uCtrlOptMinimumSpace.Location = new System.Drawing.Point(6, 262);
            this.uCtrlOptMinimumSpace.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.uCtrlOptMinimumSpace.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlOptMinimumSpace.Name = "uCtrlOptMinimumSpace";
            this.uCtrlOptMinimumSpace.Size = new System.Drawing.Size(269, 20);
            this.uCtrlOptMinimumSpace.TabIndex = 19;
            this.uCtrlOptMinimumSpace.Text = "Minimum space";
            this.uCtrlOptMinimumSpace.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOptMinimumSpace.Value = ((TreeDim.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptMinimumSpace.Value")));
            this.uCtrlOptMinimumSpace.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uCtrlOptMaximumWeight);
            this.groupBox1.Controls.Add(this.uCtrlOptMaximumHeight);
            this.groupBox1.Location = new System.Drawing.Point(0, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 70);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stop stacking when:";
            // 
            // uCtrlOptMaximumWeight
            // 
            this.uCtrlOptMaximumWeight.Location = new System.Drawing.Point(7, 44);
            this.uCtrlOptMaximumWeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOptMaximumWeight.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlOptMaximumWeight.Name = "uCtrlOptMaximumWeight";
            this.uCtrlOptMaximumWeight.Size = new System.Drawing.Size(268, 20);
            this.uCtrlOptMaximumWeight.TabIndex = 1;
            this.uCtrlOptMaximumWeight.Text = "Pallet weight reaches";
            this.uCtrlOptMaximumWeight.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_MASS;
            this.uCtrlOptMaximumWeight.Value = ((TreeDim.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptMaximumWeight.Value")));
            this.uCtrlOptMaximumWeight.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOptMaximumHeight
            // 
            this.uCtrlOptMaximumHeight.Location = new System.Drawing.Point(7, 19);
            this.uCtrlOptMaximumHeight.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.uCtrlOptMaximumHeight.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlOptMaximumHeight.Name = "uCtrlOptMaximumHeight";
            this.uCtrlOptMaximumHeight.Size = new System.Drawing.Size(268, 20);
            this.uCtrlOptMaximumHeight.TabIndex = 0;
            this.uCtrlOptMaximumHeight.Text = "Pallet height reaches";
            this.uCtrlOptMaximumHeight.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOptMaximumHeight.Value = ((TreeDim.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptMaximumHeight.Value")));
            this.uCtrlOptMaximumHeight.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOptMaximumLayerWeight
            // 
            this.uCtrlOptMaximumLayerWeight.Location = new System.Drawing.Point(7, 19);
            this.uCtrlOptMaximumLayerWeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOptMaximumLayerWeight.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlOptMaximumLayerWeight.Name = "uCtrlOptMaximumLayerWeight";
            this.uCtrlOptMaximumLayerWeight.Size = new System.Drawing.Size(276, 20);
            this.uCtrlOptMaximumLayerWeight.TabIndex = 21;
            this.uCtrlOptMaximumLayerWeight.Text = "Maximum layer weight";
            this.uCtrlOptMaximumLayerWeight.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_MASS;
            this.uCtrlOptMaximumLayerWeight.Value = ((TreeDim.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptMaximumLayerWeight.Value")));
            this.uCtrlOptMaximumLayerWeight.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOptMaximumSpace
            // 
            this.uCtrlOptMaximumSpace.Location = new System.Drawing.Point(7, 44);
            this.uCtrlOptMaximumSpace.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.uCtrlOptMaximumSpace.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlOptMaximumSpace.Name = "uCtrlOptMaximumSpace";
            this.uCtrlOptMaximumSpace.Size = new System.Drawing.Size(276, 20);
            this.uCtrlOptMaximumSpace.TabIndex = 22;
            this.uCtrlOptMaximumSpace.Text = "Maximum space allowed";
            this.uCtrlOptMaximumSpace.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOptMaximumSpace.Value = ((TreeDim.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptMaximumSpace.Value")));
            this.uCtrlOptMaximumSpace.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // gbAdditionnalFiltering
            // 
            this.gbAdditionnalFiltering.Controls.Add(this.uCtrlOptMaximumSpace);
            this.gbAdditionnalFiltering.Controls.Add(this.uCtrlOptMaximumLayerWeight);
            this.gbAdditionnalFiltering.Location = new System.Drawing.Point(289, 296);
            this.gbAdditionnalFiltering.Name = "gbAdditionnalFiltering";
            this.gbAdditionnalFiltering.Size = new System.Drawing.Size(295, 70);
            this.gbAdditionnalFiltering.TabIndex = 23;
            this.gbAdditionnalFiltering.TabStop = false;
            this.gbAdditionnalFiltering.Text = "Solution filtering";
            // 
            // FormNewPackPalletAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.gbAdditionnalFiltering);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uCtrlOptMinimumSpace);
            this.Controls.Add(this.gbOverhang);
            this.Controls.Add(this.nudSwapPeriod);
            this.Controls.Add(this.lbLayerSwapPeriod);
            this.Controls.Add(this.chkbInterlayerFirstLayer);
            this.Controls.Add(this.nudInterlayerPeriod);
            this.Controls.Add(this.lbInterlayerPeriod);
            this.Controls.Add(this.cbInterlayer);
            this.Controls.Add(this.chkbInterlayer);
            this.Controls.Add(this.cbPallet);
            this.Controls.Add(this.cbPack);
            this.Controls.Add(this.lbPallet);
            this.Controls.Add(this.lbPack);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "FormNewPackPalletAnalysis";
            this.Text = "Create new Pack/Pallet analysis...";
            this.Controls.SetChildIndex(this.lbPack, 0);
            this.Controls.SetChildIndex(this.lbPallet, 0);
            this.Controls.SetChildIndex(this.cbPack, 0);
            this.Controls.SetChildIndex(this.cbPallet, 0);
            this.Controls.SetChildIndex(this.chkbInterlayer, 0);
            this.Controls.SetChildIndex(this.cbInterlayer, 0);
            this.Controls.SetChildIndex(this.lbInterlayerPeriod, 0);
            this.Controls.SetChildIndex(this.nudInterlayerPeriod, 0);
            this.Controls.SetChildIndex(this.chkbInterlayerFirstLayer, 0);
            this.Controls.SetChildIndex(this.lbLayerSwapPeriod, 0);
            this.Controls.SetChildIndex(this.nudSwapPeriod, 0);
            this.Controls.SetChildIndex(this.gbOverhang, 0);
            this.Controls.SetChildIndex(this.uCtrlOptMinimumSpace, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gbAdditionnalFiltering, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterlayerPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwapPeriod)).EndInit();
            this.gbOverhang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbAdditionnalFiltering.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPack;
        private System.Windows.Forms.Label lbPallet;
        private System.Windows.Forms.ComboBox cbPack;
        private System.Windows.Forms.ComboBox cbPallet;
        private System.Windows.Forms.CheckBox chkbInterlayer;
        private System.Windows.Forms.ComboBox cbInterlayer;
        private System.Windows.Forms.Label lbInterlayerPeriod;
        private System.Windows.Forms.NumericUpDown nudInterlayerPeriod;
        private System.Windows.Forms.CheckBox chkbInterlayerFirstLayer;
        private System.Windows.Forms.Label lbLayerSwapPeriod;
        private System.Windows.Forms.NumericUpDown nudSwapPeriod;
        private System.Windows.Forms.GroupBox gbOverhang;
        private Basics.UCtrlDouble uCtrlOverhangX;
        private Basics.UCtrlDouble uCtrlOverhangY;
        private Basics.UCtrlOptDouble uCtrlOptMinimumSpace;
        private System.Windows.Forms.GroupBox groupBox1;
        private Basics.UCtrlOptDouble uCtrlOptMaximumWeight;
        private Basics.UCtrlOptDouble uCtrlOptMaximumHeight;
        private Basics.UCtrlOptDouble uCtrlOptMaximumLayerWeight;
        private Basics.UCtrlOptDouble uCtrlOptMaximumSpace;
        private Basics.UCtrlOptDouble uCtrlOptOverhangYMin;
        private Basics.UCtrlOptDouble uCtrlOptOverhangXMin;
        private System.Windows.Forms.GroupBox gbAdditionnalFiltering;
    }
}