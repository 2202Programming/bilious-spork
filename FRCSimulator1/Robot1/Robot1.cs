using System;
using System.Collections.Generic;
using System.Linq;
using WPILib;
using WPILib.SmartDashboard;

namespace Robot1
{
    /// <summary>
    /// The VM is configured to automatically run this class, and to call the
    /// functions corresponding to each mode, as described in the IterativeRobot
    /// documentation. 
    /// </summary>
    public class Robot1 : IterativeRobot
    {
        ArcadeDrive drive;
        Compressor c;

        public override void RobotInit()
        {
            drive = new ArcadeDrive();
            c = new Compressor();
        }

        public override void AutonomousInit()
        {

        }

        public override void AutonomousPeriodic()
        {
           
        }

        public override void TeleopInit()
        {
            c.Start();
            drive.initTimer();
        }

        public override void TeleopPeriodic()
        {
            SmartDashboard.PutBoolean("Commpressor Value", c.GetPressureSwitchValue());
            drive.RunArcadeDrive();
            drive.Rumbler();
        }

        public override void DisabledInit()
        {
            base.DisabledInit();
            drive.EndRumbler();
        }

        public override void TestPeriodic()
        {

        }
    }
}
