using System;
using System.Collections.Generic;
using System.Linq;
using WPILib;
using WPILib.SmartDashboard;
using WPILib.Extras;

namespace Pantheon
{

    public class Pantheon : IterativeRobot
    {

        IMotor motor;
        XboxController xbox;
        IDrive drive;

        Dictionary<string, IControl> storage;

        public override void RobotInit()
        {
            storage = new Dictionary<string, IControl>();
            xbox = new XboxController(0);
            

            string name = "HERMES";
            name.ToUpper();

            if (name.Equals("HERMES".ToUpper()))
            {
                //Create all objects to add
                motor = new SparkMotor(0, 1, 2, 3);
                drive = new ArcadeDrive(xbox, motor);


                //Put all the created objects in the list
                storage.Add("Motor", motor);
                storage.Add("Drive", drive);
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
