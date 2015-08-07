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
    #region FormExcelLibrary
    public partial class FormExcelLibrary : Form, IDrawingContainer
    {
        #region Constructor
        public FormExcelLibrary(DocumentSB doc)
        {
            InitializeComponent();
            // document
            _document = doc;
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

        #region Event handlers
        private void Reload(object sender, EventArgs e)
        {
            string filePath = excelFileSelect.FileName;
            if (treeDiM.StackBuilder.ExcelReader.ExcelDataReader.LoadFile(filePath, ref _listTypes)) { }

            if (_listTypes.Count > 0)
            {
                tabControlLibrary.Show();
                // is tabcontrol already initialized
                if (tabControlLibrary.TabPages.Count == 0)
                {
                    if (HasType(typeof(DataCase)))
                    { tabControlLibrary.TabPages.Add(Properties.Resources.ID_CASES); _classes.Add(typeof(DataCase)); }
                    if (HasType(typeof(DataBox)))
                    { tabControlLibrary.TabPages.Add(Properties.Resources.ID_BOXES); _classes.Add(typeof(DataBox)); }
                    if (HasType(typeof(DataCylinder)))
                    { tabControlLibrary.TabPages.Add(Properties.Resources.ID_CYLINDERS); _classes.Add(typeof(DataCylinder)); }
                    if (HasType(typeof(DataPallet)))
                    { tabControlLibrary.TabPages.Add(Properties.Resources.ID_PALLETS); _classes.Add(typeof(DataPallet)); }
                    if (HasType(typeof(DataInterlayer)))
                    { tabControlLibrary.TabPages.Add(Properties.Resources.ID_INTERLAYERS); _classes.Add(typeof(DataInterlayer)); }
                    if (HasType(typeof(DataPalletCap)))
                    { tabControlLibrary.TabPages.Add(Properties.Resources.ID_PALLETCAPS); _classes.Add(typeof(DataPalletCap)); }
                    if (HasType(typeof(DataPalletFilm)))
                    { tabControlLibrary.TabPages.Add(Properties.Resources.ID_PALLETFILMS); _classes.Add(typeof(DataPalletFilm)); }
                }
                tabControlLibrary.SelectedIndex = 0;
                onTabPageSelected(this, null);
            }
            else
                tabControlLibrary.Hide();
        }
        private void onTabPageSelected(object sender, TabControlEventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (DataType dt in _listTypes)
            {
                if (_classes[tabControlLibrary.SelectedIndex] != dt.GetType()) continue;
                listBoxItem.Items.Add(new ListBoxItem(dt));
            }
            if (listBoxItem.Items.Count > 0)
            {
                listBoxItem.SelectedIndex = 0;
                listBoxItem.Show(); graphCtrl.Show(); tbItem.Show();
            }
            else
            {
                _dt = null;
                listBoxItem.Hide(); graphCtrl.Hide(); tbItem.Hide();
            }
        }

        private void listBoxItem_DoubleClick(object sender, EventArgs e)
        {
            bnInsert_Click(this, null);
            Close();
        }

        private void listBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxItem lbItem = listBoxItem.SelectedItem as ListBoxItem;
            if (null != lbItem)
                _dt = lbItem.DataType;
            else
                _dt = null;
            // update image control
            if (null == _dt || _dt is DataPalletFilm)
                graphCtrl.Hide();
            else
                graphCtrl.Invalidate();
            // update text box
            tbItem.Text = _dt.ToString();
        }

        private void bnInsert_Click(object sender, EventArgs e)
        {
            if (null == _dt || null == _document) return;
            // Case
            DataCase dtCase = _dt as DataCase;
            if (null != dtCase)
                _document.CreateNewCase(ToCase(dtCase));

            DataBox dtBox = _dt as DataBox;
            if (null != dtBox)
                _document.CreateNewBox(ToBox(dtBox));

            DataCylinder dtCylinder = _dt as DataCylinder;
            if (null != dtCylinder)
                _document.CreateNewCylinder(ToCylinder(dtCylinder));

            DataPallet dtPallet = _dt as DataPallet;
            if (null != dtPallet)
                _document.CreateNewPallet(ToPallet(dtPallet));

            DataInterlayer dtInterlayer = _dt as DataInterlayer;
            if (null != dtInterlayer)
                _document.CreateNewInterlayer(ToInterlayer(dtInterlayer));

            DataPalletCap dtPalletCap = _dt as DataPalletCap;
            if (null != dtPalletCap)
                _document.CreateNewPalletCap(ToPalletCap(dtPalletCap));

            DataPalletFilm dtPalletFilm = _dt as DataPalletFilm;
            if (null != dtPalletFilm)
                _document.CreateNewPalletFilm(ToPalletFilm(dtPalletFilm));
        }
        #endregion

        #region Helpers
        internal BoxProperties ToCase(DataCase dtCase)
        {
            BoxProperties boxProperties = new BoxProperties(null
                 , dtCase.OuterDimensions[0], dtCase.OuterDimensions[1], dtCase.OuterDimensions[2]
                 , dtCase.InnerDimensions[0], dtCase.InnerDimensions[1], dtCase.InnerDimensions[2]);
            Color[] colors = new Color[6];
            for (int i = 0; i < 6; ++i) colors[i] = Color.Chocolate;
            boxProperties.Name = dtCase.Name;
            boxProperties.Description = dtCase.Description;
            boxProperties.SetAllColors(colors);
            boxProperties.ShowTape = true;
            boxProperties.TapeColor = Color.Beige;
            boxProperties.TapeWidth = UnitsManager.ConvertLengthFrom(50, UnitsManager.UnitSystem.UNIT_METRIC1);
            boxProperties.Weight = dtCase.Weight;
            boxProperties.NetWeight = new OptDouble(dtCase.NetWeight > 0.0, dtCase.NetWeight);
            return boxProperties;
        }
        internal BoxProperties ToBox(DataBox dtBox)
        {
            BoxProperties boxProperties = new BoxProperties(null
                , dtBox.Dimensions[0], dtBox.Dimensions[1], dtBox.Dimensions[2]);
            boxProperties.Name = dtBox.Name;
            boxProperties.Description = dtBox.Description;
            Color[] colors = new Color[6];
            for (int i = 0; i < 6; ++i) colors[i] = Color.Turquoise;
            boxProperties.SetAllColors(colors);
            boxProperties.ShowTape = false;
            boxProperties.Weight = dtBox.Weight;
            boxProperties.NetWeight = new OptDouble(dtBox.NetWeight > 0, dtBox.NetWeight);
            return boxProperties;
        }
        internal PalletProperties ToPallet(DataPallet dtPallet)
        {
            PalletProperties palletProperties = new PalletProperties(null, dtPallet.TypeName
                , dtPallet.Dimensions[0], dtPallet.Dimensions[1], dtPallet.Dimensions[2]
                );
            palletProperties.Name = dtPallet.Name;
            palletProperties.Description = dtPallet.Description;
            return palletProperties;
        }
        internal CylinderProperties ToCylinder(DataCylinder dtCylinder)
        {
            return new CylinderProperties(
                null
                , dtCylinder.Name, dtCylinder.Description
                , 0.5 * dtCylinder.Diameter, 0.5 * dtCylinder.InnerDiameter, dtCylinder.Height, dtCylinder.Weight
                , Color.Gray, Color.LightSkyBlue, Color.Chocolate);
        }
        internal InterlayerProperties ToInterlayer(DataInterlayer dtInterlayer)
        {
            return new InterlayerProperties(
                null
                , dtInterlayer.Name, dtInterlayer.Description
                , dtInterlayer.Dimensions[0], dtInterlayer.Dimensions[1], dtInterlayer.Dimensions[2]
                , dtInterlayer.Weight, Color.Beige);
        }
        internal PalletCapProperties ToPalletCap(DataPalletCap dtPalletCap)
        {
            return new PalletCapProperties(null, dtPalletCap.Name, dtPalletCap.Description
                , dtPalletCap.Dimensions[0], dtPalletCap.Dimensions[1], dtPalletCap.Dimensions[2]
                , dtPalletCap.InnerDimensions[0], dtPalletCap.InnerDimensions[1], dtPalletCap.InnerDimensions[2]
                , dtPalletCap.Weight, Color.Khaki);
        }
        internal PalletFilmProperties ToPalletFilm(DataPalletFilm dtPalletFilm)
        {
            return new PalletFilmProperties(null, dtPalletFilm.Name, dtPalletFilm.Description
                , dtPalletFilm.Transparency, dtPalletFilm.Hatching
                , dtPalletFilm.Spacing, dtPalletFilm.Angle
                , Color.LightSkyBlue);
        }
        internal bool HasType(Type tp)
        {
            foreach (DataType dt in _listTypes)
            {
                if (dt.GetType() == tp)
                    return true;
            }
            return false;
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
                Box b = new Box(0, ToCase(dtCase));
                graphics.AddBox(b);
                graphics.AddDimensions(new DimensionCube(dtCase.OuterDimensions));
            }
            DataBox dtBox = _dt as DataBox;
            if (null != dtBox)
            {
                Box b = new Box(0, ToBox(dtBox));
                graphics.AddBox(b);
                graphics.AddDimensions(new DimensionCube(dtBox.Dimensions));
            }
            DataPallet dtPallet = _dt as DataPallet;
            if (null != dtPallet)
            {
                Pallet pallet = new Pallet(ToPallet(dtPallet));
                pallet.Draw(graphics, Sharp3D.Math.Core.Transform3D.Identity);
                graphics.AddDimensions(new DimensionCube(dtPallet.Dimensions));
            }
            DataInterlayer dtInterlayer = _dt as DataInterlayer;
            if (null != dtInterlayer)
            {
                graphics.AddBox(new Box(0, ToInterlayer(dtInterlayer)));
                graphics.AddDimensions(new DimensionCube(dtInterlayer.Dimensions));
            }

            DataPalletCap dtPalletCap = _dt as DataPalletCap;
            if (null != dtPalletCap)
            {
                PalletCap palletCap = new PalletCap(0, ToPalletCap(dtPalletCap), Sharp3D.Math.Core.Vector3D.Zero);
                palletCap.Draw(graphics);
                graphics.AddDimensions(new DimensionCube(dtPalletCap.Dimensions));
            }

            DataCylinder dtCylinder = _dt as DataCylinder;
            if (null != dtCylinder)
            {
                Cylinder cyl = new Cylinder(0, ToCylinder(dtCylinder));
                graphics.AddCylinder(cyl);
            }
        }
        #endregion

        #region Data members
        private List<DataType> _listTypes;
        private List<Type> _classes = new List<Type>();
        private DataType _dt;
        private DocumentSB _document;
        #endregion
    }
    #endregion

    #region ListBoxItem
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
    #endregion
}
