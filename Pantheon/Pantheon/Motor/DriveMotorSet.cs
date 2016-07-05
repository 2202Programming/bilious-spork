// ***********************************************************************
// Assembly         : Pantheon
// Author           : lazar
// Created          : 07-04-2016
//
// Last Modified By : lazar
// Last Modified On : 07-04-2016
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantheon.Motor
{
    /// <summary>
    /// Class DriveMotorSet.
    /// </summary>
    /// <seealso cref="Pantheon.IControl" />
    class DriveMotorSet : IControl
    {
        private IMotor backRight;
        private IMotor backLeft;
        private IMotor frontLeft;
        private IMotor frontRight;

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMotorSet"/> class.
        /// </summary>
        /// <param name="_br">The _BR.</param>
        /// <param name="_bl">The _BL.</param>
        /// <param name="_fl">The _FL.</param>
        /// <param name="_fr">The _FR.</param>
        public DriveMotorSet(IMotor _br, IMotor _bl, IMotor _fl, IMotor _fr)
        {
            backLeft = _bl;
            backRight = _br;
            frontLeft = _fl;
            frontRight = _fr;

            backLeft.Inverted = true;
            frontLeft.Inverted = true;           
        }

        /// <summary>
        /// Sets the specified left.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        public void Set(double left, double right)
        {
            backLeft.Set(left);
            frontLeft.Set(left);

            backRight.Set(right);
            frontRight.Set(right);
        }


    }
}
