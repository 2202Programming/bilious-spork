using System;
using WPILib.SmartDashboard;
using Pantheon.ServiceReference1;

namespace Pantheon
{
    public class SmartWriter
    {
        /// <summary>
        /// The _reporter instance
        /// </summary>
        private static ReporterClient _reporterInstance;

        /// <summary>
        /// The connected
        /// </summary>
        private static bool Connected = true;

        /// <summary>
        /// Gets the reporter instance.
        /// </summary>
        /// <value>
        /// The reporter instance.
        /// </value>
        public static ReporterClient ReporterInstance
        {
            get
            {
                if (_reporterInstance == null)
                    _reporterInstance = new ReporterClient();
                
                return _reporterInstance;
            }
        }

        /// <summary>
        /// Writes the string.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="value">The value.</param>
        /// <param name="Debug">The debug.</param>
        public static void WriteString(string label, string value, DebugMode Debug)
        {
            if (Global.DMode >= Debug)
            {
                SmartDashboard.PutString(label, value);
                if (Global.DisplayConsoleOutput) Console.WriteLine(label + " : " + value);
            }
            ReportData(label, value);
        }

        /// <summary>
        /// Writes the bool.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <param name="Debug">The debug.</param>
        public static void WriteBool(string label, bool value, DebugMode Debug)
        {
            if (Global.DMode >= Debug)
            {
                SmartDashboard.PutBoolean(label, value);
                if (Global.DisplayConsoleOutput) Console.WriteLine(label + " : " + value);
            }
            ReportData(label, value.ToString());
        }

        /// <summary>
        /// Writes the number.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="value">The value.</param>
        /// <param name="Debug">The debug.</param>
        public static void WriteNumber(string label, double value, DebugMode Debug)
        {
            if (Global.DMode >= Debug)
            {
                SmartDashboard.PutNumber(label, value);
                if (Global.DisplayConsoleOutput) Console.WriteLine(label + " : " + value);
            }
            ReportData(label, value.ToString());
        }

        /// <summary>
        /// Reports the data.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        private static void ReportData(string key, string value)
        {
            try
            {
                if (Connected)
                {
                    ReporterInstance.ReportData(key, value);
                    SmartDashboard.PutString("ServiceStatus", "Connected");
                }
            }
            catch
            {
                SmartDashboard.PutString("Service Status", "Disconnected");
                Connected = false;
            }
        }
    }
}

