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

	public class TalonMotor : InteruptableMotor, IControl
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

		protected override void Update()
		{
			throw new System.NotImplementedException();
		}

		public virtual void Set(double right, double left)
		{
			throw new System.NotImplementedException();
		}

		public virtual void Stop()
		{
			throw new System.NotImplementedException();
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

	}
}

