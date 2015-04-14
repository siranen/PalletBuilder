#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using log4net;

using TreeDim.StackBuilder.Basics;
using TreeDim.StackBuilder.Graphics;
using Sharp3D.Math.Core;

using TreeDim.StackBuilder.Desktop.Properties;
#endregion

namespace TreeDim.StackBuilder.Desktop
{
    public partial class FormNewPack : FormNewBase, IDrawingContainer
    {
        #region Data members
        private List<BoxProperties> _boxes = new List<BoxProperties>();
        private PackProperties _packProperties;
        static readonly ILog _log = LogManager.GetLogger(typeof(FormNewPack));
        #endregion

        #region Constructor
        public FormNewPack(Document doc, PackProperties packProperties)
            : base(doc, packProperties)
        {
            InitializeComponent();
            _packProperties = packProperties;           
        }
        #endregion

        #region FormNewBase overrides
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Graphics3DControl
            graphCtrl.DrawingContainer = this;
            // list of packs
            ComboBoxHelpers.FillCombo(_boxes.ToArray(), cbInnerBox, null != _packProperties ? _packProperties.Box : _boxes[0]);
            // arrangement
            if (null != _packProperties)
            {
                cbDir.SelectedIndex = (int)(_packProperties.BoxOrientation);
                Arrangement = _packProperties.Arrangement;
            }
            else
            { 
                cbDir.SelectedIndex = 5; // HalfAxis.HAxis.AXIS_Z_P
                Arrangement = new PackArrangement(3, 2, 1);
            }
            // disable Ok button
            UpdateStatus(string.Empty);
        }

        public override string ItemDefaultName
        { get { return Resources.ID_PACK; } }

        public override void UpdateStatus(string message)
        {
            if (!this.DesignMode)
            {
                double length = 0.0, width = 0.0, height = 0.0;
                PackProperties.GetOuterDimensions(
                    SelectedBox,
                    BoxOrientation,
                    Arrangement,
                    ref length, ref width, ref height);
                if (uCtrlOuterDimensions.Checked && (uCtrlOuterDimensions.X < length || uCtrlOuterDimensions.Y < width || uCtrlOuterDimensions.Z < height))
                    message = Properties.Resources.ID_INVALIDOUTERDIMENSION;
            }
            base.UpdateStatus(message);
        }
        #endregion

        #region Public properties
        public List<BoxProperties> Boxes
        {
            set { _boxes = value; }
            get { return _boxes; }
        }
        public BoxProperties SelectedBox
        {
            get
            {
                if (_boxes.Count > 0 && -1 != cbInnerBox.SelectedIndex)
                    return _boxes[cbInnerBox.SelectedIndex];
                else
                    return null;
            }
        }
        public HalfAxis.HAxis BoxOrientation
        {
            get
            {
                HalfAxis.HAxis[] axes
                    = {
                           HalfAxis.HAxis.AXIS_X_N,
                           HalfAxis.HAxis.AXIS_X_P,
                           HalfAxis.HAxis.AXIS_Y_N,
                           HalfAxis.HAxis.AXIS_Y_P,
                           HalfAxis.HAxis.AXIS_Z_N,
                           HalfAxis.HAxis.AXIS_Z_P
                      };
                return axes[cbDir.SelectedIndex != -1 ? cbDir.SelectedIndex : 5];
            }
        }
        public PackArrangement Arrangement
        {
            get
            {
                return new PackArrangement(uCtrlLayout.NoX, uCtrlLayout.NoY, uCtrlLayout.NoZ);
            }
            set
            {
                uCtrlLayout.NoX = value._iLength;
                uCtrlLayout.NoY = value._iWidth;
                uCtrlLayout.NoZ = value._iHeight;
            }
        }
        public PackWrapper Wrapper
        {
            get
            {
                return new WrapperPolyethilene(0.1);  
            }
        }
        public bool HasForcedOuterDimensions
        { get { return uCtrlOuterDimensions.Checked; } }
        public Vector3D OuterDimensions
        {
            get
            {
                return new Vector3D(
                    uCtrlOuterDimensions.X,
                    uCtrlOuterDimensions.Y,
                    uCtrlOuterDimensions.Z); 
            }
        }
        #endregion

        #region Event handlers
        private void FormNewPack_Load(object sender, EventArgs e)
        {
            graphCtrl.DrawingContainer = this;
            UpdateStatus(string.Empty);
        }
        private void onPackChanged(object sender, EventArgs e)
        {
            if (sender != uCtrlOuterDimensions && !this.DesignMode)
            {
                double length = 0.0, width = 0.0, height = 0.0;
                PackProperties.GetOuterDimensions(SelectedBox, BoxOrientation, Arrangement, ref length, ref width, ref height);
                uCtrlOuterDimensions.X = length;
                uCtrlOuterDimensions.Y = width;
                uCtrlOuterDimensions.Z = height;
            }
            UpdateStatus(string.Empty);
            graphCtrl.Invalidate();
        }
        #endregion

        #region IDrawingContainer
        public void Draw(Graphics3DControl ctrl, Graphics3D graphics)
        {
            // build pack
            PackProperties pack = new PackProperties(null, SelectedBox, Arrangement, BoxOrientation, Wrapper);
            graphics.AddBox(new Pack(0, pack));
            graphics.AddDimensions(new DimensionCube(Vector3D.Zero, pack.Length, pack.Width, pack.Height, Color.Black, true));
            graphics.AddDimensions(new DimensionCube(pack.InnerOffset, pack.InnerLength, pack.InnerWidth, pack.InnerHeight, Color.Red, false));
        }
        #endregion
    }
}
