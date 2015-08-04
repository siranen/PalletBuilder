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
            Name = dtRow[0] as string;
            Description = dtRow[1] as string;
        }
        public int RowId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name          = " + Name );
            sb.AppendLine("Description   = " + Description);
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
            outerDimensions[0] = double.Parse( (string)dtRow[2], CultureInfo.InvariantCulture);
            outerDimensions[1] = double.Parse( (string)dtRow[3], CultureInfo.InvariantCulture);
            outerDimensions[2] = double.Parse( (string)dtRow[4], CultureInfo.InvariantCulture);

            if (DBNull.Value != dtRow[5])   innerDimensions[0] = double.Parse( (string)dtRow[5], CultureInfo.InvariantCulture);
            if (DBNull.Value != dtRow[6])   innerDimensions[0] = double.Parse( (string)dtRow[6], CultureInfo.InvariantCulture);
            if (DBNull.Value != dtRow[7])   innerDimensions[0] = double.Parse( (string)dtRow[7], CultureInfo.InvariantCulture);
            if (DBNull.Value != dtRow[8])   Weight = double.Parse( (string)dtRow[8], CultureInfo.InvariantCulture );
            if (DBNull.Value != dtRow[9])   NetWeight = double.Parse( (string)dtRow[9], CultureInfo.InvariantCulture );
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
            dimensions[0] = double.Parse((string)dtRow[2], CultureInfo.InvariantCulture);
            dimensions[1] = double.Parse((string)dtRow[3], CultureInfo.InvariantCulture);
            dimensions[2] = double.Parse((string)dtRow[4], CultureInfo.InvariantCulture);

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
            dimensions[0] = double.Parse((string)dtRow[2], CultureInfo.InvariantCulture);
            dimensions[1] = double.Parse((string)dtRow[3], CultureInfo.InvariantCulture);
            dimensions[2] = double.Parse((string)dtRow[4], CultureInfo.InvariantCulture);

            if (DBNull.Value != dtRow[5])   Weight = double.Parse((string)dtRow[5], CultureInfo.InvariantCulture);
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
            sb.AppendLine(TypeName);
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
            dimensions[0] = double.Parse((string)dtRow[2], CultureInfo.InvariantCulture);
            dimensions[1] = double.Parse((string)dtRow[3], CultureInfo.InvariantCulture);
            dimensions[2] = double.Parse((string)dtRow[4], CultureInfo.InvariantCulture);

            if (DBNull.Value != dtRow[5]) Weight = double.Parse((string)dtRow[5], CultureInfo.InvariantCulture);
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
            dimensions[0] = double.Parse((string)dtRow[2], CultureInfo.InvariantCulture);
            dimensions[1] = double.Parse((string)dtRow[3], CultureInfo.InvariantCulture);
            dimensions[2] = double.Parse((string)dtRow[4], CultureInfo.InvariantCulture);

            innerDimensions[0] = double.Parse((string)dtRow[5], CultureInfo.InvariantCulture);
            innerDimensions[1] = double.Parse((string)dtRow[6], CultureInfo.InvariantCulture);
            innerDimensions[2] = double.Parse((string)dtRow[7], CultureInfo.InvariantCulture);

            if (DBNull.Value != dtRow[8]) Weight = double.Parse((string)dtRow[8], CultureInfo.InvariantCulture);
        }
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
            Transparency = (1 == int.Parse((string)dtRow[2]));
            Hatching = (1 == int.Parse((string)dtRow[3]));
            Spacing = double.Parse((string)dtRow[4], CultureInfo.InvariantCulture);
            Angle = double.Parse((string)dtRow[5], CultureInfo.InvariantCulture);
        }

        public bool Transparency { get; set; }
        public bool Hatching { get; set; }
        public double Spacing { get; set; }
        public double Angle { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
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
            Diameter = double.Parse((string)dtRow[2], CultureInfo.InvariantCulture);
            InnerDiameter = double.Parse((string)dtRow[3], CultureInfo.InvariantCulture);
            Height = double.Parse((string)dtRow[4], CultureInfo.InvariantCulture);

            if (DBNull.Value != dtRow[5]) Weight = double.Parse((string)dtRow[5], CultureInfo.InvariantCulture);
            if (DBNull.Value != dtRow[6]) Weight = double.Parse((string)dtRow[6], CultureInfo.InvariantCulture);
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
