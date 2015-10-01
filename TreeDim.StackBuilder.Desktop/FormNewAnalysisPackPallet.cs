#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using treeDiM.StackBuilder.Basics;
using treeDiM.StackBuilder.Desktop.Properties;

using log4net;
#endregion

namespace treeDiM.StackBuilder.Desktop
{
    public partial class FormNewAnalysisPackPallet : FormNewBase
    {
        #region Data members
        private ItemBase[] _pallets;
        private ItemBase[] _packs;
        private ItemBase[] _interlayers;
        private PackPalletAnalysis _analysis;
        static readonly ILog _log = LogManager.GetLogger(typeof(FormNewAnalysisPackPallet));
        #endregion

        #region Constructor
        public FormNewAnalysisPackPallet(Document document, PackPalletAnalysis analysis)
            : base(document, analysis)
        {
            InitializeComponent();
            _analysis = analysis;
        }
        #endregion

        #region FormNewBase overrides
        public override void UpdateStatus(string message)
        {
            if (!MaximumPalletHeight.Activated && !MaximumPalletWeight.Activated)
                message = Resources.ID_USEATLEASTONESTOPSTACKINGCRITERION;
            base.UpdateStatus(message);
        }
        #endregion

        #region Form override
        public override string ItemDefaultName
        {
            get { return Resources.ID_ANALYSIS; }
        }
        protected override void OnLoad(EventArgs e)
        {
 	        base.OnLoad(e);

            ComboBoxHelpers.FillCombo(_packs, cbPack, (null != _analysis) ? _analysis.PackProperties : _packs[0]);
            ComboBoxHelpers.FillCombo(_pallets, cbPallet, (null != _analysis) ? _analysis.PalletProperties : _pallets[0]);
            ComboBoxHelpers.FillCombo(_interlayers, cbInterlayer, (null != _analysis ? _analysis.InterlayerProperties : (_interlayers.Length > 0 ? _interlayers[0] : null)));

            chkbInterlayer.Enabled = cbInterlayer.Items.Count > 0;
            chkbInterlayer.Checked = (null != _analysis) ? _analysis.HasInterlayer : false;

            PackPalletConstraintSet constraintSet = (null != _analysis) ? _analysis.ConstraintSet : null;

            if (null != constraintSet)
            {
                chkbInterlayerFirstLayer.Checked = constraintSet.HasFirstInterlayer;

                OverhangX = constraintSet.OverhangX;
                OverhangY = constraintSet.OverhangY;

                MinimumOverhangX = constraintSet.MinOverhangX;
                MinimumOverhangY = constraintSet.MinOverhangY;

                MaximumSpace = constraintSet.MaximumSpaceAllowed;
                MinimumSpace = constraintSet.MinimumSpace;

                MaximumPalletHeight = constraintSet.MaximumPalletHeight;
                MaximumPalletWeight = constraintSet.MaximumPalletWeight;

                MaximumLayerWeight = constraintSet.MaximumLayerWeight;
            }
            else
            {
                chkbInterlayerFirstLayer.Checked = false;

                OverhangX = Settings.Default.OverhangX;
                OverhangY = Settings.Default.OverhangY;

                MinimumOverhangX = OptDouble.Zero;
                MinimumOverhangY = OptDouble.Zero;

                MaximumSpace = OptDouble.Zero;
                MinimumSpace = OptDouble.Zero;

                MaximumPalletHeight = new OptDouble(true, UnitsManager.ConvertLengthFrom(1200.0, UnitsManager.UnitSystem.UNIT_METRIC1));
                MaximumPalletWeight = new OptDouble(false, UnitsManager.ConvertMassFrom(1000.0, UnitsManager.UnitSystem.UNIT_METRIC1));

                MaximumLayerWeight = new OptDouble(false, UnitsManager.ConvertMassFrom(100.0, UnitsManager.UnitSystem.UNIT_METRIC1));
            }

            onInterlayerChecked(this, null);
            UpdateStatus(string.Empty);
        }
        #endregion

        #region Public properties
        public ItemBase[] Packs
        {
            get { return _packs; }
            set { _packs = value; }
        }
        public ItemBase[] Pallets
        {
            get { return _pallets; }
            set { _pallets = value; }
        }
        public ItemBase[] Interlayers
        { 
            get { return _interlayers; }
            set { _interlayers = value; }
        }
        public PackProperties PackProperties
        { get { return _packs[cbPack.SelectedIndex] as PackProperties; } }
        public PalletProperties PalletProperties
        { get { return _pallets[cbPallet.SelectedIndex] as PalletProperties; } }
        public InterlayerProperties InterlayerProperties
        {
            get
            {
                if (chkbInterlayer.Checked)
                {
                    int iSel = cbInterlayer.SelectedIndex;
                    return iSel != -1 ? (_interlayers[iSel] as InterlayerProperties) : null;
                }
                else
                    return null;
            }
        }
        public int InterlayerPeriod
        { get { return (int)nudInterlayerPeriod.Value; } }
        public bool HasFirstInterlayer
        { get { return chkbInterlayerFirstLayer.Checked;} }
        public OptDouble MaximumPalletHeight
        {
            get { return uCtrlOptMaximumHeight.Value; } 
            set { uCtrlOptMaximumHeight.Value = value; }
        }
        public OptDouble MaximumPalletWeight
        {
            get { return uCtrlOptMaximumWeight.Value; }
            set { uCtrlOptMaximumWeight.Value = value;}
        }
        public OptDouble MaximumLayerWeight
        {
            get { return uCtrlOptMaximumLayerWeight.Value; }
            set { uCtrlOptMaximumLayerWeight.Value = value; }
        }
        public double OverhangX
        {
            get { return uCtrlOverhangX.Value; }
            set { uCtrlOverhangX.Value = value; }
        }
        public double OverhangY
        {
            get { return uCtrlOverhangY.Value; }
            set { uCtrlOverhangY.Value = value; }
        }
        public OptDouble MinimumOverhangX
        {
            get { return uCtrlOptOverhangXMin.Value; }
            set { uCtrlOptOverhangXMin.Value = value; }
        }
        public OptDouble MinimumOverhangY
        { 
            get { return uCtrlOptOverhangYMin.Value; }
            set { uCtrlOptOverhangYMin.Value = value; }
        }
        public OptDouble MinimumSpace
        {
            get { return uCtrlOptMinimumSpace.Value; }
            set { uCtrlOptMinimumSpace.Value = value; }
        }
        public OptDouble MaximumSpace
        {
            get { return uCtrlOptMaximumSpace.Value; }
            set { uCtrlOptMaximumSpace.Value = value; }
        }
        public int LayerSwapPeriod
        {
            get { return (int)nudSwapPeriod.Value; }
            set { nudSwapPeriod.Value = (decimal)value; }
        }
        #endregion

        #region Event handlers
        private void onInterlayerChecked(object sender, EventArgs e)
        {
            bool interlayerEnabled = chkbInterlayer.Checked;
            cbInterlayer.Enabled                = interlayerEnabled;
            chkbInterlayerFirstLayer.Enabled    = interlayerEnabled;
            lbInterlayerPeriod.Enabled          = interlayerEnabled;
            nudInterlayerPeriod.Enabled         = interlayerEnabled;

            UpdateStatus(string.Empty);
        }
        private void onConstraintSetModified(object sender, EventArgs e)
        {
            UpdateStatus(string.Empty);
        }
        #endregion
    }
}
