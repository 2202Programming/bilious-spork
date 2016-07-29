using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Pantheon.Service.Contract.Enums;

namespace Pantheon.Service.Contract.Objects
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.IEquatable{Pantheon.Service.Contract.SmartData}" />
    [DataContract, Serializable]
    public class SmartData : IEquatable<SmartData>
    {
        #region Constructors

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the display dictionary.
        /// </summary>
        /// <value>
        /// The display dictionary.
        /// </value>
        [DataMember]
        public Dictionary<string,string> DisplayDictionary { get; set; }

        /// <summary>
        /// Gets or sets the name of the robot.
        /// </summary>
        /// <value>
        /// The name of the robot.
        /// </value>
        [DataMember]
        public string RobotName { get; set; }

        /// <summary>
        /// Gets or sets the robot mode.
        /// </summary>
        /// <value>
        /// The robot mode.
        /// </value>
        [DataMember]
        public RobotMode RobotMode { get; set; }

        #endregion

        #region Object Overrides

        // Equals, GetHashCode, ToString can be all generated using ReSharper (Alt + Ins)
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(SmartData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(DisplayDictionary, other.DisplayDictionary) && string.Equals(RobotName, other.RobotName) && RobotMode == other.RobotMode;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((SmartData) obj);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (DisplayDictionary != null ? DisplayDictionary.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (RobotName != null ? RobotName.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (int) RobotMode;
                return hashCode;
            }
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(SmartData left, SmartData right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(SmartData left, SmartData right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"RobotName: {RobotName}, RobotMode: {RobotMode}";
        }

        #endregion
    }
}