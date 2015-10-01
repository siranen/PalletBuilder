using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace treeDiM.StackBuilder.Basics
{
    public class DataDef
    {
        #region Constructor
        public DataDef(string name, Type type, UnitsManager.UnitType unitType, bool sortable)
        {
            Name = name;
            Type = type;
            Sortable = sortable;
            UnitType = unitType;
        }
        #endregion

        #region Accessors
        public string Name { get; set; }
        public Type Type { get; set; }
        public bool Sortable { get; set; }
        public UnitsManager.UnitType UnitType { get; set; }
        #endregion
    }

    public interface IBaseSolution
    {
        DataDef[] Columns { get; }
        List<object> Values { get; }
    }
}
