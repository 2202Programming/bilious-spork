// ***********************************************************************
// Assembly         : Pantheon
// Author           : lazar
// Created          : 03-26-2016
//
// Last Modified By : lazar
// Last Modified On : 07-01-2016
// ***********************************************************************


using System;
using System.Collections.Generic;
using WPILib;
using Pantheon.RobotDefinitions;

namespace Pantheon
{

    /// <summary>
    /// Class Pantheon.
    /// </summary>
    /// <seealso cref="WPILib.IterativeRobot" />
    public class Pantheon : IterativeRobot
    {

        Tim tim;
        Dictionary<string, IControl> storage;

        /// <summary>
        /// Robot-wide initialization code should go here.
        /// </summary>
        public override void RobotInit()
        {
            Console.WriteLine(Components.ControlMode.ExternalControl.ToString() );
            SmartWriter.WriteString("Robot Mode", "RobotInit", DebugMode.Competition);

            string name = "HERMES";
            name.ToUpper();

            if (name == "HERMES")
            {
                tim = new Tim();
                storage = tim.GetControlObjects();
            }

            if (storage == null)
                storage = new Dictionary<string, IControl>();

        }

        /// <summary>
        /// Initialization code for disabled mode should go here.
        /// </summary>
        public override void DisabledInit()
        {
            SmartWriter.WriteString("Robot Mode", "DisabledInit", DebugMode.Competition);
            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.DisabledInit();
            }
        }

        /// <summary>
        /// Periodic code for disabled mode should go here.
        /// </summary>
        public override void DisabledPeriodic()
        {
            SmartWriter.WriteString("Robot Mode", "DisabledPeriodic", DebugMode.Competition);

            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.DisabledPeriodic();
            }
        }

        /// <summary>
        /// Initialization code for autonomous mode should go here.
        /// </summary>
        public override void AutonomousInit()
        {
            SmartWriter.WriteString("Robot Mode", "AutonomousInit", DebugMode.Competition);

            foreach (KeyValuePair<string,IControl> x in storage)
            {
                x.Value.AutoInit();
            }
        }

        /// <summary>
        /// Periodic code for autonomous mode should go here.
        /// </summary>
        public override void AutonomousPeriodic()
        {
            SmartWriter.WriteString("Robot Mode", "AutonomousPeriodic", DebugMode.Competition);

            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.AutoPeriodic();
            }
        }

        /// <summary>
        /// Initialization for teleop mode should go here.
        /// </summary>
        public override void TeleopInit()
        {
            SmartWriter.WriteString("Robot Mode", "TeleopInit", DebugMode.Competition);

            foreach (KeyValuePair<string, IControl> x in storage)
            {
                x.Value.TeleopInit();
            }
        }

        /// <summary>
        /// Periodic code for teleop mode should go here.
        /// </summary>
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
