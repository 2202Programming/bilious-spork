using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPILib;
using Pantheon;

namespace Pantheon.Components
{
    public class TimShooter : IControl
    {
        //Two main pnumatic wheels that control elevation
        Jaguar one;
        Jaguar two;

        //Small victor attached to the screw for elevation control
        Victor elevator;

        //Solinoid Activators on the Trigger
        DoubleSolenoid trigger;

        //Mode of Control it is in
        ControlMode mode;

        //Values for the Triggers to be set to
        private double oneSet;
        private double twoSet;
        private double elevatorSet;
        private DoubleSolenoid.Value triggerSet;

        public TimShooter()
        {
            one = new Jaguar(5);
            two = new Jaguar(6);

            elevator = new Victor(7);

            trigger = new DoubleSolenoid(0, 1);
        }

        

        private void Update()
        {
            switch (mode)
            {
                case ControlMode.Disabled:
                    one.Set(0.0);
                    two.Set(0.0);
                    elevator.Set(0.0);
                    trigger.Set(DoubleSolenoid.Value.Reverse);
                    break;
                case ControlMode.Enabled:
                    break;
            }
        }

        public override void TeleopInit()
        {
            Update();
        }
    }
}
