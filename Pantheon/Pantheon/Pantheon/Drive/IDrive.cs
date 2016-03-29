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
    using WPILib;

	public class IDrive : IControl
	{
        public IDrive(XboxController nxbox , IMotor nmotor)
        {
            xbox = nxbox;
            motor = nmotor;
            left = 0;
            right = 0;
        }

		public XboxController xbox
		{
			get;
			set;
		}

		private IMotor motor
		{
			get;
			set;
		}

		private double left
		{
			get;
			set;
		}

		private double right
		{
			get;
			set;
		}

        private void Update()
        {
            motor.Set(right, left);
        }

        public override void DisabledInit()
        {
            left = 0;
            right = 0;
            Update();
        }

        public override void TeleopInit()
		{
            left = 0;
            right = 0;
            Update();
		}

		public override void TeleopPeriodic()
		{
            Update();
		}

	}
}
