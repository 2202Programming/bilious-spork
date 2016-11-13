﻿using System.Collections.Generic;
using System.ServiceModel;
using Olympus.ServiceContracts;

namespace Olympus.ServiceRealizations
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