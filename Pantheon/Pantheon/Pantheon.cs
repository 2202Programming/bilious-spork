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
                motor = new TalonMotor(0, 1, 2, 3);

                //Put all the created objects in the list
                storage.Add("Motor", motor);
            }

        }
        public override void DisabledInit()
        {
            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.DisabledInit();
            }
        }

        public override void DisabledPeriodic()
        {
            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.DisabledPeriodic();
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
            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.AutoPeriodic();
            }
        }

        public override void TeleopInit()
        {
            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.TeleopInit();
            }
        }

        public override void TeleopPeriodic()
        {
            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.TeleopPeriodic();
            }
        }

    }

}
