using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Olympus
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, IncludeExceptionDetailInFaults = true)]
    public class SmartReporter : IReporter
    {
        private Dictionary<string, string> data = new Dictionary<string, string>();

        public Dictionary<string, string> GetAllData()
        {
            return data;
        }

        public string GetData(string key)
        {
            return data[key];
        }

        public void ReportData(string key, string value)
        {
            string temp;
            data.TryGetValue(key, out temp);
            if (temp == null)
                data.Add(key, value);
            else
                data[key] = value;
        }
    }
}
