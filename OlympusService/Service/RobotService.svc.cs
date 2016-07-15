using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RobotService : IRobotService
    {
        private Dictionary<string, string> storeage = new Dictionary<string, string>
        {
            {"Hello", "World" },
            {"Goodby", "Dan" },
        };

        private List<RobotContainer> Robots = new List<RobotContainer>
        {
            new RobotContainer
            {
                Name = "Tim",
                ControlObjects = new Dictionary<string, string>
                {
                    {"Shooter", "TimShooter" },
                    {"Drive", "ArcadeDrive" },
                    {"IMotor", "FLM" }
                },
                SmartDashboardOutput = new Dictionary<string, string>
                {
                    {"LeftMotorOutput", "0.0" },
                    {"RightMotorOutput", "0.5" },
                }                
            }
        };

        private Dictionary<string, string> _data;

        public Dictionary<string, string> Data
        {
            get
            {
                return _data;
            }

            set
            {
                if (value != _data)
                    _data = value;
            }
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetValue(string value)
        {
            return storeage.FirstOrDefault(x => x.Key == value).Value;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public RobotContainer GetRobotContainer(RobotContainer container)
        {
            return Robots.FirstOrDefault(x => x.Name == container.Name);
        }

        public void UpDateRobotContainers(RobotContainer container)
        {
            var oldBot = Robots.FirstOrDefault(x => x.Name == container.Name);
            if (oldBot == null)
                Robots.Add(container);
            else
                oldBot = container;
        }
    }
}
