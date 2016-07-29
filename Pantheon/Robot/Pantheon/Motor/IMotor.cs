// ***********************************************************************
// Assembly         : Pantheon
// Author           : lazar
// Created          : 07-01-2016
//
// Last Modified By : lazar
// Last Modified On : 07-04-2016
// ***********************************************************************

namespace Pantheon.Motor
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

    /// <summary>
    /// Class IMotor.
    /// </summary>
    /// <seealso cref="Pantheon.IControl" />
    public abstract class IMotor : IControl
	{
        protected double SetValue;
        protected MotorMode mMode = MotorMode.Stopped;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IMotor"/> is inverted.
        /// </summary>
        /// <value><c>true</c> if inverted; otherwise, <c>false</c>.</value>
        public abstract bool Inverted { get; set; }

        /// <summary>
        /// Applies this instance.
        /// </summary>
        protected abstract void Apply();


        /// <summary>
        /// Sets the specified set.
        /// </summary>
        /// <param name="set">The set.</param>
        public void Set(double set)
        {
            SetValue = set;
        }

        /// <summary>
        /// Automatics the initialize.
        /// </summary>
        public override void AutoInit()
        {
            Set(0.0f);
            Apply();
            mMode = MotorMode.UserControl;
        }

        /// <summary>
        /// Automatics the periodic.
        /// </summary>
        public override void AutoPeriodic()
        {
            Apply();
        }

        /// <summary>
        /// Teleops the initialize.
        /// </summary>
        public override void TeleopInit()
        {
            Set(0.0f);
            Apply();
            mMode = MotorMode.UserControl;
        }

        /// <summary>
        /// Teleops the periodic.
        /// </summary>
        public override void TeleopPeriodic()
        {
            Apply();
        }

        /// <summary>
        /// Disableds the initialize.
        /// </summary>
        public override void DisabledInit()
        {
            Apply();
            mMode = MotorMode.Stopped;
        }
    }
}

