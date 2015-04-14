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
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrl)).BeginInit();
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
            // FormNewPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
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
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrl)).EndInit();
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
    }
}