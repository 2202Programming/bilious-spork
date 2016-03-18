using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WPILib;
using WPILib.SmartDashboard;


namespace Robot1
{
     public struct Global
    {
        public const int FLP = 0;
        public const int FRP = 1;
        public const int BLP = 2;
        public const int BRP = 3;

        public const int JOYSTICK_PIN = 0;
    }

    class ArcadeDrive
    {
        Joystick stick;
        Spark frontLeft, frontRight, backLeft, backRight;

        public ArcadeDrive()
        {

            stick = new Joystick(Global.JOYSTICK_PIN);

            frontRight = new Spark(Global.FRP);
            frontLeft = new Spark(Global.FLP);
            backLeft = new Spark(Global.BLP);
            backRight = new Spark(Global.BRP);
            Stop();

        }

        public void ActivateMotors(float right, float left)
        {
            frontLeft.Set(left);
            frontRight.Set(right);
            backLeft.Set(left);
            backRight.Set(right);
        }

        public void Stop()
        {
            ActivateMotors(0, 0);
        }

        public void RunArcadeDrive()
        {

        }

    }
}
