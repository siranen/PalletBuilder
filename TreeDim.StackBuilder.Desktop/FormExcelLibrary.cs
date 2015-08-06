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

using TreeDim.StackBuilder.Basics;
using TreeDim.StackBuilder.Graphics;

using ListBoxWithToolTip;
#endregion

namespace TreeDim.StackBuilder.Desktop
{
    public partial class FormExcelLibrary : Form, IDrawingContainer
    {
        #region Constructor
        public FormExcelLibrary(DocumentSB doc)
        {
            InitializeComponent();
            _document = doc;
            // initialize dictionnary Type <-> Tab page index
            _dictIndexType[0] = typeof(DataCase);
            _dictIndexType[1] = typeof(DataBox);
            _dictIndexType[2] = typeof(DataCylinder);
            _dictIndexType[3] = typeof(DataPallet);
            _dictIndexType[4] = typeof(DataInterlayer);
            _dictIndexType[5] = typeof(DataPalletCap);
            _dictIndexType[6] = typeof(DataPalletFilm);
        }
        #endregion

        #region Load / close
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // initialize graph control
            graphCtrl.DrawingContainer = this;
            // load path
            excelFileSelect.FileName = Properties.Settings.Default.ExcelLibraryPath;
            // load file
            Reload(this, null);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            // save file path
            Properties.Settings.Default.ExcelLibraryPath = excelFileSelect.FileName;
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
            onTabPageSelected(this, null);
        }
        private void onTabPageSelected(object sender, TabControlEventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (DataType dt in _listTypes)
            {
                if (_dictIndexType[tabControlLibrary.SelectedIndex] != dt.GetType()) continue;
                listBoxItem.Items.Add(new ListBoxItem(dt));
            }
            if (listBoxItem.Items.Count > 0)
                listBoxItem.SelectedIndex = 0;
        }

        private void listBoxItem_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void listBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxItem lbItem = listBoxItem.SelectedItem as ListBoxItem;
            _dt = lbItem.DataType;
            graphCtrl.Invalidate();

            tbItem.Text = _dt.ToString();
        }

        private void bnInsert_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Implement IDrawingContainer
        public void Draw(Graphics3DControl ctrl, Graphics3D graphics)
        {
            if (null == _dt)
                return;
            DataCase dtCase = _dt as DataCase;
            if (null != dtCase)
            {
                BoxProperties boxProperties = new BoxProperties(null
                    , dtCase.OuterDimensions[0], dtCase.OuterDimensions[1], dtCase.OuterDimensions[2]
                    , dtCase.InnerDimensions[0], dtCase.InnerDimensions[1], dtCase.InnerDimensions[2]);
                Color[] colors = new Color[6];
                for (int i = 0; i < 6; ++i) colors[i] = Color.Chocolate;
                boxProperties.SetAllColors(colors);
                boxProperties.ShowTape = true;
                boxProperties.TapeColor = Color.Beige;
                boxProperties.TapeWidth = UnitsManager.ConvertLengthFrom(50, UnitsManager.UnitSystem.UNIT_METRIC1);

                Box b = new Box(0, boxProperties);
                graphics.AddBox(b);
                graphics.AddDimensions(new DimensionCube(dtCase.OuterDimensions));
            }
            DataBox dtBox = _dt as DataBox;
            if (null != dtBox)
            { 
                BoxProperties boxProperties = new BoxProperties(null
                    , dtBox.Dimensions[0], dtBox.Dimensions[1], dtBox.Dimensions[2]);
                Color[] colors = new Color[6];
                for (int i = 0; i < 6; ++i) colors[i] = Color.Turquoise;
                boxProperties.SetAllColors(colors);
                boxProperties.ShowTape = false;

                Box b = new Box(0, boxProperties);
                graphics.AddBox(b);
                graphics.AddDimensions(new DimensionCube(dtBox.Dimensions));
            }
            DataPallet dtPallet = _dt as DataPallet;
            if (null != dtPallet)
            {
                PalletProperties palletProperties = new PalletProperties(null, dtPallet.TypeName
                    , dtPallet.Dimensions[0], dtPallet.Dimensions[1], dtPallet.Dimensions[2]
                    );
                Pallet pallet = new Pallet(palletProperties);
                pallet.Draw(graphics, Sharp3D.Math.Core.Transform3D.Identity);
                graphics.AddDimensions(new DimensionCube(dtPallet.Dimensions));
            
            }
            DataPalletCap dtPalletCap = _dt as DataPalletCap;
            if (null != dtPalletCap)
            { 
            
            }

            DataCylinder dtCylinder = _dt as DataCylinder;
            if (null != dtCylinder)
            {
                CylinderProperties cylProperties = new CylinderProperties(
                    null, dtCylinder.Name, dtCylinder.Description
                    , 0.5 * dtCylinder.Diameter, 0.5 * dtCylinder.InnerDiameter, dtCylinder.Height, dtCylinder.Weight
                    , Color.Gray, Color.LightSkyBlue, Color.Chocolate);
                Cylinder cyl = new Cylinder(0, cylProperties);
                graphics.AddCylinder(cyl);
            }
        }
        #endregion

        #region Data members
        private List<DataType> _listTypes;
        private Dictionary<int, Type> _dictIndexType = new Dictionary<int,Type>();
        private DataType _dt;
        private DocumentSB _document;
        #endregion
    }

    internal class ListBoxItem : IToolTipDisplayer
    {
        private DataType _dt;
        public ListBoxItem(DataType dt)
        { 
            _dt = dt;
        }
        public DataType DataType
        {
            get { return _dt; }
        }
        // Returns the display text of this item.
        public override string ToString()
        {
            return _dt.Name;
        }
        // Returns the tooltip text of this item.
        public string GetToolTipText()
        {
            return _dt.Description;
        }
    }
}
