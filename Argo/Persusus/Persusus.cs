using System;
using System.Collections.Generic;
using System.Linq;
using WPILib;
using WPILib.SmartDashboard;

namespace Persusus
{
    /// <summary>
    /// The VM is configured to automatically run this class, and to call the
    /// functions corresponding to each mode, as described in the IterativeRobot
    /// documentation. 
    /// </summary>
    public class Persusus : IterativeRobot
    {
        Compressor c;

        public override void RobotInit()
        {
            c = new Compressor();
        }

        public override void TeleopInit()
        {
            c.Start();
            Console.WriteLine("Enable Teleop");
        }

        public override void TeleopPeriodic()
        {
           
        }
    }
}
