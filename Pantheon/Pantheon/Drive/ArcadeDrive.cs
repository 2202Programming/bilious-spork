using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pantheon.Components;
using Pantheon.Motor;
using WPILib.Extras;
using WPILib;

namespace Pantheon.Drive
{
    /// <summary>
    /// Arcade drive class
    /// </summary>
    /// <seealso cref="Pantheon.Components.IComponent" />
    class ArcadeDrive : IComponent
    {
        #region Constructors        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ArcadeDrive"/> class.
        /// </summary>
        /// <param name="fl">The Front Left Motor.</param>
        /// <param name="fr">The Front Right Motor.</param>
        /// <param name="bl">The Back Left Motor.</param>
        /// <param name="br">The Back Right Motor.</param>
        /// <param name="xb">A instance of the Xbox Controller.</param>
        public ArcadeDrive(IMotor fl, IMotor fr, IMotor bl, IMotor br, XboxController xb)
        {
            _frontLeft = fl;
            _frontRight = fr;
            _backLeft = bl;
            _backRight = br;

            xbox = xb;
        }

        #endregion
       
        #region Fields

        private float _frontLeftSet;
        private float _frontRightSet;
        private float _backLeftSet;
        private float _backRightSet;

        private IMotor _frontLeft;
        private IMotor _frontRight;
        private IMotor _backLeft;
        private IMotor _backRight;

        private XboxController xbox;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the front left set.
        /// </summary>
        /// <value>
        /// The front left set.
        /// </value>
        public float FrontLeftSet {
            get { return _frontLeftSet; }
            set
            {
                if (mode == ControlMode.ExternalControl)
                    _frontLeftSet = value;
            }
        }

        /// <summary>
        /// Gets or sets the front right set.
        /// </summary>
        /// <value>
        /// The front right set.
        /// </value>
        public float FrontRightSet
        {
            get { return _frontRightSet; }
            set
            {
                if (mode == ControlMode.ExternalControl)
                    _frontRightSet = value;
            }
        }

        /// <summary>
        /// Gets or sets the back left set.
        /// </summary>
        /// <value>
        /// The back left set.
        /// </value>
        public float BackLeftSet
        {
            get { return _backLeftSet; }
            set
            {
                if (mode == ControlMode.ExternalControl)
                    _backLeftSet = value;
            }
        }

        /// <summary>
        /// Gets or sets the back right set.
        /// </summary>
        /// <value>
        /// The back right set.
        /// </value>
        public float BackRightSet
        {
            get { return _frontLeftSet; }
            set
            {
                if (mode == ControlMode.ExternalControl)
                    _backRightSet = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Teleops the initialize.
        /// </summary>
        public override void TeleopInit()
        {
            base.TeleopInit();

            SmartWriter.WriteString("Arcade Drive Mode", "Starting", DebugMode.Competition);
            Zero();
        }

        /// <summary>
        /// Main runner for the entire teleop mode.
        /// </summary>
        public override void TeleopPeriodic()
        {
            base.TeleopPeriodic();

            SmartWriter.WriteString("Arcade Drive Mode", "Running", DebugMode.Competition);
            ReadXboxInput();
            RunMotors();
        }

        /// <summary>
        /// IControl overide for Disabled Init Method.
        /// </summary>
        public override void DisabledInit()
        {
            base.DisabledInit();

            SmartWriter.WriteString("Arcade Drive Mode", "Idle", DebugMode.Competition);
            Zero();
        }

        /// <summary>
        /// Zeros the motors
        /// </summary>
        private void Zero()
        {
            _backRightSet = 0.0f;
            _backLeftSet = 0.0f;
            _frontLeftSet = 0.0f;
            _frontRightSet = 0.0f;

            RunMotors();
        }

        /// <summary>
        /// Runs the motors.
        /// </summary>
        private void RunMotors()
        {
            SmartWriter.WriteString("FrontRightMotor", "", DebugMode.Debug);
            SmartWriter.WriteString("FrontLeftMotor", "", DebugMode.Debug);
            SmartWriter.WriteString("BackRightMotor", "", DebugMode.Debug);
            SmartWriter.WriteString("BackLeftMotor", "", DebugMode.Debug);

            _frontLeft.Set(_frontLeftSet);
            _frontRight.Set(_frontRightSet);
            _backLeft.Set(_backLeftSet);
            _backRight.Set(_backRightSet);
        }


        /// <summary>
        /// Reads the xbox input.
        /// </summary>
        private void ReadXboxInput()
        {
            // Getting X and Y axis from the Xbox
            float x = (float)xbox.GetLeftXAxis();
            float y = (float)xbox.GetLeftYAxis();

            //Dead sticking 
            if (Math.Abs(x) < .16)
                x = 0;

            if (Math.Abs(y) < .16)
                y = 0;

            // Transforming x and y values into set values for each side
            var left = y;
            var right = y;

            left -= x;
            right += x;

            // Set Motor values to each side
            _frontLeftSet = left;
            _backLeftSet = left;

            _frontRightSet = right;
            _backRightSet = right;
        }
                
        #endregion
    }
}
