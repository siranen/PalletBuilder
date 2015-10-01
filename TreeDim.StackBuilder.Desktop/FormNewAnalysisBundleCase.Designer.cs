namespace treeDiM.StackBuilder.Desktop
{
    partial class FormNewAnalysisBundleCase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewAnalysisBundleCase));
            this.lbBundle = new System.Windows.Forms.Label();
            this.lbCase = new System.Windows.Forms.Label();
            this.cbBundle = new System.Windows.Forms.ComboBox();
            this.cbCase = new System.Windows.Forms.ComboBox();
            this.gbStopStackingConditions = new System.Windows.Forms.GroupBox();
            this.lbStopStacking = new System.Windows.Forms.Label();
            this.uMassCase = new System.Windows.Forms.Label();
            this.nudMaximumCaseWeight = new System.Windows.Forms.NumericUpDown();
            this.nudMaximumNumberOfBoxes = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMaximumCaseWeight = new System.Windows.Forms.CheckBox();
            this.checkBoxMaximumNumberOfBoxes = new System.Windows.Forms.CheckBox();
            this.gbStopStackingConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumCaseWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumNumberOfBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBundle
            // 
            resources.ApplyResources(this.lbBundle, "lbBundle");
            this.lbBundle.Name = "lbBundle";
            // 
            // lbCase
            // 
            resources.ApplyResources(this.lbCase, "lbCase");
            this.lbCase.Name = "lbCase";
            // 
            // cbBundle
            // 
            resources.ApplyResources(this.cbBundle, "cbBundle");
            this.cbBundle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBundle.FormattingEnabled = true;
            this.cbBundle.Name = "cbBundle";
            // 
            // cbCase
            // 
            resources.ApplyResources(this.cbCase, "cbCase");
            this.cbCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCase.FormattingEnabled = true;
            this.cbCase.Name = "cbCase";
            // 
            // gbStopStackingConditions
            // 
            resources.ApplyResources(this.gbStopStackingConditions, "gbStopStackingConditions");
            this.gbStopStackingConditions.Controls.Add(this.lbStopStacking);
            this.gbStopStackingConditions.Controls.Add(this.uMassCase);
            this.gbStopStackingConditions.Controls.Add(this.nudMaximumCaseWeight);
            this.gbStopStackingConditions.Controls.Add(this.nudMaximumNumberOfBoxes);
            this.gbStopStackingConditions.Controls.Add(this.checkBoxMaximumCaseWeight);
            this.gbStopStackingConditions.Controls.Add(this.checkBoxMaximumNumberOfBoxes);
            this.gbStopStackingConditions.Name = "gbStopStackingConditions";
            this.gbStopStackingConditions.TabStop = false;
            // 
            // lbStopStacking
            // 
            resources.ApplyResources(this.lbStopStacking, "lbStopStacking");
            this.lbStopStacking.Name = "lbStopStacking";
            // 
            // uMassCase
            // 
            resources.ApplyResources(this.uMassCase, "uMassCase");
            this.uMassCase.Name = "uMassCase";
            // 
            // nudMaximumCaseWeight
            // 
            resources.ApplyResources(this.nudMaximumCaseWeight, "nudMaximumCaseWeight");
            this.nudMaximumCaseWeight.DecimalPlaces = 3;
            this.nudMaximumCaseWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaximumCaseWeight.Name = "nudMaximumCaseWeight";
            // 
            // nudMaximumNumberOfBoxes
            // 
            resources.ApplyResources(this.nudMaximumNumberOfBoxes, "nudMaximumNumberOfBoxes");
            this.nudMaximumNumberOfBoxes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaximumNumberOfBoxes.Name = "nudMaximumNumberOfBoxes";
            // 
            // checkBoxMaximumCaseWeight
            // 
            resources.ApplyResources(this.checkBoxMaximumCaseWeight, "checkBoxMaximumCaseWeight");
            this.checkBoxMaximumCaseWeight.Name = "checkBoxMaximumCaseWeight";
            this.checkBoxMaximumCaseWeight.UseVisualStyleBackColor = true;
            this.checkBoxMaximumCaseWeight.CheckedChanged += new System.EventHandler(this.checkBoxMaximumCaseWeight_CheckedChanged);
            // 
            // checkBoxMaximumNumberOfBoxes
            // 
            resources.ApplyResources(this.checkBoxMaximumNumberOfBoxes, "checkBoxMaximumNumberOfBoxes");
            this.checkBoxMaximumNumberOfBoxes.Name = "checkBoxMaximumNumberOfBoxes";
            this.checkBoxMaximumNumberOfBoxes.UseVisualStyleBackColor = true;
            this.checkBoxMaximumNumberOfBoxes.CheckedChanged += new System.EventHandler(this.checkBoxMaximumNumberOfBoxes_CheckedChanged);
            // 
            // FormNewAnalysisBundleCase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbStopStackingConditions);
            this.Controls.Add(this.cbCase);
            this.Controls.Add(this.cbBundle);
            this.Controls.Add(this.lbCase);
            this.Controls.Add(this.lbBundle);
            this.Name = "FormNewAnalysisBundleCase";
            this.Controls.SetChildIndex(this.lbBundle, 0);
            this.Controls.SetChildIndex(this.lbCase, 0);
            this.Controls.SetChildIndex(this.cbBundle, 0);
            this.Controls.SetChildIndex(this.cbCase, 0);
            this.Controls.SetChildIndex(this.gbStopStackingConditions, 0);
            this.gbStopStackingConditions.ResumeLayout(false);
            this.gbStopStackingConditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumCaseWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumNumberOfBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBundle;
        private System.Windows.Forms.Label lbCase;
        private System.Windows.Forms.ComboBox cbBundle;
        private System.Windows.Forms.ComboBox cbCase;
        private System.Windows.Forms.GroupBox gbStopStackingConditions;
        private System.Windows.Forms.Label uMassCase;
        private System.Windows.Forms.NumericUpDown nudMaximumCaseWeight;
        private System.Windows.Forms.NumericUpDown nudMaximumNumberOfBoxes;
        private System.Windows.Forms.CheckBox checkBoxMaximumCaseWeight;
        private System.Windows.Forms.CheckBox checkBoxMaximumNumberOfBoxes;
        private System.Windows.Forms.Label lbStopStacking;
    }
}