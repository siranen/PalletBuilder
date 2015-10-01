namespace treeDiM.StackBuilder.Desktop
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
            this.excelFileSelect = new treeDiM.UserControls.FileSelect();
            this.tabControlLibrary = new System.Windows.Forms.TabControl();
            this.listBoxItem = new ListBoxWithToolTip.ToolTipListBox();
            this.graphCtrl = new treeDiM.StackBuilder.Graphics.Graphics3DControl();
            this.tbItem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrl)).BeginInit();
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
            this.bnInsert.Click += new System.EventHandler(this.bnInsert_Click);
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
            this.excelFileSelect.Filter = "MS Excel work sheet (*.xls;*.xlsx)|*.xls;*.xlsx";
            this.excelFileSelect.Location = new System.Drawing.Point(98, 37);
            this.excelFileSelect.Name = "excelFileSelect";
            this.excelFileSelect.Size = new System.Drawing.Size(364, 20);
            this.excelFileSelect.TabIndex = 4;
            this.excelFileSelect.FileNameChanged += new System.EventHandler(this.Reload);
            // 
            // tabControlLibrary
            // 
            this.tabControlLibrary.Location = new System.Drawing.Point(7, 95);
            this.tabControlLibrary.Name = "tabControlLibrary";
            this.tabControlLibrary.SelectedIndex = 0;
            this.tabControlLibrary.Size = new System.Drawing.Size(536, 303);
            this.tabControlLibrary.TabIndex = 5;
            this.tabControlLibrary.Selected += new System.Windows.Forms.TabControlEventHandler(this.onTabPageSelected);
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.Location = new System.Drawing.Point(15, 126);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(158, 251);
            this.listBoxItem.TabIndex = 0;
            this.listBoxItem.SelectedIndexChanged += new System.EventHandler(this.listBoxItem_SelectedIndexChanged);
            this.listBoxItem.DoubleClick += new System.EventHandler(this.listBoxItem_DoubleClick);
            // 
            // graphCtrl
            // 
            this.graphCtrl.Location = new System.Drawing.Point(181, 126);
            this.graphCtrl.Name = "graphCtrl";
            this.graphCtrl.Size = new System.Drawing.Size(349, 157);
            this.graphCtrl.TabIndex = 1;
            // 
            // tbItem
            // 
            this.tbItem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItem.Location = new System.Drawing.Point(179, 289);
            this.tbItem.Multiline = true;
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(351, 88);
            this.tbItem.TabIndex = 2;
            // 
            // FormExcelLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnClose;
            this.ClientSize = new System.Drawing.Size(555, 400);
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.graphCtrl);
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
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrl)).EndInit();
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
        private ListBoxWithToolTip.ToolTipListBox listBoxItem;
        private System.Windows.Forms.TextBox tbItem;
        private Graphics.Graphics3DControl graphCtrl;
    }
}