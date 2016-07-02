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
            Console.WriteLine(Components.ControlMode.ExternalControl.ToString() );

            SmartWriter.WriteString("Robot Mode", "RobotInit", DebugMode.Competition);

            storage = new Dictionary<string, IControl>();
            xbox = new XboxController(0);
            

            string name = "HERMES";
            name.ToUpper();

            if (name == "HERMES")
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
            SmartWriter.WriteString("Robot Mode", "DisabledInit", DebugMode.Competition);
            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.DisabledInit();
            }
        }

        public override void DisabledPeriodic()
        {
            SmartWriter.WriteString("Robot Mode", "DisabledPeriodic", DebugMode.Competition);

            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.DisabledPeriodic();
            }
        }

        public override void AutonomousInit()
        {
            SmartWriter.WriteString("Robot Mode", "AutonomousInit", DebugMode.Competition);

            foreach (KeyValuePair<string,IControl> x in storage)
            {
                x.Value.AutoInit();
            }
        }

        public override void AutonomousPeriodic()
        {
            SmartWriter.WriteString("Robot Mode", "AutonomousPeriodic", DebugMode.Competition);

            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.AutoPeriodic();
            }
        }

        public override void TeleopInit()
        {
            SmartWriter.WriteString("Robot Mode", "TeleopInit", DebugMode.Competition);

            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.TeleopInit();
            }
        }

        public override void TeleopPeriodic()
        {
            SmartWriter.WriteString("Robot Mode", "TeleopPeriodic", DebugMode.Competition);

            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.TeleopPeriodic();
            }
        }

    }

}
