﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pantheon
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
    using WPILib;


    public class TalonMotor : InteruptableMotor
	{
		private Talon BackLeft
		{
			get;
			set;
		}

		private Talon BackRight
		{
			get;
			set;
		}

		private Talon FrontLeft
		{
			get;
			set;
		}

		private Talon FrontRight
		{
			get;
			set;
		}

        public TalonMotor(int FR, int FL, int BL, int BR)
        {
            mode = MotorMode.Stopped;



            BackLeft = new Talon(BL);
            BackRight = new Talon(BR);
            FrontLeft = new Talon(FL);
            FrontRight = new Talon(FR);
        }

		public override void Set(double left, double right)
		{
            LeftSet = left;
            RightSet = right;
		}

		public override void Stop()
		{
			throw new System.NotImplementedException();
		}

		public override void AutoInit()
		{
            LeftSet = 0.0;
            RightSet = 0.0;

            LeftExterior = 0.0;
            RightExterior = 0.0;

            mode = MotorMode.Auto;
            Update();
        }

        public override void AutoPeriodic()
		{
            Update();
            Drive();
		}

		public override void DisabledInit()
		{
            mode = MotorMode.Stopped;
        }

		public override void TeleopInit()
		{
            mode = MotorMode.UserControl;
			throw new System.NotImplementedException();
		}

		public override void TeleopPeriodic()
		{
			throw new System.NotImplementedException();
		}

		public override void RobotInit()
		{
            mode = MotorMode.Stopped;
		}

        public void Drive()
        {
            BackLeft.Set(LeftSet);
            FrontLeft.Set(LeftSet);

            BackRight.Set(RightSet);
            FrontRight.Set(RightSet);
            
            SmartWriter.WriteNumber("Left Set", LeftSet, Global.DMode);
            SmartWriter.WriteNumber("Right Set", RightSet, Global.DMode);
        }
	}
}

