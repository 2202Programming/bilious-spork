using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantheon.Service.Contract.Enums
{
    public enum RobotMode
    {
        [Description("Robot Init")]
        RobotInit,

        [Description("Disabled Init")]
        DisabledInit,

        [Description("Disabled Periodic")]
        DisabledPeriodic,

        [Description("Autonomous Init")]
        TeleoperatedInit,

        [Description("Teleoperated Periodic")]
        TeleoperatedPeriodic,

        [Description("Teleoperated Init")]
        AutonomousInit,

        [Description("Autonomous Periodic")]
        AutonomousPeriodic
    }
}
