// ***********************************************************************
// Assembly         : Pantheon
// Author           : lazar
// Created          : 07-01-2016
//
// Last Modified By : lazar
// Last Modified On : 07-01-2016
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPILib;

namespace Pantheon.RobotDefinitions
{
    /// <summary>
    /// Class Tim.
    /// </summary>
    /// <seealso cref="Pantheon.RobotDefinitions.IDefinition" />
    public class Tim : IDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tim"/> class.
        /// </summary>
        public Tim() : base()
        { }

        /// <summary>
        /// Loads the name of the definition.
        /// </summary>
        /// <returns>System.String.</returns>
        protected override string LoadDefinitionName()
        {
            return "TIM";
        }

        /// <summary>
        /// Loads the manual properties. Override this method in the subclass in order to
        /// </summary>
        protected override void LoadManualProperties()
        {
            _properties = new Dictionary<string, string>()
            {
                {"FRONTLEFT", "0" },
                {"FRONTRIGHT", "1"},
                {"BACKLEFT", "2" },
                {"BACKRIGHT", "3" },
            };
        }

        /// <summary>
        /// Gets the control objects.
        /// </summary>
        /// <returns>Dictionary&lt;System.String, IControl&gt;.</returns>
        public override Dictionary<string, IControl> GetControlObjects()
        {
            var controlObjects = base.GetControlObjects();

            var motor = new SparkMotor(GetInt("FRONTLEFT"), GetInt("FRONTRIGHT"), GetInt("BACKLEFT"), GetInt("BACKRIGHT"));
            var drive = new ArcadeDrive(new WPILib.Extras.XboxController(0), motor);

            controlObjects.Add("IMotor", motor);
            controlObjects.Add("ArcadeDrive", drive);

            return controlObjects;
        }
    }
}
