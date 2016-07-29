using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Pantheon.Service.Contract;
using Pantheon.Service.Contract.Enums;
using Pantheon.Service.Contract.Objects;

namespace Pantheon.Olympus.Services
{
    /// <summary>
    /// Interface for the new Dashboard service
    /// </summary>
    [ServiceContract]
    public interface ISmartService
    {
        /// <summary>
        /// Reports the data.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        [OperationContract]
        void ReportData(string key, string value);

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name="key">The key.</param>
        [OperationContract]
        string GetData(string key);

        /// <summary>
        /// Reports the mode change.
        /// </summary>
        /// <param name="mode">The mode.</param>
        [OperationContract]
        void ReportModeChange(RobotMode mode);

        /// <summary>
        /// Gets or sets the smart data.
        /// </summary>
        /// <value>
        /// The smart data.
        /// </value>
        [OperationContract]
        SmartData GetSmartData();
    }
}
