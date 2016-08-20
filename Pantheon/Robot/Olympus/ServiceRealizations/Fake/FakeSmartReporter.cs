using Olympus.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympus.ServiceRealizations.Fake
{
    class FakeSmartReporter : IReporter
    {
        Dictionary<string, string> Data = new Dictionary<string, string>();

        public Dictionary<string, string> GetAllData()
        {
            return Data;
        }

        public string GetData(string key)
        {
            return Data[key];
        }

        public void ReportData(string key, string value)
        {
            try
            {
                Data[key] = value;
            }
            catch
            {
                Data.Add(key, value);
            }
        }
    }
}
