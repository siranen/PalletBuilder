namespace treeDiM.StackBuilder.Desktop
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
            this.uCtrlOptOverhangYMin = new treeDiM.StackBuilder.Basics.UCtrlOptDouble();
            this.uCtrlOptOverhangXMin = new treeDiM.StackBuilder.Basics.UCtrlOptDouble();
            this.uCtrlOverhangY = new treeDiM.StackBuilder.Basics.UCtrlDouble();
            this.uCtrlOverhangX = new treeDiM.StackBuilder.Basics.UCtrlDouble();
            this.uCtrlOptMinimumSpace = new treeDiM.StackBuilder.Basics.UCtrlOptDouble();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uCtrlOptMaximumWeight = new treeDiM.StackBuilder.Basics.UCtrlOptDouble();
            this.uCtrlOptMaximumHeight = new treeDiM.StackBuilder.Basics.UCtrlOptDouble();
            this.uCtrlOptMaximumLayerWeight = new treeDiM.StackBuilder.Basics.UCtrlOptDouble();
            this.uCtrlOptMaximumSpace = new treeDiM.StackBuilder.Basics.UCtrlOptDouble();
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
            resources.ApplyResources(this.lbPack, "lbPack");
            this.lbPack.Name = "lbPack";
            // 
            // lbPallet
            // 
            resources.ApplyResources(this.lbPallet, "lbPallet");
            this.lbPallet.Name = "lbPallet";
            // 
            // cbPack
            // 
            resources.ApplyResources(this.cbPack, "cbPack");
            this.cbPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPack.FormattingEnabled = true;
            this.cbPack.Name = "cbPack";
            this.cbPack.SelectedIndexChanged += new System.EventHandler(this.onConstraintSetModified);
            // 
            // cbPallet
            // 
            resources.ApplyResources(this.cbPallet, "cbPallet");
            this.cbPallet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPallet.FormattingEnabled = true;
            this.cbPallet.Name = "cbPallet";
            this.cbPallet.SelectedIndexChanged += new System.EventHandler(this.onConstraintSetModified);
            // 
            // chkbInterlayer
            // 
            resources.ApplyResources(this.chkbInterlayer, "chkbInterlayer");
            this.chkbInterlayer.Name = "chkbInterlayer";
            this.chkbInterlayer.UseVisualStyleBackColor = true;
            this.chkbInterlayer.CheckedChanged += new System.EventHandler(this.onInterlayerChecked);
            // 
            // cbInterlayer
            // 
            resources.ApplyResources(this.cbInterlayer, "cbInterlayer");
            this.cbInterlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterlayer.FormattingEnabled = true;
            this.cbInterlayer.Name = "cbInterlayer";
            this.cbInterlayer.SelectedIndexChanged += new System.EventHandler(this.onConstraintSetModified);
            // 
            // lbInterlayerPeriod
            // 
            resources.ApplyResources(this.lbInterlayerPeriod, "lbInterlayerPeriod");
            this.lbInterlayerPeriod.Name = "lbInterlayerPeriod";
            // 
            // nudInterlayerPeriod
            // 
            resources.ApplyResources(this.nudInterlayerPeriod, "nudInterlayerPeriod");
            this.nudInterlayerPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInterlayerPeriod.Name = "nudInterlayerPeriod";
            this.nudInterlayerPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkbInterlayerFirstLayer
            // 
            resources.ApplyResources(this.chkbInterlayerFirstLayer, "chkbInterlayerFirstLayer");
            this.chkbInterlayerFirstLayer.Name = "chkbInterlayerFirstLayer";
            this.chkbInterlayerFirstLayer.UseVisualStyleBackColor = true;
            // 
            // lbLayerSwapPeriod
            // 
            resources.ApplyResources(this.lbLayerSwapPeriod, "lbLayerSwapPeriod");
            this.lbLayerSwapPeriod.Name = "lbLayerSwapPeriod";
            // 
            // nudSwapPeriod
            // 
            resources.ApplyResources(this.nudSwapPeriod, "nudSwapPeriod");
            this.nudSwapPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSwapPeriod.Name = "nudSwapPeriod";
            this.nudSwapPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSwapPeriod.ValueChanged += new System.EventHandler(this.onConstraintSetModified);
            // 
            // gbOverhang
            // 
            resources.ApplyResources(this.gbOverhang, "gbOverhang");
            this.gbOverhang.Controls.Add(this.uCtrlOptOverhangYMin);
            this.gbOverhang.Controls.Add(this.uCtrlOptOverhangXMin);
            this.gbOverhang.Controls.Add(this.uCtrlOverhangY);
            this.gbOverhang.Controls.Add(this.uCtrlOverhangX);
            this.gbOverhang.Name = "gbOverhang";
            this.gbOverhang.TabStop = false;
            // 
            // uCtrlOptOverhangYMin
            // 
            resources.ApplyResources(this.uCtrlOptOverhangYMin, "uCtrlOptOverhangYMin");
            this.uCtrlOptOverhangYMin.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOptOverhangYMin.Name = "uCtrlOptOverhangYMin";
            this.uCtrlOptOverhangYMin.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOptOverhangYMin.Value = ((treeDiM.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptOverhangYMin.Value")));
            this.uCtrlOptOverhangYMin.ValueChanged += new treeDiM.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOptOverhangXMin
            // 
            resources.ApplyResources(this.uCtrlOptOverhangXMin, "uCtrlOptOverhangXMin");
            this.uCtrlOptOverhangXMin.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOptOverhangXMin.Name = "uCtrlOptOverhangXMin";
            this.uCtrlOptOverhangXMin.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOptOverhangXMin.Value = ((treeDiM.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptOverhangXMin.Value")));
            this.uCtrlOptOverhangXMin.ValueChanged += new treeDiM.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOverhangY
            // 
            resources.ApplyResources(this.uCtrlOverhangY, "uCtrlOverhangY");
            this.uCtrlOverhangY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOverhangY.Name = "uCtrlOverhangY";
            this.uCtrlOverhangY.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOverhangY.Value = 0D;
            this.uCtrlOverhangY.ValueChanged += new treeDiM.StackBuilder.Basics.UCtrlDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOverhangX
            // 
            resources.ApplyResources(this.uCtrlOverhangX, "uCtrlOverhangX");
            this.uCtrlOverhangX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOverhangX.Name = "uCtrlOverhangX";
            this.uCtrlOverhangX.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOverhangX.Value = 0D;
            this.uCtrlOverhangX.ValueChanged += new treeDiM.StackBuilder.Basics.UCtrlDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOptMinimumSpace
            // 
            resources.ApplyResources(this.uCtrlOptMinimumSpace, "uCtrlOptMinimumSpace");
            this.uCtrlOptMinimumSpace.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.uCtrlOptMinimumSpace.Name = "uCtrlOptMinimumSpace";
            this.uCtrlOptMinimumSpace.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOptMinimumSpace.Value = ((treeDiM.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptMinimumSpace.Value")));
            this.uCtrlOptMinimumSpace.ValueChanged += new treeDiM.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.uCtrlOptMaximumWeight);
            this.groupBox1.Controls.Add(this.uCtrlOptMaximumHeight);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // uCtrlOptMaximumWeight
            // 
            resources.ApplyResources(this.uCtrlOptMaximumWeight, "uCtrlOptMaximumWeight");
            this.uCtrlOptMaximumWeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOptMaximumWeight.Name = "uCtrlOptMaximumWeight";
            this.uCtrlOptMaximumWeight.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_MASS;
            this.uCtrlOptMaximumWeight.Value = ((treeDiM.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptMaximumWeight.Value")));
            this.uCtrlOptMaximumWeight.ValueChanged += new treeDiM.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOptMaximumHeight
            // 
            resources.ApplyResources(this.uCtrlOptMaximumHeight, "uCtrlOptMaximumHeight");
            this.uCtrlOptMaximumHeight.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.uCtrlOptMaximumHeight.Name = "uCtrlOptMaximumHeight";
            this.uCtrlOptMaximumHeight.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOptMaximumHeight.Value = ((treeDiM.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptMaximumHeight.Value")));
            this.uCtrlOptMaximumHeight.ValueChanged += new treeDiM.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOptMaximumLayerWeight
            // 
            resources.ApplyResources(this.uCtrlOptMaximumLayerWeight, "uCtrlOptMaximumLayerWeight");
            this.uCtrlOptMaximumLayerWeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOptMaximumLayerWeight.Name = "uCtrlOptMaximumLayerWeight";
            this.uCtrlOptMaximumLayerWeight.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_MASS;
            this.uCtrlOptMaximumLayerWeight.Value = ((treeDiM.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptMaximumLayerWeight.Value")));
            this.uCtrlOptMaximumLayerWeight.ValueChanged += new treeDiM.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // uCtrlOptMaximumSpace
            // 
            resources.ApplyResources(this.uCtrlOptMaximumSpace, "uCtrlOptMaximumSpace");
            this.uCtrlOptMaximumSpace.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.uCtrlOptMaximumSpace.Name = "uCtrlOptMaximumSpace";
            this.uCtrlOptMaximumSpace.Unit = treeDiM.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOptMaximumSpace.Value = ((treeDiM.StackBuilder.Basics.OptDouble)(resources.GetObject("uCtrlOptMaximumSpace.Value")));
            this.uCtrlOptMaximumSpace.ValueChanged += new treeDiM.StackBuilder.Basics.UCtrlOptDouble.onValueChanged(this.onConstraintSetModified);
            // 
            // gbAdditionnalFiltering
            // 
            resources.ApplyResources(this.gbAdditionnalFiltering, "gbAdditionnalFiltering");
            this.gbAdditionnalFiltering.Controls.Add(this.uCtrlOptMaximumSpace);
            this.gbAdditionnalFiltering.Controls.Add(this.uCtrlOptMaximumLayerWeight);
            this.gbAdditionnalFiltering.Name = "gbAdditionnalFiltering";
            this.gbAdditionnalFiltering.TabStop = false;
            // 
            // FormNewAnalysisPackPallet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "FormNewAnalysisPackPallet";
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