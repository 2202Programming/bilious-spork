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
    using WPILib;


    /// <summary>
    /// Class JaguarMotor.
    /// </summary>
    /// <seealso cref="Pantheon.IMotor" />
    public class JaguarMotor : IMotor
	{
        private Jaguar motor;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="JaguarMotor"/> is inverted.
        /// </summary>
        /// <value><c>true</c> if inverted; otherwise, <c>false</c>.</value>
        public override bool Inverted
        {
            get
            {
                return motor.Inverted;
            }

            set
            {
                motor.Inverted = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JaguarMotor"/> class.
        /// </summary>
        /// <param name="port">The port.</param>
        public JaguarMotor(int port)
        {
            motor = new Jaguar(port);
        }

        /// <summary>
        /// Applies this instance.
        /// </summary>
        protected override void Apply()
        {
            motor.Set(SetValue);
        }
    }
}

