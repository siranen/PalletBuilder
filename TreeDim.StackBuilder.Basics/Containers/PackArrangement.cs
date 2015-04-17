#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
#endregion

namespace TreeDim.StackBuilder.Basics
{
    public class PackArrangement
    {
        #region Constructor
        public PackArrangement(int iLength, int iWidth, int iHeight)
        {
            _iLength = iLength; _iWidth = iWidth; _iHeight = iHeight;
        }
        #endregion

        #region Public properties
        /// <summary>
        /// Number of items
        /// </summary>
        public int Number   { get { return _iLength * _iWidth * _iHeight; } }
        /// <summary>
        /// Length
        /// </summary>
        public int Length   { get { return _iLength; } }
        /// <summary>
        /// Width
        /// </summary>
        public int Width    { get { return _iWidth; } }
        /// <summary>
        /// Height
        /// </summary>
        public int Height   { get { return _iHeight; } }
        #endregion

        #region Object override
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", _iLength, _iWidth, _iHeight);
        }
        #endregion

        #region Parsing
        public static PackArrangement TryParse(string value)
        { 
            string regularExp = "(?<i1>.*) (?<i2>.*) (?<i3>.*)";
			Regex r = new Regex(regularExp, RegexOptions.Singleline);
    		Match m = r.Match(value);
		    if (m.Success)
                return new PackArrangement(int.Parse(m.Result("${i1}")), int.Parse(m.Result("${i2}")), int.Parse(m.Result("${i3}"))) ;
		    else
			    throw new Exception("Failed parsing int[3] from " + value );
        }
        #endregion

        #region Data members
        public int _iLength, _iWidth, _iHeight;
        #endregion
    }
}