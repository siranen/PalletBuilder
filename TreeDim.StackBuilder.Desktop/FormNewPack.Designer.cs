namespace TreeDim.StackBuilder.Desktop
{
    partial class FormNewPack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewPack));
            this.graphCtrl = new TreeDim.StackBuilder.Graphics.Graphics3DControl();
            this.lbBox = new System.Windows.Forms.Label();
            this.cbInnerBox = new System.Windows.Forms.ComboBox();
            this.lbDir = new System.Windows.Forms.Label();
            this.cbDir = new System.Windows.Forms.ComboBox();
            this.uCtrlOuterDimensions = new TreeDim.StackBuilder.Basics.UCtrlOptTriDouble();
            this.uCtrlLayout = new TreeDim.StackBuilder.Basics.Controls.UCtrlTriInt();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uCtrlHeight = new TreeDim.StackBuilder.Basics.UCtrlDouble();
            this.uCtrlWalls = new TreeDim.StackBuilder.Basics.Controls.UCtrlTriInt();
            this.chkbTransparent = new System.Windows.Forms.CheckBox();
            this.lbType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.uCtrlWeight = new TreeDim.StackBuilder.Basics.UCtrlDouble();
            this.uCtrlThickness = new TreeDim.StackBuilder.Basics.UCtrlDouble();
            this.lbWrapperColor = new System.Windows.Forms.Label();
            this.cbColor = new OfficePickers.ColorPicker.ComboBoxColorPicker();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphCtrl
            // 
            resources.ApplyResources(this.graphCtrl, "graphCtrl");
            this.graphCtrl.Name = "graphCtrl";
            // 
            // lbBox
            // 
            resources.ApplyResources(this.lbBox, "lbBox");
            this.lbBox.Name = "lbBox";
            // 
            // cbInnerBox
            // 
            resources.ApplyResources(this.cbInnerBox, "cbInnerBox");
            this.cbInnerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInnerBox.FormattingEnabled = true;
            this.cbInnerBox.Name = "cbInnerBox";
            // 
            // lbDir
            // 
            resources.ApplyResources(this.lbDir, "lbDir");
            this.lbDir.Name = "lbDir";
            // 
            // cbDir
            // 
            resources.ApplyResources(this.cbDir, "cbDir");
            this.cbDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDir.FormattingEnabled = true;
            this.cbDir.Items.AddRange(new object[] {
            resources.GetString("cbDir.Items"),
            resources.GetString("cbDir.Items1"),
            resources.GetString("cbDir.Items2"),
            resources.GetString("cbDir.Items3"),
            resources.GetString("cbDir.Items4"),
            resources.GetString("cbDir.Items5")});
            this.cbDir.Name = "cbDir";
            this.cbDir.SelectedIndexChanged += new System.EventHandler(this.onPackChanged);
            // 
            // uCtrlOuterDimensions
            // 
            resources.ApplyResources(this.uCtrlOuterDimensions, "uCtrlOuterDimensions");
            this.uCtrlOuterDimensions.Checked = false;
            this.uCtrlOuterDimensions.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uCtrlOuterDimensions.Name = "uCtrlOuterDimensions";
            this.uCtrlOuterDimensions.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOuterDimensions.Value = ((Sharp3D.Math.Core.Vector3D)(resources.GetObject("uCtrlOuterDimensions.Value")));
            this.uCtrlOuterDimensions.X = 0D;
            this.uCtrlOuterDimensions.Y = 0D;
            this.uCtrlOuterDimensions.Z = 0D;
            this.uCtrlOuterDimensions.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlOptTriDouble.onValueChanged(this.onPackChanged);
            // 
            // uCtrlLayout
            // 
            resources.ApplyResources(this.uCtrlLayout, "uCtrlLayout");
            this.uCtrlLayout.Name = "uCtrlLayout";
            this.uCtrlLayout.NoX = 1;
            this.uCtrlLayout.NoY = 1;
            this.uCtrlLayout.NoZ = 1;
            this.uCtrlLayout.ValueChanged += new TreeDim.StackBuilder.Basics.Controls.UCtrlTriInt.onValueChanged(this.onPackChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.uCtrlHeight);
            this.groupBox1.Controls.Add(this.uCtrlWalls);
            this.groupBox1.Controls.Add(this.chkbTransparent);
            this.groupBox1.Controls.Add(this.lbType);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.uCtrlWeight);
            this.groupBox1.Controls.Add(this.uCtrlThickness);
            this.groupBox1.Controls.Add(this.lbWrapperColor);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // uCtrlHeight
            // 
            resources.ApplyResources(this.uCtrlHeight, "uCtrlHeight");
            this.uCtrlHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uCtrlHeight.Name = "uCtrlHeight";
            this.uCtrlHeight.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlHeight.Value = 40D;
            this.uCtrlHeight.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlDouble.onValueChanged(this.onPackChanged);
            // 
            // uCtrlWalls
            // 
            resources.ApplyResources(this.uCtrlWalls, "uCtrlWalls");
            this.uCtrlWalls.Name = "uCtrlWalls";
            this.uCtrlWalls.NoX = 1;
            this.uCtrlWalls.NoY = 1;
            this.uCtrlWalls.NoZ = 1;
            this.uCtrlWalls.ValueChanged += new TreeDim.StackBuilder.Basics.Controls.UCtrlTriInt.onValueChanged(this.onPackChanged);
            // 
            // chkbTransparent
            // 
            resources.ApplyResources(this.chkbTransparent, "chkbTransparent");
            this.chkbTransparent.Name = "chkbTransparent";
            this.chkbTransparent.UseVisualStyleBackColor = true;
            this.chkbTransparent.CheckedChanged += new System.EventHandler(this.onPackChanged);
            // 
            // lbType
            // 
            resources.ApplyResources(this.lbType, "lbType");
            this.lbType.Name = "lbType";
            // 
            // cbType
            // 
            resources.ApplyResources(this.cbType, "cbType");
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            resources.GetString("cbType.Items"),
            resources.GetString("cbType.Items1"),
            resources.GetString("cbType.Items2"),
            resources.GetString("cbType.Items3")});
            this.cbType.Name = "cbType";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.onWrapperTypeChanged);
            // 
            // uCtrlWeight
            // 
            resources.ApplyResources(this.uCtrlWeight, "uCtrlWeight");
            this.uCtrlWeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlWeight.Name = "uCtrlWeight";
            this.uCtrlWeight.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_MASS;
            this.uCtrlWeight.Value = 0D;
            this.uCtrlWeight.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlDouble.onValueChanged(this.onPackChanged);
            // 
            // uCtrlThickness
            // 
            resources.ApplyResources(this.uCtrlThickness, "uCtrlThickness");
            this.uCtrlThickness.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uCtrlThickness.Name = "uCtrlThickness";
            this.uCtrlThickness.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlThickness.Value = 0D;
            this.uCtrlThickness.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlDouble.onValueChanged(this.onPackChanged);
            // 
            // lbWrapperColor
            // 
            resources.ApplyResources(this.lbWrapperColor, "lbWrapperColor");
            this.lbWrapperColor.Name = "lbWrapperColor";
            // 
            // cbColor
            // 
            resources.ApplyResources(this.cbColor, "cbColor");
            this.cbColor.Color = System.Drawing.Color.LightGray;
            this.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbColor.DropDownHeight = 1;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.DropDownWidth = 1;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            resources.GetString("cbColor.Items"),
            resources.GetString("cbColor.Items1"),
            resources.GetString("cbColor.Items2"),
            resources.GetString("cbColor.Items3"),
            resources.GetString("cbColor.Items4"),
            resources.GetString("cbColor.Items5"),
            resources.GetString("cbColor.Items6"),
            resources.GetString("cbColor.Items7"),
            resources.GetString("cbColor.Items8"),
            resources.GetString("cbColor.Items9"),
            resources.GetString("cbColor.Items10"),
            resources.GetString("cbColor.Items11"),
            resources.GetString("cbColor.Items12"),
            resources.GetString("cbColor.Items13"),
            resources.GetString("cbColor.Items14"),
            resources.GetString("cbColor.Items15"),
            resources.GetString("cbColor.Items16"),
            resources.GetString("cbColor.Items17"),
            resources.GetString("cbColor.Items18"),
            resources.GetString("cbColor.Items19"),
            resources.GetString("cbColor.Items20"),
            resources.GetString("cbColor.Items21"),
            resources.GetString("cbColor.Items22"),
            resources.GetString("cbColor.Items23"),
            resources.GetString("cbColor.Items24"),
            resources.GetString("cbColor.Items25")});
            this.cbColor.Name = "cbColor";
            this.cbColor.SelectedColorChanged += new System.EventHandler(this.onPackChanged);
            // 
            // FormNewPack
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uCtrlLayout);
            this.Controls.Add(this.uCtrlOuterDimensions);
            this.Controls.Add(this.cbDir);
            this.Controls.Add(this.lbDir);
            this.Controls.Add(this.cbInnerBox);
            this.Controls.Add(this.lbBox);
            this.Controls.Add(this.graphCtrl);
            this.Name = "FormNewPack";
            this.Load += new System.EventHandler(this.FormNewPack_Load);
            this.Controls.SetChildIndex(this.graphCtrl, 0);
            this.Controls.SetChildIndex(this.lbBox, 0);
            this.Controls.SetChildIndex(this.cbInnerBox, 0);
            this.Controls.SetChildIndex(this.lbDir, 0);
            this.Controls.SetChildIndex(this.cbDir, 0);
            this.Controls.SetChildIndex(this.uCtrlOuterDimensions, 0);
            this.Controls.SetChildIndex(this.uCtrlLayout, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Graphics.Graphics3DControl graphCtrl;
        private System.Windows.Forms.Label lbBox;
        private System.Windows.Forms.ComboBox cbInnerBox;
        private System.Windows.Forms.Label lbDir;
        private System.Windows.Forms.ComboBox cbDir;
        private Basics.UCtrlOptTriDouble uCtrlOuterDimensions;
        private Basics.Controls.UCtrlTriInt uCtrlLayout;
        private System.Windows.Forms.GroupBox groupBox1;
        private Basics.UCtrlDouble uCtrlWeight;
        private Basics.UCtrlDouble uCtrlThickness;
        private System.Windows.Forms.Label lbWrapperColor;
        private OfficePickers.ColorPicker.ComboBoxColorPicker cbColor;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbType;
        private Basics.Controls.UCtrlTriInt uCtrlWalls;
        private System.Windows.Forms.CheckBox chkbTransparent;
        private Basics.UCtrlDouble uCtrlHeight;
    }
}