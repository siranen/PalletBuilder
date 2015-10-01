namespace treeDiM.StackBuilder.Basics
{
    partial class UCtrlOptDouble
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
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.lbUnit = new System.Windows.Forms.Label();
            this.chkbOpt = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // nudValue
            // 
            this.nudValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudValue.DecimalPlaces = 2;
            this.nudValue.Location = new System.Drawing.Point(201, 0);
            this.nudValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudValue.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(60, 20);
            this.nudValue.TabIndex = 0;
            this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // lbUnit
            // 
            this.lbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(268, 4);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(24, 13);
            this.lbUnit.TabIndex = 2;
            this.lbUnit.Text = "unit";
            // 
            // chkbOpt
            // 
            this.chkbOpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbOpt.AutoSize = true;
            this.chkbOpt.Location = new System.Drawing.Point(0, 2);
            this.chkbOpt.Name = "chkbOpt";
            this.chkbOpt.Size = new System.Drawing.Size(94, 17);
            this.chkbOpt.TabIndex = 3;
            this.chkbOpt.Text = "Optional value";
            this.chkbOpt.UseVisualStyleBackColor = true;
            this.chkbOpt.CheckedChanged += new System.EventHandler(this.chkbOpt_CheckedChanged);
            // 
            // UCtrlOptDouble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkbOpt);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.nudValue);
            this.MinimumSize = new System.Drawing.Size(100, 20);
            this.Name = "UCtrlOptDouble";
            this.Size = new System.Drawing.Size(301, 20);
            this.SizeChanged += new System.EventHandler(this.OptValueControl_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.CheckBox chkbOpt;
    }
}
