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

        public override void RobotInit()
        {
            drive = new ArcadeDrive();
        }

        public override void AutonomousInit()
        {

        }

        public override void AutonomousPeriodic()
        {
           
        }

        public override void TeleopPeriodic()
        {
            drive.RunArcadeDrive();
        }

        public override void TestPeriodic()
        {

        }
    }
}
