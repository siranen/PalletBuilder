#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using treeDiM.StackBuilder.Basics;
using treeDiM.StackBuilder.Engine;
using treeDiM.StackBuilder.GUIExtension.Properties;
using System.IO;
#endregion

namespace treeDiM.StackBuilder.GUIExtension
{
    public class Palletization
    {
        public static void StartPalletization(string name, double length, double width, double height)
        {
            // show analysis details dialog
            FormDefineAnalysis formDefinition = new FormDefineAnalysis();
            formDefinition.CaseName = name;
            formDefinition.CaseLength = length;
            formDefinition.CaseWidth = width;
            formDefinition.CaseHeight = height;
            formDefinition.Pallets = Pallets;

            if (DialogResult.OK != formDefinition.ShowDialog())
                return;

            // create document
            Document doc = new Document(name, name + "_on_" + formDefinition.Pallet.Name, "from extension component", DateTime.Now, null);
            // create case in document
            BoxProperties caseInDoc = doc.CreateNewCase(formDefinition.Case);
            // create pallet in document
            PalletProperties palletInDoc = doc.CreateNewPallet(formDefinition.Pallet);
            // create interlayer in document
            InterlayerProperties interlayerInDoc = formDefinition.Interlayer == null ? null : doc.CreateNewInterlayer(formDefinition.Interlayer);

            // solver
            CasePalletSolver solver = new CasePalletSolver();
            // build list of solutions
            CasePalletAnalysis analysis = doc.CreateNewCasePalletAnalysis(
                string.Format(Resources.ID_ANALYSISNAME, name, formDefinition.Pallet.Name)
                , string.Format(Resources.ID_ANALYSISDESCRIPTION, name, formDefinition.Pallet.Name)
                , caseInDoc
                , palletInDoc
                , interlayerInDoc
                , null
                , null
                , null
                , null
                , formDefinition.Constraints
                , solver);
             
            // select solution / generate report / generate StackBuilder file
            FormSelectSolution formSolutions = new FormSelectSolution(doc, analysis);
            if (DialogResult.OK == formSolutions.ShowDialog())
                return;        
        }

        public static void StartCaseOptimization(string name, double length, double width, double height)
        {
            FormDefineCaseOptimization form = new FormDefineCaseOptimization();
            form.BoxName = name;
            form.BoxLength = length;
            form.BoxWidth = width;
            form.BoxHeight = height;

            if (DialogResult.OK != form.ShowDialog())
                return;

            // create document
            Document doc = new Document(name, name + "_on_" + form.SelectedPallet.Name, "from extension component", DateTime.Now, null);
            // create case in document
            BoxProperties boxInDoc = doc.CreateNewBox(form.SelectedBox);
            // create pallet in document
            PalletProperties palletInDoc = doc.CreateNewPallet(form.SelectedPallet);
        }

        public static void StartBundlePalletAnalysis(string name, double length, double width, double height)
        { 
            FormDefineBundlePalletAnalysis form = new FormDefineBundlePalletAnalysis();
            form.BundleName = name;
            form.FlatLength = length;
            form.FlatWidth = width;
            form.FlatThickness = height;
            form.Pallets = Pallets;
            form.ShowDialog();
        }

        public static void StartBundleCaseAnalysis(string name, double length, double width, double height)
        {
            FormDefineBundleCaseAnalysis form = new FormDefineBundleCaseAnalysis();
            form.BundleName = name;
            form.BundleLength = length;
            form.BundleWidth = width;
            form.FlatThickness = height;
            form.ShowDialog();
        }

        private static List<PalletProperties> Pallets
        {
            get
            {
                List<PalletProperties> pallets = new List<PalletProperties>();
                pallets.Add(new PalletProperties(null, "BLOCK", 1200.0, 1000.0, 150.0)); pallets[0].Name = "Block"; pallets[0].Description = "Wood block";
                pallets.Add(new PalletProperties(null, "UK Standard", 1200.0, 1000.0, 150.0)); pallets[1].Name = "Standard UK"; pallets[1].Description = "Standard UK pallet";
                pallets.Add(new PalletProperties(null, "GMA 48x40", 1219.2, 1016.0, 120.7)); pallets[2].Name = "GMA 48x40"; pallets[2].Description = "Grocery Manufacturer Association (North America)";
                pallets.Add(new PalletProperties(null, "EUR", 1200.0, 800.0, 144.0)); pallets[3].Name = "EUR"; pallets[3].Description = "EUR-EPAL (European Pallet Association)";
                pallets.Add(new PalletProperties(null, "EUR2", 1200.0, 1000.0, 144.0)); pallets[4].Name = "EUR2"; pallets[4].Description = "EUR2-EPAL (European Pallet Association)";
                pallets.Add(new PalletProperties(null, "EUR3", 1200.0, 1000.0, 144.0)); pallets[5].Name = "EUR3"; pallets[5].Description = "EUR3-EPAL (European Pallet Association)";
                pallets.Add(new PalletProperties(null, "EUR6", 800.0, 600.0, 144.0)); pallets[6].Name = "EUR6"; pallets[6].Description = "EUR6-EPAL (European Pallet Association)";
                return pallets;
            }

        }
    }
}
