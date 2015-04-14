namespace TreeDim.StackBuilder.Basics
{
    partial class UCtrlOptTriDouble
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkbOpt = new System.Windows.Forms.CheckBox();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudZ = new System.Windows.Forms.NumericUpDown();
            this.lbUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).BeginInit();
            this.SuspendLayout();
            // 
            // chkbOpt
            // 
            this.chkbOpt.AutoSize = true;
            this.chkbOpt.Location = new System.Drawing.Point(0, 2);
            this.chkbOpt.Name = "chkbOpt";
            this.chkbOpt.Size = new System.Drawing.Size(115, 17);
            this.chkbOpt.TabIndex = 0;
            this.chkbOpt.Text = "Optional dimension";
            this.chkbOpt.UseVisualStyleBackColor = true;
            this.chkbOpt.CheckedChanged += new System.EventHandler(this.chkbOpt_CheckedChanged);
            // 
            // nudX
            // 
            this.nudX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudX.DecimalPlaces = 2;
            this.nudX.Location = new System.Drawing.Point(171, 0);
            this.nudX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(60, 20);
            this.nudX.TabIndex = 1;
            this.nudX.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // nudY
            // 
            this.nudY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudY.DecimalPlaces = 2;
            this.nudY.Location = new System.Drawing.Point(234, 0);
            this.nudY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(60, 20);
            this.nudY.TabIndex = 2;
            this.nudY.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // nudZ
            // 
            this.nudZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudZ.DecimalPlaces = 2;
            this.nudZ.Location = new System.Drawing.Point(297, 0);
            this.nudZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudZ.Name = "nudZ";
            this.nudZ.Size = new System.Drawing.Size(60, 20);
            this.nudZ.TabIndex = 3;
            this.nudZ.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // lbUnit
            // 
            this.lbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(364, 3);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(24, 13);
            this.lbUnit.TabIndex = 4;
            this.lbUnit.Text = "unit";
            // 
            // UCtrlOptTriDouble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.nudZ);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.chkbOpt);
            this.Name = "UCtrlOptTriDouble";
            this.Size = new System.Drawing.Size(400, 20);
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbOpt;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudZ;
        private System.Windows.Forms.Label lbUnit;
    }
}
