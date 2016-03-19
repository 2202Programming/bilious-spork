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

        /*
        	const static int frontLeftChannel = 2;
	const static int rearLeftChannel = 4;
	const static int frontRightChannel = 1;
	const static int rearRightChannel = 3;
        */
        public const int FLP = 2;
        public const int FRP = 1;
        public const int BLP = 4;
        public const int BRP = 3;

        public const int JOYSTICK_PIN = 0;
    }

    class ArcadeDrive
    {
        Joystick stick;
        Talon frontLeft, frontRight, backLeft, backRight;
        Timer t;

        public ArcadeDrive()
        {
            t = new Timer();

            stick = new Joystick(Global.JOYSTICK_PIN);

            frontRight = new Talon(Global.FRP);
            frontLeft = new Talon(Global.FLP);
            backLeft = new Talon(Global.BLP);
            backRight = new Talon(Global.BRP);
            Stop();

        }

        public void ActivateMotors(double right, double left)
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

        /// <summary>
        /// Starts the Timer Back to zero and clears any already existing time from it
        /// </summary>
        public void initTimer()
        {
            t.Stop();
            t.Reset();
            t.Start();
        }

        /// <summary>
        /// Checks weather or not the timer is on an even number
        /// </summary>
        /// <returns>Bool Odd</returns>
        public bool EvenNumber()
        {
            if (t.Get() % 2 == 1) return true;
            return false;
        }

        /// <summary>
        /// Rumbles the controller on and off every other secend
        /// </summary>
        public void Rumbler()
        {

                stick.SetRumble(Joystick.RumbleType.LeftRumble, (float)1.0);
                stick.SetRumble(Joystick.RumbleType.RightRumble, (float)1.0);
           
        }

        public void EndRumbler()
        {

            stick.SetRumble(Joystick.RumbleType.LeftRumble, (float)0);
            stick.SetRumble(Joystick.RumbleType.RightRumble, (float)0);

        }

        /// <summary>
        /// Arcade Drive Runner
        /// </summary>
        public void RunArcadeDrive()
        {
            //Gets the two motors from the current stick
            double x = stick.GetAxis(Joystick.AxisType.X);
            double y = stick.GetAxis(Joystick.AxisType.Y);

            //Deadsticking the two axises
            if (Math.Abs(x) < .1) x = 0;
            if (Math.Abs(y) < .1) y = 0;

            //Shortsticking
            y *= .8;

            double leftSpeed, rightSpeed;
            leftSpeed = x - y;
            rightSpeed = x + y;

            //Driveing Motors
            ActivateMotors(rightSpeed, leftSpeed);
        }

    }
}
