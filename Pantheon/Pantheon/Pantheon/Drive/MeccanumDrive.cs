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
    using WPILib.Extras;


    public class MeccanumDrive : IControl
	{
		public virtual XboxController xbox
		{
			get;
			set;
		}

		private double LastLeft
		{
			get;
			set;
		}

		private double LastRight
		{
			get;
			set;
		}

		private IMotor motor
		{
			get;
			set;
		}

		public override void TeleopInit()
		{
			throw new System.NotImplementedException();
		}

		public override void TeleopPeriodic()
		{
			throw new System.NotImplementedException();
		}

		public override void AutoInit()
		{
			throw new System.NotImplementedException();
		}

		public override void AutoPeriodic()
		{
			throw new System.NotImplementedException();
		}

		public override void DisabledInit()
		{
			throw new System.NotImplementedException();
		}

		public override void RobotInit()
		{
			throw new System.NotImplementedException();
		}

		private void GetInput()
		{
			throw new System.NotImplementedException();
		}

		public MeccanumDrive(IMotor nmotor)
		{
		}

	}
}

