#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TreeDim.StackBuilder.GUIExtension;
#endregion

namespace TreeDim.StackBuilder.GUIExtension.Test
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void bnCasePalletAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                Palletization.StartPalletization("Default case", 220, 140, 145);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bnBoxCasePalletOptimization_Click(object sender, EventArgs e)
        {
            try
            {
                Palletization.StartCaseOptimization("Default box", 100, 60, 40); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bnBundlePalletAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                Palletization.StartBundlePalletAnalysis("Default bundle", 600, 400, 5.0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bnBundleCaseAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                Palletization.StartBundleCaseAnalysis("Default bundle", 60, 40, 1.0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
