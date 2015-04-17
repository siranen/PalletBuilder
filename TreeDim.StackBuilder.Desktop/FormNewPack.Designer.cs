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
            this.graphCtrl.Location = new System.Drawing.Point(295, 95);
            this.graphCtrl.Name = "graphCtrl";
            this.graphCtrl.Size = new System.Drawing.Size(277, 215);
            this.graphCtrl.TabIndex = 7;
            // 
            // lbBox
            // 
            this.lbBox.AutoSize = true;
            this.lbBox.Location = new System.Drawing.Point(16, 69);
            this.lbBox.Name = "lbBox";
            this.lbBox.Size = new System.Drawing.Size(25, 13);
            this.lbBox.TabIndex = 8;
            this.lbBox.Text = "Box";
            // 
            // cbInnerBox
            // 
            this.cbInnerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInnerBox.FormattingEnabled = true;
            this.cbInnerBox.Location = new System.Drawing.Point(111, 65);
            this.cbInnerBox.Name = "cbInnerBox";
            this.cbInnerBox.Size = new System.Drawing.Size(178, 21);
            this.cbInnerBox.TabIndex = 9;
            // 
            // lbDir
            // 
            this.lbDir.AutoSize = true;
            this.lbDir.Location = new System.Drawing.Point(365, 69);
            this.lbDir.Name = "lbDir";
            this.lbDir.Size = new System.Drawing.Size(49, 13);
            this.lbDir.TabIndex = 10;
            this.lbDir.Text = "Direction";
            // 
            // cbDir
            // 
            this.cbDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDir.FormattingEnabled = true;
            this.cbDir.Items.AddRange(new object[] {
            "X-",
            "X+",
            "Y-",
            "Y+",
            "Z-",
            "Z+"});
            this.cbDir.Location = new System.Drawing.Point(422, 65);
            this.cbDir.Name = "cbDir";
            this.cbDir.Size = new System.Drawing.Size(69, 21);
            this.cbDir.TabIndex = 11;
            this.cbDir.SelectedIndexChanged += new System.EventHandler(this.onPackChanged);
            // 
            // uCtrlOuterDimensions
            // 
            this.uCtrlOuterDimensions.Checked = false;
            this.uCtrlOuterDimensions.Location = new System.Drawing.Point(16, 317);
            this.uCtrlOuterDimensions.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uCtrlOuterDimensions.Name = "uCtrlOuterDimensions";
            this.uCtrlOuterDimensions.Size = new System.Drawing.Size(344, 20);
            this.uCtrlOuterDimensions.TabIndex = 13;
            this.uCtrlOuterDimensions.Text = "Outer dimensions";
            this.uCtrlOuterDimensions.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlOuterDimensions.X = 0D;
            this.uCtrlOuterDimensions.Y = 0D;
            this.uCtrlOuterDimensions.Z = 0D;
            this.uCtrlOuterDimensions.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlOptTriDouble.onValueChanged(this.onPackChanged);
            // 
            // uCtrlLayout
            // 
            this.uCtrlLayout.Location = new System.Drawing.Point(16, 95);
            this.uCtrlLayout.Name = "uCtrlLayout";
            this.uCtrlLayout.NoX = 1;
            this.uCtrlLayout.NoY = 1;
            this.uCtrlLayout.NoZ = 1;
            this.uCtrlLayout.Size = new System.Drawing.Size(273, 20);
            this.uCtrlLayout.TabIndex = 14;
            this.uCtrlLayout.Text = "Layout";
            this.uCtrlLayout.ValueChanged += new TreeDim.StackBuilder.Basics.Controls.UCtrlTriInt.onValueChanged(this.onPackChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uCtrlHeight);
            this.groupBox1.Controls.Add(this.uCtrlWalls);
            this.groupBox1.Controls.Add(this.chkbTransparent);
            this.groupBox1.Controls.Add(this.lbType);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.uCtrlWeight);
            this.groupBox1.Controls.Add(this.uCtrlThickness);
            this.groupBox1.Controls.Add(this.lbWrapperColor);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Location = new System.Drawing.Point(13, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 188);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wrapper";
            // 
            // uCtrlHeight
            // 
            this.uCtrlHeight.Location = new System.Drawing.Point(6, 162);
            this.uCtrlHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uCtrlHeight.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlHeight.Name = "uCtrlHeight";
            this.uCtrlHeight.Size = new System.Drawing.Size(180, 20);
            this.uCtrlHeight.TabIndex = 10;
            this.uCtrlHeight.Text = "Height";
            this.uCtrlHeight.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlHeight.Value = 40D;
            this.uCtrlHeight.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlDouble.onValueChanged(this.onPackChanged);
            // 
            // uCtrlWalls
            // 
            this.uCtrlWalls.Location = new System.Drawing.Point(6, 135);
            this.uCtrlWalls.Name = "uCtrlWalls";
            this.uCtrlWalls.NoX = 1;
            this.uCtrlWalls.NoY = 1;
            this.uCtrlWalls.NoZ = 1;
            this.uCtrlWalls.Size = new System.Drawing.Size(264, 20);
            this.uCtrlWalls.TabIndex = 9;
            this.uCtrlWalls.Text = "Numer of walls";
            this.uCtrlWalls.ValueChanged += new TreeDim.StackBuilder.Basics.Controls.UCtrlTriInt.onValueChanged(this.onPackChanged);
            // 
            // chkbTransparent
            // 
            this.chkbTransparent.AutoSize = true;
            this.chkbTransparent.Location = new System.Drawing.Point(6, 113);
            this.chkbTransparent.Name = "chkbTransparent";
            this.chkbTransparent.Size = new System.Drawing.Size(83, 17);
            this.chkbTransparent.TabIndex = 8;
            this.chkbTransparent.Text = "Transparent";
            this.chkbTransparent.UseVisualStyleBackColor = true;
            this.chkbTransparent.CheckedChanged += new System.EventHandler(this.onPackChanged);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(6, 16);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 13);
            this.lbType.TabIndex = 7;
            this.lbType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Polyethylene",
            "Paper",
            "Cardboard",
            "Tray"});
            this.cbType.Location = new System.Drawing.Point(88, 13);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 6;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.onWrapperTypeChanged);
            // 
            // uCtrlWeight
            // 
            this.uCtrlWeight.Location = new System.Drawing.Point(6, 89);
            this.uCtrlWeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlWeight.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlWeight.Name = "uCtrlWeight";
            this.uCtrlWeight.Size = new System.Drawing.Size(180, 20);
            this.uCtrlWeight.TabIndex = 5;
            this.uCtrlWeight.Text = "Weight";
            this.uCtrlWeight.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_MASS;
            this.uCtrlWeight.Value = 0D;
            this.uCtrlWeight.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlDouble.onValueChanged(this.onPackChanged);
            // 
            // uCtrlThickness
            // 
            this.uCtrlThickness.Location = new System.Drawing.Point(6, 64);
            this.uCtrlThickness.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uCtrlThickness.MinimumSize = new System.Drawing.Size(100, 20);
            this.uCtrlThickness.Name = "uCtrlThickness";
            this.uCtrlThickness.Size = new System.Drawing.Size(180, 20);
            this.uCtrlThickness.TabIndex = 4;
            this.uCtrlThickness.Text = "Thickness";
            this.uCtrlThickness.Unit = TreeDim.StackBuilder.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlThickness.Value = 0D;
            this.uCtrlThickness.ValueChanged += new TreeDim.StackBuilder.Basics.UCtrlDouble.onValueChanged(this.onPackChanged);
            // 
            // lbWrapperColor
            // 
            this.lbWrapperColor.AutoSize = true;
            this.lbWrapperColor.Location = new System.Drawing.Point(6, 41);
            this.lbWrapperColor.Name = "lbWrapperColor";
            this.lbWrapperColor.Size = new System.Drawing.Size(31, 13);
            this.lbWrapperColor.TabIndex = 1;
            this.lbWrapperColor.Text = "Color";
            // 
            // cbColor
            // 
            this.cbColor.Color = System.Drawing.Color.LightGray;
            this.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbColor.DropDownHeight = 1;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.DropDownWidth = 1;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.IntegralHeight = false;
            this.cbColor.ItemHeight = 16;
            this.cbColor.Items.AddRange(new object[] {
            "Color",
            "Color",
            "Color"});
            this.cbColor.Location = new System.Drawing.Point(88, 38);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(61, 22);
            this.cbColor.TabIndex = 0;
            this.cbColor.SelectedColorChanged += new System.EventHandler(this.onPackChanged);
            // 
            // FormNewPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uCtrlLayout);
            this.Controls.Add(this.uCtrlOuterDimensions);
            this.Controls.Add(this.cbDir);
            this.Controls.Add(this.lbDir);
            this.Controls.Add(this.cbInnerBox);
            this.Controls.Add(this.lbBox);
            this.Controls.Add(this.graphCtrl);
            this.Name = "FormNewPack";
            this.Text = "Create new pack...";
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