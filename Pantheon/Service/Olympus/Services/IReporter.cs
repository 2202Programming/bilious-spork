using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Olympus
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReporter" in both code and config file together.
    [ServiceContract]
    public interface IReporter
    {
        [OperationContract]
        void ReportGenericEvent();
    }
}
