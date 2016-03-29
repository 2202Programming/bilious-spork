using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPILib.Extras;
using WPILib;
using Pantheon;

namespace Pantheon.Components
{
    public class TimShooter : IComponent
    {
        
        /// <summary>
        /// Enum with values to decide on what is going on during the multiple activation modes
        /// could be updated in the future to include Encoder velocity senseing 
        /// </summary>
        enum FireingState //Enum to dictate current fireing status
        {
            readtToFire,
            fireing,
            reloading,
        }

        /// <summary>
        /// Current fireing mode of the Shooter only used during Teleoperated
        /// </summary>
        FireingState fstate;

        /// <summary>
        /// Timer used in conjunktion with the fireing state
        /// </summary>
        Timer t;

        /// <summary>
        /// Main source of input
        /// </summary>
        XboxController xbox;

        //Two jags
        /// <summary>First Jaguar</summary>
        Jaguar one;
        /// <summary>Second Jaguar</summary>
        Jaguar two;

        /// <summary>
        /// The motor controlling the giant scew on the main shooting platform
        /// </summary>
        Victor elevator;

        /// <summary>
        /// Double solinoid that controls the trigger mechanism
        /// </summary>
        DoubleSolenoid trigger;

        //Values for the Triggers to be set to
        private double wheelSet;
        private double elevatorSet;
        private DoubleSolenoid.Value triggerSet;

        //Values for the triggers to be set to in external control mode
        public double wheelExtSet;
        public double elevatorExtSet;
        public DoubleSolenoid.Value triggerExtSet;

        /// <summary>
        /// Basic Constructor for the Shooting Mechanism
        /// </summary>
        /// <param XboxController="nxbox"></param>
        public TimShooter(XboxController nxbox)
        {
            t = null;

            xbox = nxbox;

            mode = ControlMode.Disabled;

            one = new Jaguar(5);
            two = new Jaguar(6);

            elevator = new Victor(7);

            trigger = new DoubleSolenoid(0, 1);

            Zero();
        }
      
        /// <summary>
        /// Zeros all motor set values, including the Teleop Set, and autonomous ExtSet
        /// </summary>
        private void Zero()
        {
            fstate = FireingState.readtToFire;

            wheelSet = 0;
            elevatorSet = 0;
            triggerSet = DoubleSolenoid.Value.Off;

            wheelExtSet = 0;
            elevatorExtSet = 0;
            triggerExtSet = DoubleSolenoid.Value.Off;

        }

        /// <summary>
        /// Update method that applies the Set values to the motor based on the component Control Mode that is defined for all components
        /// </summary>
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
                case ControlMode.ExternalControl:
                    one.Set(wheelExtSet);
                    two.Set(wheelExtSet);
                    elevator.Set(elevatorExtSet);
                    trigger.Set(triggerExtSet);
                    break;
                case ControlMode.Enabled:
                    one.Set(wheelSet);
                    two.Set(wheelSet);
                    elevator.Set(elevatorSet);
                    trigger.Set(triggerSet);
                    break;
            }

            SmartWriter.WriteNumber("Wheel Speed", one.Get(), DebugMode.Debug);
            SmartWriter.WriteNumber("Elevator Speed", elevator.Get(), DebugMode.Debug);
            string x = "Trigger Value";
            switch (trigger.Get())
            {
                case DoubleSolenoid.Value.Forward:
                    SmartWriter.WriteString(x, "Forward", DebugMode.Debug);
                    break;
                case DoubleSolenoid.Value.Off:
                    SmartWriter.WriteString(x, "Off", DebugMode.Debug);
                    break;
                case DoubleSolenoid.Value.Reverse:
                    SmartWriter.WriteString(x, "Reverse", DebugMode.Debug);
                    break;
            }
        }

        /// <summary>
        /// Reads controller input we can make different methods based on different times and places and to save previous attemps
        /// </summary>
        private void ReadController()
        {

            //Controls the main spining wheels
            if(wheelSet == 0)
            {
                if (xbox.GetRightBumper()) wheelSet += .001;
            }
            else if( wheelSet == 1)
            {
                if (xbox.GetLeftBumper()) wheelSet -= 0.001;
            }
            else
            {
                if (xbox.GetLeftBumper()) wheelSet -= 0.001;
                if (xbox.GetRightBumper()) wheelSet += .001;
            }

            switch (fstate)
            {
                case FireingState.readtToFire:
                    SmartWriter.WriteString("Frisbee Fireing State", "Ready To Fire", DebugMode.Competition);
                    if (xbox.GetRightTrigger() > .5)
                    {
                        t = new Timer();
                        t.Start();
                        triggerSet = DoubleSolenoid.Value.Forward;
                        fstate = FireingState.fireing;
                    }
                    break;
                case FireingState.fireing:
                    SmartWriter.WriteString("Frisbee Fireing State", "Fireing", DebugMode.Competition);
                    if (t.Get() > 1)
                    {
                        t.Reset();
                        fstate = FireingState.reloading;
                    }
                    break;
                case FireingState.reloading:
                    SmartWriter.WriteString("Frisbee Fireing State", "Reloading", DebugMode.Competition);
                    if (t.Get() > 2)
                    {
                        t = null;
                        fstate = FireingState.readtToFire;
                    }
                    break;
            }
            
        }

        /// <summary>
        /// Zeros the values and set the control mode
        /// </summary>
        public override void TeleopInit()
        {
            Zero();
            Update();
            mode = ControlMode.Enabled;
        }

        /// <summary>
        /// Main Teleop Method reads controller and updates the methods
        /// </summary>
        public override void TeleopPeriodic()
        {
            ReadController();
            Update();
        }

        /// <summary>
        /// Resets all the motors and clears the mode
        /// </summary>
        public override void DisabledInit()
        {
            Zero();
            Update();
            mode = ControlMode.Disabled;
        }
    }
}
