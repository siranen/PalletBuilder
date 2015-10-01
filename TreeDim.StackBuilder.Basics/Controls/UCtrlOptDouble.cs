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

namespace treeDiM.StackBuilder.Basics
{
    public partial class UCtrlOptDouble : UserControl
    {
        #region Delegates
        public delegate void onValueChanged(object sender, EventArgs e);
        #endregion

        #region Events
        [Browsable(true)]
        public event onValueChanged ValueChanged;
        #endregion

        #region Constructor
        public UCtrlOptDouble()
        {
            InitializeComponent();
            // by default, no unit type
            Unit = UnitsManager.UnitType.UT_NONE;
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
        public OptDouble Value
        {
            get { return new OptDouble(chkbOpt.Checked, (double)nudValue.Value); }
            set
            {
                chkbOpt.Checked = value.Activated;
                nudValue.Value = (decimal)value.Value;
                chkbOpt_CheckedChanged(this, null);
            }
        }
        [Browsable(true)]
        public decimal Minimum
        {
            get { return nudValue.Minimum; }
            set { nudValue.Minimum = value; }
        }
        [Browsable(true)]
        public UnitsManager.UnitType Unit
        {
            get { return _unitType; }
            set
            {
                _unitType = value;
                lbUnit.Text = UnitsManager.UnitString(_unitType);
                nudValue.DecimalPlaces = UnitsManager.NoDecimals(_unitType);
            }
        }
        #endregion

        #region Event handlers
        private void chkbOpt_CheckedChanged(object sender, EventArgs e)
        {
            nudValue.Enabled = chkbOpt.Checked;
            lbUnit.Enabled = chkbOpt.Checked;
            if (null != ValueChanged) ValueChanged(this, e);
        }
        private void nudValue_ValueChanged(object sender, EventArgs e)
        {
            if (null != ValueChanged) ValueChanged(this, e);
        }
        private void OptValueControl_SizeChanged(object sender, EventArgs e)
        {
            // set nud location
            nudValue.Location = new Point(Width - UCtrlDouble.stNudLength - UCtrlDouble.stLbUnitLength, 0);
            // set unit location
            lbUnit.Location = new Point(Width - UCtrlDouble.stLbUnitLength + 1, 4);
        }
        #endregion

        #region Data members
        private UnitsManager.UnitType _unitType;
        #endregion
    }
}
