#region using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using treeDiM.StackBuilder.ExcelReader;

using ListBoxWithToolTip;
#endregion

namespace TreeDim.StackBuilder.Desktop
{
    public partial class FormExcelLibrary : Form
    {
        #region Constructor
        public FormExcelLibrary(DocumentSB doc)
        {
            InitializeComponent();
        }
        #endregion

        #region Load / close
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // 
            Reload(this, null);
        }
        #endregion

        #region Helpers
        private void ReFillControls()
        {
            tabControlLibrary.SelectedIndex = 0;           
        }
        #endregion

        #region Event handlers
        private void Reload(object sender, EventArgs e)
        {
            string filePath = excelFileSelect.FileName;
            if (treeDiM.StackBuilder.ExcelReader.ExcelDataReader.LoadFile(filePath, ref _listTypes))
                ReFillControls();
        }
        #endregion

        #region Data members
        private List<DataType> _listTypes;
        #endregion

        private void onTabPageSelected(object sender, TabControlEventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (DataType dt in _listTypes)
            {
                listBoxItem.Items.Add(new ListBoxItem(dt));
            }
        }
    }

    internal class ListBoxItem : IToolTipDisplayer
    {
        public string DisplayText { get; private set; }
        public string ToolTipText { get; private set; }

        // Constructor
        public ListBoxItem(string displayText, string toolTipText)
        {
            DisplayText = displayText;
            ToolTipText = toolTipText;
        }
        public ListBoxItem(DataType dt)
        { 
            DisplayText = dt.Name;
            ToolTipText = dt.Description;        
        }

        // Returns the display text of this item.
        public override string ToString()
        {
            return DisplayText;
        }
        // Returns the tooltip text of this item.
        public string GetToolTipText()
        {
            return ToolTipText;
        }
    }
}
