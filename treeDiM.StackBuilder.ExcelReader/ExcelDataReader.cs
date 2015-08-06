#region using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Globalization;

using Excel;
using log4net;
#endregion

namespace treeDiM.StackBuilder.ExcelReader
{
    public class ExcelDataReader
    {
        protected static readonly ILog _log = LogManager.GetLogger(typeof(ExcelDataReader));

        public static bool LoadFile(string filePath, ref List<DataType> listItems)
        {
            if (!File.Exists(filePath)) return false;
            FileInfo fi = new FileInfo(filePath);

            if (null != listItems)
                listItems.Clear();
            else
                listItems = new List<DataType>();
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                IExcelDataReader reader = null;
                if (".xls" == fi.Extension) reader = ExcelReaderFactory.CreateBinaryReader(fs);
                else if (".xlsx" == fi.Extension) reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                // no valid reader created -> exit
                if (reader == null)
                    return false;
                reader.IsFirstRowAsColumnNames = true;

                DataSet ds = reader.AsDataSet();

                foreach (DataTable dtTable in ds.Tables)
                {
                    int iRowStart = 0;
                    for (int iRow = iRowStart; iRow < dtTable.Rows.Count; ++iRow)
                    {
                        DataType dataType = null;
                        try
                        {
                            dataType = BuildDataType(dtTable.TableName, iRow, dtTable.Rows[iRow]);
                        }
                        catch (InvalidRowException /*ex*/)
                        {
                            break;
                        }
                        catch (Exception ex)
                        {
                            _log.Error(string.Format("Failed to read {0}({1}) with message : {2}", dtTable.TableName, iRow, ex.Message));
                            dataType = null;
                            break;
                        }
                        if (null != dataType)
                            listItems.Add(dataType);
                    }
                
                }
            }
            return listItems.Count > 0;
        }

        private static DataType BuildDataType(string sheetName, int iRow, System.Data.DataRow dtRow)
        {
            if (string.Equals(sheetName, "Cases", StringComparison.CurrentCultureIgnoreCase))
                return new DataCase(iRow, dtRow);
            else if (string.Equals(sheetName, "Boxes", StringComparison.CurrentCultureIgnoreCase))
                return new DataBox(iRow, dtRow);
            else if (string.Equals(sheetName, "Pallets", StringComparison.CurrentCultureIgnoreCase))
                return new DataPallet(iRow, dtRow);
            else if (string.Equals(sheetName, "Interlayers", StringComparison.CurrentCultureIgnoreCase))
                return new DataInterlayer(iRow, dtRow);
            else if (string.Equals(sheetName, "Pallet caps", StringComparison.CurrentCultureIgnoreCase))
                return new DataPalletCap(iRow, dtRow); 
            else if (string.Equals(sheetName, "Pallet films", StringComparison.CurrentCultureIgnoreCase))
                return new DataPalletFilm(iRow, dtRow); 
            else if (string.Equals(sheetName, "Cylinders", StringComparison.CurrentCultureIgnoreCase))
                return new DataCylinder(iRow, dtRow);
            else
                throw new FormatException(string.Format("{0} is not a valid sheet name", sheetName));
        }

        private string FormatNumber(double x)
        {
            if (Math.Floor(x) == x)
                return Math.Floor(x).ToString();
            else
                return Math.Round(x, 2).ToString(CultureInfo.InvariantCulture);
        }
    }
}
