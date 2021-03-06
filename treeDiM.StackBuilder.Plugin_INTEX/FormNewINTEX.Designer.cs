﻿namespace treeDiM.StackBuilder.Plugin
{
    partial class FormNewINTEX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewINTEX));
            this.bnOK = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.lbRefDescription = new System.Windows.Forms.Label();
            this.cbRefDescription = new System.Windows.Forms.ComboBox();
            this.lbLength = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.lbWidth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.lbHeight = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lbUPC = new System.Windows.Forms.Label();
            this.lbGenCode = new System.Windows.Forms.Label();
            this.tbUPC = new System.Windows.Forms.TextBox();
            this.tbGenCode = new System.Windows.Forms.TextBox();
            this.lbPallet = new System.Windows.Forms.Label();
            this.cbPallet = new System.Windows.Forms.ComboBox();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.fileSelectCtrl = new treeDiM.UserControls.FileSelect();
            this.uLengthX = new System.Windows.Forms.Label();
            this.uLengthY = new System.Windows.Forms.Label();
            this.uLengthZ = new System.Windows.Forms.Label();
            this.uMassCase = new System.Windows.Forms.Label();
            this.lbPalletHeight = new System.Windows.Forms.Label();
            this.nudPalletHeight = new System.Windows.Forms.NumericUpDown();
            this.uLengthPalletHeight = new System.Windows.Forms.Label();
            this.lbCase = new System.Windows.Forms.Label();
            this.cbCases = new System.Windows.Forms.ComboBox();
            this.chkUseIntermediatePacking = new System.Windows.Forms.CheckBox();
            this.lbThickness = new System.Windows.Forms.Label();
            this.nudThickness = new System.Windows.Forms.NumericUpDown();
            this.uLengthThickness = new System.Windows.Forms.Label();
            this.statusStripDef = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDef = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalletHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).BeginInit();
            this.statusStripDef.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnOK
            // 
            resources.ApplyResources(this.bnOK, "bnOK");
            this.bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnOK.Name = "bnOK";
            this.bnOK.UseVisualStyleBackColor = true;
            // 
            // bnCancel
            // 
            resources.ApplyResources(this.bnCancel, "bnCancel");
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // lbRefDescription
            // 
            resources.ApplyResources(this.lbRefDescription, "lbRefDescription");
            this.lbRefDescription.Name = "lbRefDescription";
            // 
            // cbRefDescription
            // 
            resources.ApplyResources(this.cbRefDescription, "cbRefDescription");
            this.cbRefDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRefDescription.FormattingEnabled = true;
            this.cbRefDescription.Name = "cbRefDescription";
            this.cbRefDescription.SelectedIndexChanged += new System.EventHandler(this.cbRefDescription_SelectedIndexChanged);
            // 
            // lbLength
            // 
            resources.ApplyResources(this.lbLength, "lbLength");
            this.lbLength.Name = "lbLength";
            // 
            // tbLength
            // 
            resources.ApplyResources(this.tbLength, "tbLength");
            this.tbLength.Name = "tbLength";
            this.tbLength.ReadOnly = true;
            // 
            // lbWidth
            // 
            resources.ApplyResources(this.lbWidth, "lbWidth");
            this.lbWidth.Name = "lbWidth";
            // 
            // tbWidth
            // 
            resources.ApplyResources(this.tbWidth, "tbWidth");
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.ReadOnly = true;
            // 
            // lbHeight
            // 
            resources.ApplyResources(this.lbHeight, "lbHeight");
            this.lbHeight.Name = "lbHeight";
            // 
            // tbHeight
            // 
            resources.ApplyResources(this.tbHeight, "tbHeight");
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.ReadOnly = true;
            // 
            // lbWeight
            // 
            resources.ApplyResources(this.lbWeight, "lbWeight");
            this.lbWeight.Name = "lbWeight";
            // 
            // tbWeight
            // 
            resources.ApplyResources(this.tbWeight, "tbWeight");
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.ReadOnly = true;
            // 
            // lbUPC
            // 
            resources.ApplyResources(this.lbUPC, "lbUPC");
            this.lbUPC.Name = "lbUPC";
            // 
            // lbGenCode
            // 
            resources.ApplyResources(this.lbGenCode, "lbGenCode");
            this.lbGenCode.Name = "lbGenCode";
            // 
            // tbUPC
            // 
            resources.ApplyResources(this.tbUPC, "tbUPC");
            this.tbUPC.Name = "tbUPC";
            this.tbUPC.ReadOnly = true;
            // 
            // tbGenCode
            // 
            resources.ApplyResources(this.tbGenCode, "tbGenCode");
            this.tbGenCode.Name = "tbGenCode";
            this.tbGenCode.ReadOnly = true;
            // 
            // lbPallet
            // 
            resources.ApplyResources(this.lbPallet, "lbPallet");
            this.lbPallet.Name = "lbPallet";
            // 
            // cbPallet
            // 
            resources.ApplyResources(this.cbPallet, "cbPallet");
            this.cbPallet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPallet.FormattingEnabled = true;
            this.cbPallet.Name = "cbPallet";
            this.cbPallet.SelectedIndexChanged += new System.EventHandler(this.cbPallet_SelectedIndexChanged);
            // 
            // lbFilePath
            // 
            resources.ApplyResources(this.lbFilePath, "lbFilePath");
            this.lbFilePath.Name = "lbFilePath";
            // 
            // fileSelectCtrl
            // 
            resources.ApplyResources(this.fileSelectCtrl, "fileSelectCtrl");
            this.fileSelectCtrl.Filter = "StackBuilder (*.stb) |*.stb";
            this.fileSelectCtrl.Name = "fileSelectCtrl";
            this.fileSelectCtrl.SaveMode = true;
            // 
            // uLengthX
            // 
            resources.ApplyResources(this.uLengthX, "uLengthX");
            this.uLengthX.Name = "uLengthX";
            // 
            // uLengthY
            // 
            resources.ApplyResources(this.uLengthY, "uLengthY");
            this.uLengthY.Name = "uLengthY";
            // 
            // uLengthZ
            // 
            resources.ApplyResources(this.uLengthZ, "uLengthZ");
            this.uLengthZ.Name = "uLengthZ";
            // 
            // uMassCase
            // 
            resources.ApplyResources(this.uMassCase, "uMassCase");
            this.uMassCase.Name = "uMassCase";
            // 
            // lbPalletHeight
            // 
            resources.ApplyResources(this.lbPalletHeight, "lbPalletHeight");
            this.lbPalletHeight.Name = "lbPalletHeight";
            // 
            // nudPalletHeight
            // 
            resources.ApplyResources(this.nudPalletHeight, "nudPalletHeight");
            this.nudPalletHeight.DecimalPlaces = 1;
            this.nudPalletHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPalletHeight.Name = "nudPalletHeight";
            // 
            // uLengthPalletHeight
            // 
            resources.ApplyResources(this.uLengthPalletHeight, "uLengthPalletHeight");
            this.uLengthPalletHeight.Name = "uLengthPalletHeight";
            // 
            // lbCase
            // 
            resources.ApplyResources(this.lbCase, "lbCase");
            this.lbCase.Name = "lbCase";
            // 
            // cbCases
            // 
            resources.ApplyResources(this.cbCases, "cbCases");
            this.cbCases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCases.FormattingEnabled = true;
            this.cbCases.Name = "cbCases";
            this.cbCases.SelectedIndexChanged += new System.EventHandler(this.cbCases_SelectedIndexChanged);
            // 
            // chkUseIntermediatePacking
            // 
            resources.ApplyResources(this.chkUseIntermediatePacking, "chkUseIntermediatePacking");
            this.chkUseIntermediatePacking.Name = "chkUseIntermediatePacking";
            this.chkUseIntermediatePacking.UseVisualStyleBackColor = true;
            this.chkUseIntermediatePacking.CheckedChanged += new System.EventHandler(this.chkUseIntermediatePacking_CheckedChanged);
            // 
            // lbThickness
            // 
            resources.ApplyResources(this.lbThickness, "lbThickness");
            this.lbThickness.Name = "lbThickness";
            // 
            // nudThickness
            // 
            resources.ApplyResources(this.nudThickness, "nudThickness");
            this.nudThickness.DecimalPlaces = 2;
            this.nudThickness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudThickness.Name = "nudThickness";
            // 
            // uLengthThickness
            // 
            resources.ApplyResources(this.uLengthThickness, "uLengthThickness");
            this.uLengthThickness.Name = "uLengthThickness";
            // 
            // statusStripDef
            // 
            resources.ApplyResources(this.statusStripDef, "statusStripDef");
            this.statusStripDef.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDef});
            this.statusStripDef.Name = "statusStripDef";
            this.statusStripDef.SizingGrip = false;
            // 
            // toolStripStatusLabelDef
            // 
            resources.ApplyResources(this.toolStripStatusLabelDef, "toolStripStatusLabelDef");
            this.toolStripStatusLabelDef.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelDef.Name = "toolStripStatusLabelDef";
            // 
            // FormNewINTEX
            // 
            this.AcceptButton = this.bnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnCancel;
            this.Controls.Add(this.statusStripDef);
            this.Controls.Add(this.uLengthThickness);
            this.Controls.Add(this.nudThickness);
            this.Controls.Add(this.lbThickness);
            this.Controls.Add(this.chkUseIntermediatePacking);
            this.Controls.Add(this.cbCases);
            this.Controls.Add(this.lbCase);
            this.Controls.Add(this.uLengthPalletHeight);
            this.Controls.Add(this.nudPalletHeight);
            this.Controls.Add(this.lbPalletHeight);
            this.Controls.Add(this.uMassCase);
            this.Controls.Add(this.uLengthZ);
            this.Controls.Add(this.uLengthY);
            this.Controls.Add(this.uLengthX);
            this.Controls.Add(this.fileSelectCtrl);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.cbPallet);
            this.Controls.Add(this.lbPallet);
            this.Controls.Add(this.tbGenCode);
            this.Controls.Add(this.tbUPC);
            this.Controls.Add(this.lbGenCode);
            this.Controls.Add(this.lbUPC);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.lbWidth);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.cbRefDescription);
            this.Controls.Add(this.lbRefDescription);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewINTEX";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewINTEX_FormClosing);
            this.Load += new System.EventHandler(this.FormNewINTEX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPalletHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).EndInit();
            this.statusStripDef.ResumeLayout(false);
            this.statusStripDef.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnOK;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Label lbRefDescription;
        private System.Windows.Forms.ComboBox cbRefDescription;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lbUPC;
        private System.Windows.Forms.Label lbGenCode;
        private System.Windows.Forms.TextBox tbUPC;
        private System.Windows.Forms.TextBox tbGenCode;
        private System.Windows.Forms.Label lbPallet;
        private System.Windows.Forms.ComboBox cbPallet;
        private System.Windows.Forms.Label lbFilePath;
        private treeDiM.UserControls.FileSelect fileSelectCtrl;
        private System.Windows.Forms.Label uLengthX;
        private System.Windows.Forms.Label uLengthY;
        private System.Windows.Forms.Label uLengthZ;
        private System.Windows.Forms.Label uMassCase;
        private System.Windows.Forms.Label lbPalletHeight;
        private System.Windows.Forms.NumericUpDown nudPalletHeight;
        private System.Windows.Forms.Label uLengthPalletHeight;
        private System.Windows.Forms.Label lbCase;
        private System.Windows.Forms.ComboBox cbCases;
        private System.Windows.Forms.CheckBox chkUseIntermediatePacking;
        private System.Windows.Forms.Label lbThickness;
        private System.Windows.Forms.NumericUpDown nudThickness;
        private System.Windows.Forms.Label uLengthThickness;
        private System.Windows.Forms.StatusStrip statusStripDef;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDef;
    }
}