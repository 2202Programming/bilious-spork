using System;
using System.Linq;
using System.ServiceModel;
using Pantheon.Olympus.Services;
using Pantheon.Service.Contract.Enums;
using Pantheon.Service.Contract.Objects;

namespace Pantheon.Olympus
{
    /// <summary>
    /// Service that Runs the entire robot, TODO Have it start up in the WPF app.
    /// </summary>
    /// <seealso cref="Pantheon.Olympus.Services.ISmartService" />
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class OlympusService : ISmartService
    {
        /// <summary>
        /// Reports the data.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void ReportData(string key, string value)
        {
            if (SmartData.DisplayDictionary[key] == null)
            {
                SmartData.DisplayDictionary.Add(key, value);
                return;
            }
            SmartData.DisplayDictionary[key] = value;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public string GetData(string key)
        {
            return SmartData.DisplayDictionary.FirstOrDefault(x => x.Key == key).Value;
        }

        /// <summary>
        /// Reports the mode change.
        /// </summary>
        /// <param name="mode">The mode.</param>
        public void ReportModeChange(RobotMode mode)
        {
            if (SmartData.RobotMode != mode)
                SmartData.RobotMode = mode;
        }

        public SmartData GetSmartData()
        {
            return SmartData;
        }

        /// <summary>
        /// Gets or sets the smart data.
        /// </summary>
        /// <value>
        /// The smart data.
        /// </value>
        private SmartData SmartData { get; set; } = new SmartData();
    }
}
