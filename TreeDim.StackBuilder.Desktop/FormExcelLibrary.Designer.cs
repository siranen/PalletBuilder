namespace TreeDim.StackBuilder.Desktop
{
    partial class FormExcelLibrary
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
            this.lbPathExcelLibrary = new System.Windows.Forms.Label();
            this.bnInsert = new System.Windows.Forms.Button();
            this.bnClose = new System.Windows.Forms.Button();
            this.bnReload = new System.Windows.Forms.Button();
            this.excelFileSelect = new TreeDim.UserControls.FileSelect();
            this.tabControlLibrary = new System.Windows.Forms.TabControl();
            this.tabPageCases = new System.Windows.Forms.TabPage();
            this.tabPageBoxes = new System.Windows.Forms.TabPage();
            this.tabPagePallets = new System.Windows.Forms.TabPage();
            this.tabPageInterlayers = new System.Windows.Forms.TabPage();
            this.tabPageCylinders = new System.Windows.Forms.TabPage();
            this.tabPagePalletCaps = new System.Windows.Forms.TabPage();
            this.tabPagePalletWrappers = new System.Windows.Forms.TabPage();
            this.listBoxItem = new ListBoxWithToolTip.ToolTipListBox();
            this.graphControlItem = new TreeDim.StackBuilder.Graphics.Graphics3DControl();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.tabControlLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPathExcelLibrary
            // 
            this.lbPathExcelLibrary.AutoSize = true;
            this.lbPathExcelLibrary.Location = new System.Drawing.Point(4, 42);
            this.lbPathExcelLibrary.Name = "lbPathExcelLibrary";
            this.lbPathExcelLibrary.Size = new System.Drawing.Size(87, 13);
            this.lbPathExcelLibrary.TabIndex = 0;
            this.lbPathExcelLibrary.Text = "Excel library path";
            // 
            // bnInsert
            // 
            this.bnInsert.Location = new System.Drawing.Point(468, 66);
            this.bnInsert.Name = "bnInsert";
            this.bnInsert.Size = new System.Drawing.Size(75, 23);
            this.bnInsert.TabIndex = 1;
            this.bnInsert.Text = "Insert";
            this.bnInsert.UseVisualStyleBackColor = true;
            // 
            // bnClose
            // 
            this.bnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnClose.Location = new System.Drawing.Point(468, 8);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(75, 23);
            this.bnClose.TabIndex = 2;
            this.bnClose.Text = "Close";
            this.bnClose.UseVisualStyleBackColor = true;
            // 
            // bnReload
            // 
            this.bnReload.Location = new System.Drawing.Point(468, 37);
            this.bnReload.Name = "bnReload";
            this.bnReload.Size = new System.Drawing.Size(75, 23);
            this.bnReload.TabIndex = 3;
            this.bnReload.Text = "Reload";
            this.bnReload.UseVisualStyleBackColor = true;
            this.bnReload.Click += new System.EventHandler(this.Reload);
            // 
            // excelFileSelect
            // 
            this.excelFileSelect.Location = new System.Drawing.Point(98, 37);
            this.excelFileSelect.Name = "excelFileSelect";
            this.excelFileSelect.Size = new System.Drawing.Size(364, 20);
            this.excelFileSelect.TabIndex = 4;
            this.excelFileSelect.FileNameChanged += new System.EventHandler(this.Reload);
            // 
            // tabControlLibrary
            // 
            this.tabControlLibrary.Controls.Add(this.tabPageBoxes);
            this.tabControlLibrary.Controls.Add(this.tabPagePallets);
            this.tabControlLibrary.Controls.Add(this.tabPageInterlayers);
            this.tabControlLibrary.Controls.Add(this.tabPageCylinders);
            this.tabControlLibrary.Controls.Add(this.tabPagePalletCaps);
            this.tabControlLibrary.Controls.Add(this.tabPagePalletWrappers);
            this.tabControlLibrary.Controls.Add(this.tabPageCases);
            this.tabControlLibrary.Location = new System.Drawing.Point(7, 95);
            this.tabControlLibrary.Name = "tabControlLibrary";
            this.tabControlLibrary.SelectedIndex = 0;
            this.tabControlLibrary.Size = new System.Drawing.Size(536, 303);
            this.tabControlLibrary.TabIndex = 5;
            this.tabControlLibrary.Selected += new System.Windows.Forms.TabControlEventHandler(this.onTabPageSelected);
            // 
            // tabPageCases
            // 
            this.tabPageCases.Location = new System.Drawing.Point(4, 22);
            this.tabPageCases.Name = "tabPageCases";
            this.tabPageCases.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCases.Size = new System.Drawing.Size(528, 277);
            this.tabPageCases.TabIndex = 0;
            this.tabPageCases.Text = "Cases";
            this.tabPageCases.UseVisualStyleBackColor = true;
            // 
            // tabPageBoxes
            // 
            this.tabPageBoxes.Location = new System.Drawing.Point(4, 22);
            this.tabPageBoxes.Name = "tabPageBoxes";
            this.tabPageBoxes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBoxes.Size = new System.Drawing.Size(528, 267);
            this.tabPageBoxes.TabIndex = 1;
            this.tabPageBoxes.Text = "Boxes";
            this.tabPageBoxes.UseVisualStyleBackColor = true;
            // 
            // tabPagePallets
            // 
            this.tabPagePallets.Location = new System.Drawing.Point(4, 22);
            this.tabPagePallets.Name = "tabPagePallets";
            this.tabPagePallets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePallets.Size = new System.Drawing.Size(528, 267);
            this.tabPagePallets.TabIndex = 2;
            this.tabPagePallets.Text = "Pallets";
            this.tabPagePallets.UseVisualStyleBackColor = true;
            // 
            // tabPageInterlayers
            // 
            this.tabPageInterlayers.Location = new System.Drawing.Point(4, 22);
            this.tabPageInterlayers.Name = "tabPageInterlayers";
            this.tabPageInterlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInterlayers.Size = new System.Drawing.Size(528, 267);
            this.tabPageInterlayers.TabIndex = 3;
            this.tabPageInterlayers.Text = "Interlayers";
            this.tabPageInterlayers.UseVisualStyleBackColor = true;
            // 
            // tabPageCylinders
            // 
            this.tabPageCylinders.Location = new System.Drawing.Point(4, 22);
            this.tabPageCylinders.Name = "tabPageCylinders";
            this.tabPageCylinders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCylinders.Size = new System.Drawing.Size(528, 267);
            this.tabPageCylinders.TabIndex = 4;
            this.tabPageCylinders.Text = "Cylinders";
            this.tabPageCylinders.UseVisualStyleBackColor = true;
            // 
            // tabPagePalletCaps
            // 
            this.tabPagePalletCaps.Location = new System.Drawing.Point(4, 22);
            this.tabPagePalletCaps.Name = "tabPagePalletCaps";
            this.tabPagePalletCaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePalletCaps.Size = new System.Drawing.Size(528, 267);
            this.tabPagePalletCaps.TabIndex = 5;
            this.tabPagePalletCaps.Text = "Pallet caps";
            this.tabPagePalletCaps.UseVisualStyleBackColor = true;
            // 
            // tabPagePalletWrappers
            // 
            this.tabPagePalletWrappers.Location = new System.Drawing.Point(4, 22);
            this.tabPagePalletWrappers.Name = "tabPagePalletWrappers";
            this.tabPagePalletWrappers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePalletWrappers.Size = new System.Drawing.Size(528, 267);
            this.tabPagePalletWrappers.TabIndex = 6;
            this.tabPagePalletWrappers.Text = "Pallet wrappers";
            this.tabPagePalletWrappers.UseVisualStyleBackColor = true;
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.Location = new System.Drawing.Point(15, 126);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(158, 251);
            this.listBoxItem.TabIndex = 0;
            // 
            // graphControlItem
            // 
            this.graphControlItem.Location = new System.Drawing.Point(181, 126);
            this.graphControlItem.Name = "graphControlItem";
            this.graphControlItem.Size = new System.Drawing.Size(150, 251);
            this.graphControlItem.TabIndex = 1;
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(337, 126);
            this.tbItem.Multiline = true;
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(193, 251);
            this.tbItem.TabIndex = 2;
            // 
            // FormExcelLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnClose;
            this.ClientSize = new System.Drawing.Size(555, 400);
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.graphControlItem);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.tabControlLibrary);
            this.Controls.Add(this.excelFileSelect);
            this.Controls.Add(this.bnReload);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.bnInsert);
            this.Controls.Add(this.lbPathExcelLibrary);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExcelLibrary";
            this.ShowIcon = false;
            this.Text = "Add items from library...";
            this.tabControlLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphControlItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPathExcelLibrary;
        private System.Windows.Forms.Button bnInsert;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.Button bnReload;
        private UserControls.FileSelect excelFileSelect;
        private System.Windows.Forms.TabControl tabControlLibrary;
        private System.Windows.Forms.TabPage tabPageCases;
        private System.Windows.Forms.TabPage tabPageBoxes;
        private System.Windows.Forms.TabPage tabPagePallets;
        private System.Windows.Forms.TabPage tabPageInterlayers;
        private System.Windows.Forms.TabPage tabPageCylinders;
        private System.Windows.Forms.TabPage tabPagePalletCaps;
        private System.Windows.Forms.TabPage tabPagePalletWrappers;
        private ListBoxWithToolTip.ToolTipListBox listBoxItem;
        private System.Windows.Forms.TextBox tbItem;
        private Graphics.Graphics3DControl graphControlItem;
    }
}