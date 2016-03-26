using System;
using System.Collections.Generic;
using System.Linq;
using WPILib;
using WPILib.SmartDashboard;

namespace Pantheon
{

    public class Pantheon : IterativeRobot
    {

        IMotor motor;
        Dictionary<string, IControl> storage;

        public override void RobotInit()
        {
            storage = new Dictionary<string, IControl>();
            string name = "HERMES";
            name.ToUpper();

            if (name.Equals("HERMES".ToUpper()))
            {
                //Create all objects to add
                motor = new SparkMotor(0, 1, 2, 3);

                //Put all the created objects in the list
                storage.Add("Motor", motor);
            }

        }

        public override void AutonomousInit()
        {
            foreach(KeyValuePair<string,IControl> x in storage)
            {
                x.Value.AutoInit();
            }
        }

        public override void AutonomousPeriodic()
        {

        }

        public override void TeleopPeriodic()
        {

        }

        public override void TestPeriodic()
        {

        }
    }
}
