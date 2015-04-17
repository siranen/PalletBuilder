namespace TreeDim.StackBuilder.Desktop
{
    partial class DockContentPackPalletAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockContentPackPalletAnalysis));
            this.splitContainerHoriz = new System.Windows.Forms.SplitContainer();
            this.graphCtrlSolution = new TreeDim.StackBuilder.Graphics.Graphics3DControl();
            this.gridSolutions = new SourceGrid.Grid();
            this.btSelectSolution = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHoriz)).BeginInit();
            this.splitContainerHoriz.Panel1.SuspendLayout();
            this.splitContainerHoriz.Panel2.SuspendLayout();
            this.splitContainerHoriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerHoriz
            // 
            this.splitContainerHoriz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHoriz.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHoriz.Name = "splitContainerHoriz";
            this.splitContainerHoriz.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHoriz.Panel1
            // 
            this.splitContainerHoriz.Panel1.Controls.Add(this.graphCtrlSolution);
            this.splitContainerHoriz.Panel1.Controls.Add(this.btSelectSolution);
            // 
            // splitContainerHoriz.Panel2
            // 
            this.splitContainerHoriz.Panel2.Controls.Add(this.gridSolutions);
            this.splitContainerHoriz.Size = new System.Drawing.Size(604, 652);
            this.splitContainerHoriz.SplitterDistance = 450;
            this.splitContainerHoriz.TabIndex = 0;
            // 
            // graphCtrlSolution
            // 
            this.graphCtrlSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphCtrlSolution.Location = new System.Drawing.Point(0, 0);
            this.graphCtrlSolution.Name = "graphCtrlSolution";
            this.graphCtrlSolution.Size = new System.Drawing.Size(604, 416);
            this.graphCtrlSolution.TabIndex = 0;
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
            this.gridSolutions.Size = new System.Drawing.Size(604, 198);
            this.gridSolutions.SpecialKeys = SourceGrid.GridSpecialKeys.Arrows;
            this.gridSolutions.TabIndex = 0;
            this.gridSolutions.TabStop = true;
            this.gridSolutions.ToolTipText = "";
            // 
            // btSelectSolution
            // 
            this.btSelectSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectSolution.Location = new System.Drawing.Point(501, 422);
            this.btSelectSolution.Name = "btSelectSolution";
            this.btSelectSolution.Size = new System.Drawing.Size(100, 23);
            this.btSelectSolution.TabIndex = 0;
            this.btSelectSolution.Text = "Select";
            this.btSelectSolution.UseVisualStyleBackColor = true;
            // 
            // DockContentPackPalletAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 652);
            this.Controls.Add(this.splitContainerHoriz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DockContentPackPalletAnalysis";
            this.ShowInTaskbar = false;
            this.Text = "Pack/Pallet analysis...";
            this.splitContainerHoriz.Panel1.ResumeLayout(false);
            this.splitContainerHoriz.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHoriz)).EndInit();
            this.splitContainerHoriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlSolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Graphics.Graphics3DControl graphCtrlSolution;
        private SourceGrid.Grid gridSolutions;
        private System.Windows.Forms.Button btSelectSolution;
        private System.Windows.Forms.SplitContainer splitContainerHoriz;
    }
}