using System;
using WPILib.Extras;
using WPILib;

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
            ReadyToFire,
            Fireing,
            Reloading,
        }

        /// <summary>
        /// Current fireing mode of the Shooter only used during Teleoperated
        /// </summary>
        FireingState _fstate;

        /// <summary>
        /// Timer used in conjunktion with the fireing state
        /// </summary>
        Timer _t;

        /// <summary>
        /// Main source of input
        /// </summary>
        XboxController xbox;

        /// <summary>
        /// First Jaguar
        /// </summary>
        Jaguar one;

        /// <summary>
        /// Second Jaguar
        /// </summary>
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
        private double _wheelSet;
        private double _elevatorSet;
        private DoubleSolenoid.Value _triggerSet;

        //Values for the triggers to be set to in external control mode
        public double WheelExtSet;
        public double ElevatorExtSet;
        public DoubleSolenoid.Value TriggerExtSet;

        /// <summary>
        /// Basic Constructor for the Shooting Mechanism
        /// </summary>
        /// <param XboxController="nxbox"></param>
        /// <param name="nxbox"></param>
        public TimShooter(XboxController nxbox)
        {
            _t = null;

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
            _fstate = FireingState.ReadyToFire;

            _wheelSet = 0;
            _elevatorSet = 0;
            _triggerSet = DoubleSolenoid.Value.Off;

            WheelExtSet = 0;
            ElevatorExtSet = 0;
            TriggerExtSet = DoubleSolenoid.Value.Off;

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
                    one.Set(WheelExtSet);
                    two.Set(WheelExtSet);
                    elevator.Set(ElevatorExtSet);
                    trigger.Set(TriggerExtSet);
                    break;
                case ControlMode.Enabled:
                    one.Set(_wheelSet);
                    two.Set(_wheelSet);
                    elevator.Set(_elevatorSet);
                    trigger.Set(_triggerSet);
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
            if(Math.Abs(_wheelSet) < .0005)
            {
                if (xbox.GetRightBumper()) _wheelSet += .001;
            }
            else if( Math.Abs(_wheelSet - 1) < .005)
            {
                if (xbox.GetLeftBumper()) _wheelSet -= 0.001;
            }
            else
            {
                if (xbox.GetLeftBumper()) _wheelSet -= 0.001;
                if (xbox.GetRightBumper()) _wheelSet += .001;
            }

            switch (_fstate)
            {
                case FireingState.ReadyToFire:
                    SmartWriter.WriteString("Frisbee Fireing State", "Ready To Fire", DebugMode.Competition);
                    if (xbox.GetRightTrigger() > .5)
                    {
                        _t = new Timer();
                        _t.Start();
                        _triggerSet = DoubleSolenoid.Value.Forward;
                        _fstate = FireingState.Fireing;
                    }
                    break;
                case FireingState.Fireing:
                    SmartWriter.WriteString("Frisbee Fireing State", "Fireing", DebugMode.Competition);
                    if (_t.Get() > 1)
                    {
                        _t.Reset();
                        _fstate = FireingState.Reloading;
                    }
                    break;
                case FireingState.Reloading:
                    SmartWriter.WriteString("Frisbee Fireing State", "Reloading", DebugMode.Competition);
                    if (_t.Get() > 2)
                    {
                        _t = null;
                        _fstate = FireingState.ReadyToFire;
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
