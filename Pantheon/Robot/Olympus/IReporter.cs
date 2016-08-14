using System.Collections.Generic;
using System.ServiceModel;

namespace Olympus
{
    [ServiceContract]
    public interface IReporter
    {
        [OperationContract]
        void ReportData(string key, string value);

        [OperationContract]
        string GetData(string key);

        [OperationContract]
        Dictionary<string, string> GetAllData();
    }
}
