#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
#endregion

namespace TreeDim.StackBuilder.Basics
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct OptDouble : ICloneable
    {
        #region Private fields
        private bool _activated;
        private double _val;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="OptDouble"/> class with specified value and option status
        /// </summary>
        public OptDouble(bool activated, double val)
        {
            _activated = activated;
            _val = val;
        }
        public OptDouble(OptDouble optValue)
        {
            _activated = optValue._activated;
            _val = optValue._val;
        }
        #endregion

        #region Constants
        /// <summary>
        /// Zero optional value (= default constructor)
        /// </summary>
        public static readonly OptDouble Zero = new OptDouble(false, 0.0);
        #endregion

        #region Public properties
        public bool Activated
        {
            get { return _activated; }
            set { _activated = value; }
        }
        public double Value
        {
            get { return _activated ? _val : 0.0; }
            set { _val = value; }
        }
        #endregion

        #region ICloneable members
        object ICloneable.Clone()
        {
            return new OptDouble(this);
        }
        public OptDouble Clone()
        {
            return new OptDouble(this);
        }
        #endregion

        #region Public Static Parse Methods
        /// <summary>
        /// Converts the specified string to its <see cref="OptDouble"/> equivalent.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="value">A string representation of a <see cref="OptDouble"/>.</param>
        /// <returns>A <see cref="OptDouble"/> that represents the OptValue specified by the <paramref name="value"/> parameters.</returns>
        public static OptDouble Parse(string value)
        {
            Regex r = new Regex(@"\((?<o>),(?<v>.*)\)", RegexOptions.Singleline);
            Match m = r.Match(value);
            if (m.Success)
            {
                return new OptDouble(
                    bool.Parse(m.Result("${o}")),
                    double.Parse(m.Result("${v}"), System.Globalization.CultureInfo.InvariantCulture)
                    );
            }
            else
                throw new ApplicationException("Unsuccessful Match.");
        }
        /// <summary>
        /// Converts the specified string to its <see cref="OptDouble"/> equivalent.
        /// </summary>
        /// <param name="value">A string representation of a <see cref="OptDouble"/>.</param>
        /// <param name="result">When this method returns, if the conversion succeeded,
        /// contains a <see cref="OptDouble"/> reprensention the OptValue specified by <paramref name="value"/>.
        /// </param>
        /// <returns><see langword="true"/> if value was converted successfully; otherwise, <see langword="false"/>.</returns>
        public static bool TryParse(string value, out OptDouble result)
        {
            Regex r = new Regex(@"\((?<o>),(?<v>.*)\)", RegexOptions.Singleline);
            Match m = r.Match(value);
            if (m.Success)
            {
                result = new OptDouble(
                    bool.Parse(m.Result("${o}")),
                    double.Parse(m.Result("${v}"), System.Globalization.CultureInfo.InvariantCulture)
                    );
                return true;
            }
            result = OptDouble.Zero;
            return false;
        }
        #endregion

        #region System.Object overrides
        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            return _activated.GetHashCode() ^ _val.GetHashCode();
        }
        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns>A string representation of this object.</returns>
        public override bool Equals(object obj)
        {
            if (obj is OptDouble)
            {
                OptDouble optValue = (OptDouble)obj;
                return (_activated == optValue._activated) && (_val == optValue._val);

            }
            return false;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1})", _activated.ToString(), _val.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }
        #endregion

        #region Comparisons operators
        public static bool operator ==(OptDouble left, OptDouble right)
        {
            return ValueType.Equals(left, right);
        }
        public static bool operator !=(OptDouble left, OptDouble right)
        {
            return !ValueType.Equals(left, right);
        }
        public static bool operator <(OptDouble left, OptDouble right)
        {
            return left.Activated && right.Activated && left.Value < right.Value;
        }
        public static bool operator >(OptDouble left, OptDouble right)
        {
            return left.Activated && right.Activated && left.Value > right.Value;
        }
        public static bool operator <=(OptDouble left, OptDouble right)
        {
            return left.Activated && right.Activated && left.Value <= right.Value;
        }
        public static bool operator >=(OptDouble left, OptDouble right)
        {
            return left.Activated && right.Activated && left.Value >= right.Value;
        }
        #endregion

        #region Arithmetics
        public static OptDouble Negate(OptDouble optValue)
        {
            return new OptDouble(optValue._activated, -optValue._val);
        }
        #endregion

        #region Unary operators
        public static OptDouble operator -(OptDouble optValue)
        {
            return OptDouble.Negate(optValue);
        }
        #endregion

        #region Binary operators
        public static double operator +(OptDouble optValue, double d)
        { 
            return d + (optValue.Activated ? optValue.Value : 0.0);
        }
        public static double operator +(double d, OptDouble optValue)
        {
            return d + (optValue.Activated ? optValue.Value : 0.0);
        }
        public static double operator -(OptDouble optValue, double d)
        {
            return (optValue.Activated ? optValue.Value : 0.0) - d;
        }
        public static double operator -(double d, OptDouble optValue)
        {
            return d - (optValue.Activated ? optValue.Value : 0.0);
        }
        public static bool operator <(OptDouble optValue, double d)
        {
            return (optValue.Activated ? optValue.Value : 0.0) < d;
        }
        public static bool operator >(OptDouble optValue, double d)
        {
            return (optValue.Activated ? optValue.Value : 0.0) > d;
        }
        public static bool operator <=(OptDouble optValue, double d)
        {
            return (optValue.Activated ? optValue.Value : 0.0) < d;
        }
        public static bool operator >=(OptDouble optValue, double d)
        {
            return (optValue.Activated ? optValue.Value : 0.0) > d;
        }
        public static OptDouble operator *(OptDouble optValue, int iMult)
        {
            return new OptDouble(optValue.Activated, iMult * optValue.Value);
        }
        public static OptDouble operator *(int iMult, OptDouble optValue)
        {
            return new OptDouble(optValue.Activated, iMult * optValue.Value);
        }
        #endregion
    }
}
