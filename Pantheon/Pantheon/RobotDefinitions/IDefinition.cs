// ***********************************************************************
// Assembly         : Pantheon
// Author           : lazar
// Created          : 07-01-2016
//
// Last Modified By : lazar
// Last Modified On : 07-01-2016
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPILib;
using WPILib.SmartDashboard;
using WPILib.Extras;
using System.Xml;

namespace Pantheon.RobotDefinitions
{
    /// <summary>
    /// Class IDefinition. Base class for any robot definition
    /// </summary>
    public class IDefinition
    {
        #region Fields

        protected Dictionary<string, string> _properties;
        protected bool _useXMLBag = true;
        private string _name;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="IDefinition" /> class.
        /// </summary>
        public IDefinition()
        {
            _name = LoadDefinitionName();
            LoadPropertyBag();
        }

        /// <summary>
        /// Loads the property bag.
        /// </summary>
        protected void LoadPropertyBag()
        {
            if (_useXMLBag)
            {
                //TODO Implement
            }
            else
            {
                LoadManualProperties();
            }
        }

        /// <summary>
        /// Loads the manual properties. Override this method in the subclass in order to
        /// </summary>
        protected virtual void LoadManualProperties()
        { }

        /// <summary>
        /// Loads the name of the definition.
        /// </summary>
        /// <returns>System.String.</returns>
        protected virtual string LoadDefinitionName()
        { return "DEFAULT"; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.String.</returns>
        public string GetValue(string key)
        {
            return _properties.FirstOrDefault(x => x.Key == key).Value;
        }

        /// <summary>
        /// Gets the int.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.Int32.</returns>
        public int GetInt(string key)
        {
            try
            {
                return int.Parse(GetValue(key));
            }
            catch
            {
                throw new Exception("Int Not Found in Dictionary");
            }
        }

        /// <summary>
        /// Gets the double.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.Double.</returns>
        public double GetDouble(string key)
        {
            try
            {
                return double.Parse(GetValue(key));
            }
            catch
            {
                throw new Exception("Value Not found in Dictionary");
            }
        }

        /// <summary>
        /// Gets the bool.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool GetBool(string key)
        {
            var value = GetValue(key);
            if (value == "ON") return true;
            if (value == "TRUE") return true;
            if (value == "SET") return true;
            if (value == "1") return true;
            return false;
        }

        public virtual Dictionary<String, IControl> GetControlObjects()
        {
            var controlObjects = new Dictionary<String, IControl>();

            return controlObjects;
        }
    }
}
