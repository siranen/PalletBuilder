#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion

namespace TreeDim.StackBuilder.Basics
{
    public partial class UCtrlOptTriDouble : UserControl
    {
        #region Delegates
        public delegate void onValueChanged(object sender, EventArgs e);
        #endregion

        #region Events
        [Browsable(true)]
        public event onValueChanged ValueChanged;
        #endregion

        #region Constructor
        public UCtrlOptTriDouble()
        {
            InitializeComponent();
        }
        #endregion

        #region Public properties
        [Browsable(true),
        EditorBrowsable(EditorBrowsableState.Always),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
        Category("Appearance")]
        public override string Text
        {
            get { return chkbOpt.Text; }
            set { chkbOpt.Text = value; }
        }
        [Browsable(true)]
        public double X
        { get { return (double)nudX.Value; } set { nudX.Value = (decimal)value; } }
        [Browsable(true)]
        public double Y
        { get { return (double)nudY.Value; } set { nudY.Value = (decimal)value; } }
        [Browsable(true)]
        public double Z
        { get { return (double)nudZ.Value; } set { nudZ.Value = (decimal)value; } }
        public bool Checked
        {
            get { return chkbOpt.Checked; }
            set { chkbOpt.Checked = value; chkbOpt_CheckedChanged(this, null); }
        }
        [Browsable(true)]
        public decimal Minimum
        {
            get { return nudX.Minimum; }
            set { nudX.Minimum = value; nudY.Minimum = value; nudZ.Minimum = value; }
        }
        [Browsable(true)]
        public UnitsManager.UnitType Unit
        {
            get { return _unitType; }
            set
            {
                _unitType = value;
                lbUnit.Text = UnitsManager.UnitString(_unitType);
                nudX.DecimalPlaces = nudY.DecimalPlaces = nudZ.DecimalPlaces = UnitsManager.NoDecimals(_unitType);
            }
        }
        #endregion

        #region Event handlers
        private void chkbOpt_CheckedChanged(object sender, EventArgs e)
        {
            nudX.Enabled = chkbOpt.Checked;
            nudY.Enabled = chkbOpt.Checked;
            nudZ.Enabled = chkbOpt.Checked;
            lbUnit.Enabled = chkbOpt.Checked;
            if (null != ValueChanged) ValueChanged(this, e);
        }
        private void nudValue_ValueChanged(object sender, EventArgs e)
        {
            if (null != ValueChanged) ValueChanged(this, e);
        }
        public void OptValueControl_SizeChanged(object sender, EventArgs e)
        {
            // set nud location
            nudX.Location = new Point(Width - 3 * UCtrlDouble.stNudLength - UCtrlDouble.stLbUnitLength, 0);
            nudY.Location = new Point(Width - 2 * UCtrlDouble.stNudLength - UCtrlDouble.stLbUnitLength, 0);
            nudZ.Location = new Point(Width - 1 * UCtrlDouble.stNudLength - UCtrlDouble.stLbUnitLength, 0);

            // set unit location
            lbUnit.Location = new Point(Width - UCtrlDouble.stLbUnitLength + 1, 4);
        }
        #endregion

        #region Data members
        private UnitsManager.UnitType _unitType;
        #endregion
    }
}
