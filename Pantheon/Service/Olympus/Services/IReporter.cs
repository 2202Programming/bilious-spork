using System.ServiceModel;

namespace Pantheon.Olympus.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReporter" in both code and config file together.
    [ServiceContract]
    public interface IReporter
    {
        [OperationContract]
        void ReportGenericEvent();
    }
}
