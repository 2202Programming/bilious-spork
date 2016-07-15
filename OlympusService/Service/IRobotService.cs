using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IRobotService
    {

        [DataMember]
        Dictionary<string, string> Data { get; set; }

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string GetValue(string value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        RobotContainer GetRobotContainer(RobotContainer container);

        [OperationContract]
        void UpDateRobotContainers(RobotContainer container);
    }

    [DataContract]
    public class RobotContainer
    {
        string _name = "Tim";

        Dictionary<string, string> _controlObjects = new Dictionary<string, string>
        {
            {"Drive", "ArcadeDrive" },
            {"FrontLeftMotor", "FLM" },
        };

        Dictionary<string, string> _smartDashboardOutput = new Dictionary<string, string>
        {
            {"LeftMotorOutput", "0.0"},
            {"RightMotorOutput", "1.0"},
            {"Name", "Tim"},
            {"RobotState", "Enabled"},
        };

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public Dictionary<string, string> ControlObjects
        {
            get { return _controlObjects; }
            set { _controlObjects = value; }
        }

        [DataMember]
        public Dictionary<string, string> SmartDashboardOutput
        {
            get { return _smartDashboardOutput; }
            set { _smartDashboardOutput = value; }
        }
    }

    public enum RobotState
    {
        Disabled,
        Teleoperated,
        Autonomous,
        EBraked,
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
