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
        Spark s;

        public override void RobotInit()
        {
            c = new Compressor();
            s = new Spark(2);
        }

        public override void TeleopInit()
        {
            c.Start();
            Console.WriteLine("Enable Teleop");
            if (DriverStation.Instance.DSAtached)
            {
                Console.WriteLine("Driver Station is Attached");

            }


        }

        public override void TeleopPeriodic()
        {
            s.Set(.5);
        }
    }
}
