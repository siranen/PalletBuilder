#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Globalization;
#endregion

namespace treeDiM.StackBuilder.ExcelReader
{
    #region Invalid Row Exception
    internal class InvalidRowException : Exception
    {
        public InvalidRowException(string Type, int rowId, string column, Type expectedType)
        {        
        }


    }
    #endregion
    #region DataType
    public class DataType : Object
    {
        public DataType(int rowId, string name, string description)
        {
            RowId = rowId;
            Name = name;
            Description = description;
        }
        public DataType(int rowId, DataRow dtRow)
        {
            RowId = rowId;
            if (!(dtRow[0] is string)) throw new InvalidRowException("DataType", rowId, "Name", typeof(string));
            Name = dtRow[0] as string;
            if (!(dtRow[1] is string)) throw new InvalidRowException("DataType", rowId, "Description", typeof(string));
            Description = dtRow[1] as string;
        }
        public int RowId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name             = " + Name );
            sb.AppendLine("Description      = " + Description);
            return sb.ToString();
        }
    }
    #endregion
    #region DataCase
    public class DataCase : DataType
    {
        public DataCase(int iRow, string name, string description)
            : base(iRow, name, description)
        {
        }
        public DataCase(int iRow, DataRow dtRow)
            : base(iRow, dtRow)
        {
            outerDimensions[0] = (double)dtRow[2];
            outerDimensions[1] = (double)dtRow[3];
            outerDimensions[2] = (double)dtRow[4];

            if (DBNull.Value != dtRow[5])   innerDimensions[0] = (double)dtRow[5];
            if (DBNull.Value != dtRow[6])   innerDimensions[1] = (double)dtRow[6];
            if (DBNull.Value != dtRow[7])   innerDimensions[2] = (double)dtRow[7];
            if (DBNull.Value != dtRow[8])   Weight = (double)dtRow[8];
            if (DBNull.Value != dtRow[9])   NetWeight = (double)dtRow[9];
        }
        public double[] OuterDimensions
        {
            get { return outerDimensions; }
            set { outerDimensions = value; }
        }
        public double[] InnerDimensions
        {
            get { return innerDimensions; }
            set { innerDimensions = value; }
        }
        public double Weight { get; set; }
        public double NetWeight { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine(string.Format("Outer dimensions = {0}*{1}*{2}", outerDimensions[0], outerDimensions[1], outerDimensions[2]));
            sb.AppendLine(string.Format("Inner dimensions = {0}*{1}*{2}", innerDimensions[0], innerDimensions[1], innerDimensions[2]));
            sb.AppendLine(string.Format("Weight           = {0}", Weight));
            sb.AppendLine(string.Format("Net weight       = {0}", NetWeight));
            return sb.ToString();
        }
        // DATA MEMBERS
        private double[] outerDimensions = new double[3];
        private double[] innerDimensions = new double[3];
    }
    #endregion
    #region DataBox
    public class DataBox : DataType
    {
        public DataBox(int iRow, System.Data.DataRow dtRow)
            : base(iRow, dtRow)
        {
            dimensions[0] = (double)dtRow[2];
            dimensions[1] = (double)dtRow[3];
            dimensions[2] = (double)dtRow[4];

            if (DBNull.Value != dtRow[5]) Weight = (double)dtRow[5];
            if (DBNull.Value != dtRow[6]) NetWeight = (double)dtRow[6];
        }
        public double[] Dimensions { get { return dimensions; } }
        public double Weight { get; set; }
        public double NetWeight { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine(string.Format("Dimensions       = {0}*{1}*{2}", dimensions[0], dimensions[1], dimensions[2]));
            sb.AppendLine(string.Format("Weight           = {0}", Weight));
            sb.AppendLine(string.Format("Net weight       = {0}", NetWeight));
            return sb.ToString();
        }

        // DATA MEMBERS
        private double[] dimensions = new double[3];
    }
#endregion
    #region DataPallet
    public class DataPallet : DataType
    {
        public DataPallet(int iRow, DataRow dtRow)
            : base(iRow, dtRow)
        {
            dimensions[0] = (double)dtRow[2];
            dimensions[1] = (double)dtRow[3];
            dimensions[2] = (double)dtRow[4];

            if (DBNull.Value != dtRow[5])   Weight = (double)dtRow[5];
            if (DBNull.Value != dtRow[6])   TypeName = dtRow[6] as string;
        }
        public double[] Dimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }
        public double Weight { get; set; }
        public string TypeName { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine(string.Format("Dimensions       = {0}*{1}*{2}", dimensions[0], dimensions[1], dimensions[2]));
            sb.AppendLine(string.Format("Weight           = {0}", Weight));
            sb.AppendLine(string.Format("Type             = {0}", TypeName));
            return sb.ToString();
        }
        // DATA MEMBERS
        private double[] dimensions = new double[3];
    }
    #endregion
    #region DataInterlayer
    public class DataInterlayer : DataType
    {
        public DataInterlayer(int iRow, System.Data.DataRow dtRow)
            : base(iRow, dtRow)
        {
            dimensions[0] = (double)dtRow[2];
            dimensions[1] = (double)dtRow[3];
            dimensions[2] = (double)dtRow[4];

            if (DBNull.Value != dtRow[5]) Weight = (double)dtRow[5];
        }
        public double[] Dimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }
        public double Weight { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine(string.Format("Dimensions       = {0}*{1}*{2}", dimensions[0], dimensions[1], dimensions[2]));
            sb.AppendLine(string.Format("Weight           = {0}", Weight));
            return sb.ToString();
        }
        // DATA MEMBERS
        private double[] dimensions = new double[3];
    }
    #endregion
    #region DataPalletCap
    public class DataPalletCap : DataType
    {
        public DataPalletCap(int iRow, DataRow dtRow)
            : base(iRow, dtRow)
        {
            dimensions[0] = (double)dtRow[2];
            dimensions[1] = (double)dtRow[3];
            dimensions[2] = (double)dtRow[4];

            innerDimensions[0] = (double)dtRow[5];
            innerDimensions[1] = (double)dtRow[6];
            innerDimensions[2] = (double)dtRow[7];

            if (DBNull.Value != dtRow[8]) Weight = (double)dtRow[8];
        }
        public double[] Dimensions { get { return dimensions; } }
        public double[] InnerDimensions { get { return innerDimensions; } }
        public double Weight { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine(string.Format("Dimensions       = {0}*{1}*{2}", dimensions[0], dimensions[1], dimensions[2]));
            sb.AppendLine(string.Format("Inner dimensions = {0}*{1}*{2}", dimensions[0], dimensions[1], dimensions[2]));
            sb.AppendLine(string.Format("Weight           = {0}", Weight));
            return sb.ToString();
        }
        // DATA MEMBERS
        private double[] dimensions = new double[3];
        private double[] innerDimensions = new double[3];
    }
    #endregion
    #region DataPalletFilm
    public class DataPalletFilm : DataType
    {
        public DataPalletFilm(int iRow, DataRow dtRow)
            : base(iRow, dtRow)
        {
            Transparency = (1.0 == (double)dtRow[2]);
            Hatching = (1.0 == (double)dtRow[3]);
            Spacing = (double)dtRow[4];
            Angle = (double)dtRow[5];
        }

        public bool Transparency { get; set; }
        public bool Hatching { get; set; }
        public double Spacing { get; set; }
        public double Angle { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine(string.Format("Transparency     = {0}", Transparency));
            sb.AppendLine(string.Format("Hatching         = {0}", Hatching));
            sb.AppendLine(string.Format("Spacing          = {0}", Spacing));
            sb.AppendLine(string.Format("Weight           = {0}", Angle));
            return sb.ToString();
        }
    }
    #endregion
    #region DataCylinder
    public class DataCylinder : DataType
    {
        public DataCylinder(int iRow, DataRow dtRow)
            : base(iRow, dtRow)
        {
            Diameter = (double)dtRow[2];
            InnerDiameter = (double)dtRow[3];
            Height = (double)dtRow[4];

            if (DBNull.Value != dtRow[5]) Weight = (double)dtRow[5];
            if (DBNull.Value != dtRow[6]) Weight = (double)dtRow[6];
        }

        public double Diameter      { get; set; }
        public double InnerDiameter { get; set; }
        public double Height        { get; set; }
        public double Weight        { get; set; }
        public double NetWeight     { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine(string.Format("Diameter         = {0}", Diameter));
            sb.AppendLine(string.Format("Inner diameter   = {0}", InnerDiameter));
            sb.AppendLine(string.Format("Height           = {0}", Height));
            sb.AppendLine(string.Format("Weight           = {0}", Weight));
            sb.AppendLine(string.Format("Net weight       = {0}", NetWeight));
            return sb.ToString();
        }
    }
    #endregion
}
