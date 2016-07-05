using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantheon.Motor
{
    class DriveMotorSet : IControl
    {
        private IMotor backRight;
        private IMotor backLeft;
        private IMotor frontLeft;
        private IMotor frontRight;

        public DriveMotorSet(IMotor _br, IMotor _bl, IMotor _fl, IMotor _fr)
        {
            backLeft = _bl;
            backRight = _br;
            frontLeft = _fl;
            frontRight = _fr;

            backLeft.Inverted = true;
            frontLeft.Inverted = true;           
        }

        public void Set(double left, double right)
        {
            backLeft.Set(left);
            frontLeft.Set(left);

            backRight.Set(right);
            frontRight.Set(right);
        }
    }
}
