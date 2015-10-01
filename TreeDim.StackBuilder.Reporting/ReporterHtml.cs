#region Using directives
using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Xml;

using log4net;

using treeDiM.StackBuilder.Basics;
#endregion

namespace treeDiM.StackBuilder.Reporting
{
    public class ReporterHtml : Reporter
    {
        #region Constructor
        /// <summary>
        /// ReportHtml : generate html report
        /// </summary>
        public ReporterHtml(ReportData inputData, string templatePath, string outpuFilePath)
        {
            BuildAnalysisReport(inputData, templatePath, outpuFilePath);
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
}
