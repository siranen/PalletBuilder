#region Using directives
using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Xml;

using log4net;

using treeDiM.StackBuilder.Basics;


using Microsoft.Office.Interop;
#endregion

namespace treeDiM.StackBuilder.Reporting
{
    #region Margins
    public class Margins
    {
        public Margins()
        {
            _top = Properties.Settings.Default.MarginTop;
            _bottom = Properties.Settings.Default.MarginBottom;
            _left = Properties.Settings.Default.MarginLeft;
            _right = Properties.Settings.Default.MarginRight;
        }
        public float Top { get { return _top > 0.0f ? _top : 0.0f; } }
        public float Bottom { get { return _bottom > 0.0f ? _bottom : 0.0f; } }
        public float Left { get { return _left > 0.0f ? _left : 0.0f; } }
        public float Right { get { return _right > 0.0f ? _right : 0.0f; } }
        private float _top = 10.0f
            , _bottom = 10.0f
            , _right = 10.0f
            , _left = 10.0f;
    }
    #endregion
    #region ReporterMSWord
    public class ReporterMSWord : Reporter
    {
        #region Constructor
        public ReporterMSWord(ReportData inputData
            , string templatePath, string outputFilePath, Margins margins)
        {
            // absolute output file path
            string absOutputFilePath = string.Empty;
            if (Path.IsPathRooted(outputFilePath))
                absOutputFilePath = outputFilePath;
            else
                absOutputFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), outputFilePath));
            // absolute template path
            string absTemplatePath = string.Empty;
            if (Path.IsPathRooted(templatePath))
                absTemplatePath = templatePath;
            else
                absTemplatePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), templatePath));

            // does output directory exists
            string outDir = Path.GetDirectoryName(absOutputFilePath);
            if (!Directory.Exists(outDir))
            {
                try { Directory.CreateDirectory(outDir); }
                catch (System.UnauthorizedAccessException /*ex*/)
                { throw new UnauthorizedAccessException(string.Format("User not allowed to write under {0}", Directory.GetParent(outDir).FullName)); }
                catch (Exception ex)
                { throw new Exception(string.Format("Directory {0} does not exist, and could not be created.", outDir), ex); }
            }
            // html file path
            string htmlFilePath = Path.ChangeExtension(absOutputFilePath, "html");
            BuildAnalysisReport(inputData, absTemplatePath, htmlFilePath);
            // opens word
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = true;
            Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Open(htmlFilePath, false, true, NoEncodingDialog: true);
            // embed pictures (unlinking images)
            for (int i = 1; i <= wordDoc.InlineShapes.Count; ++i)
            {
                if (null != wordDoc.InlineShapes[i].LinkFormat && !wordDoc.InlineShapes[i].LinkFormat.SavePictureWithDocument)
                    wordDoc.InlineShapes[i].LinkFormat.SavePictureWithDocument = true;
            }
            // set margins (unit?)
            wordDoc.PageSetup.TopMargin = wordApp.CentimetersToPoints(margins.Top);
            wordDoc.PageSetup.BottomMargin = wordApp.CentimetersToPoints(margins.Bottom);
            wordDoc.PageSetup.RightMargin = wordApp.CentimetersToPoints(margins.Right);
            wordDoc.PageSetup.LeftMargin = wordApp.CentimetersToPoints(margins.Left);
            // set print view 
            wordApp.ActiveWindow.ActivePane.View.Type = Microsoft.Office.Interop.Word.WdViewType.wdPrintView;
            wordDoc.SaveAs(absOutputFilePath, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocumentDefault);
            _log.Info(string.Format("Saved doc report to {0}", outputFilePath));
            // delete image directory
            DeleteImageDirectory();
            // delete html report
            File.Delete(htmlFilePath);
        }
        #endregion

        #region Override Reporter
        public override bool WriteNamespace
        {
            get { return false; }
        }
        public override bool WriteImageFiles
        {
            get { return true; }
        }
        #endregion
    }
#endregion
}
