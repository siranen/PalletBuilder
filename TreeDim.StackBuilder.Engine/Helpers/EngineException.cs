#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace treeDiM.StackBuilder.Engine
{
    public class EngineException : Exception
    {
        #region Constructors
        public EngineException()
            : base()
        { 
        }
        public EngineException(string message)
            : base(message)
        { 
        }
        public EngineException(string message, Exception innerException)
            : base(message, innerException)
        { 
        }
        #endregion
    }
}
