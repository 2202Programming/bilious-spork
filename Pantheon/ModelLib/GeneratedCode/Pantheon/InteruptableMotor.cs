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

	public class InteruptableMotor : IMotor, IMotor
	{
		protected virtual double RightSet
		{
			get;
			set;
		}

		protected virtual double LeftSet
		{
			get;
			set;
		}

		public virtual MotorMode mode
		{
			get;
			set;
		}

		protected virtual void Update()
		{
			throw new System.NotImplementedException();
		}

	}
}

