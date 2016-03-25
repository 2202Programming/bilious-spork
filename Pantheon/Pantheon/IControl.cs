using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IControl
{
    public abstract class IControl
    {
        public abstract void TeleopInit();

        public abstract void TeleopPeriodic();

        public abstract void AutoInit();

        public abstract void AutoPeriodic();


    }
}
