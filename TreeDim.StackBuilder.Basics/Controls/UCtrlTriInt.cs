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

namespace treeDiM.StackBuilder.Basics.Controls
{
    public partial class UCtrlTriInt : UserControl
    {
        #region Delegates
        public delegate void onValueChanged(object sender, EventArgs e);
        #endregion

        #region Events
        [Browsable(true)]
        public event onValueChanged ValueChanged;
        #endregion

        #region Constructor
        public UCtrlTriInt()
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
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }
        [Browsable(true)]
        public int NoX { get { return (int)nudX.Value; } set { nudX.Value = (decimal)value; } }
        [Browsable(true)]
        public int NoY { get { return (int)nudY.Value; } set { nudY.Value = (decimal)value; } }
        [Browsable(true)]
        public int NoZ { get { return (int)nudZ.Value; } set { nudZ.Value = (decimal)value; } }
        #endregion

        #region Event handlers
        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (null != ValueChanged) ValueChanged(this, e);
        }
        #endregion

        private void UCtrlTriInt_SizeChanged(object sender, EventArgs e)
        {
            // set nud location
            nudX.Location = new Point(Width - 3 * UCtrlDouble.stNudLength, 0);
            nudY.Location = new Point(Width - 2 * UCtrlDouble.stNudLength, 0);
            nudZ.Location = new Point(Width - 1 * UCtrlDouble.stNudLength, 0);
        }
    }
}
