using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantheon
{
    public class Global
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="Global"/> class from being created.
        /// </summary>
        private Global() { }

        /// <summary>
        /// The _instance
        /// </summary>
        private Global _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public Global Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Global();

                return _instance;
            }
        }

        /// <summary>
        /// Gets or sets the control objects.
        /// </summary>
        /// <value>
        /// The control objects.
        /// </value>
        public Dictionary<string, IControl> ControlObjects { get; set; } = new Dictionary<string, IControl>();

        /// <summary>
        /// The d mode
        /// </summary>
        public const DebugMode DMode = DebugMode.Full;

        /// <summary>
        /// The display console output
        /// </summary>
        public const bool DisplayConsoleOutput = true;

        /// <summary>
        /// The is automatic
        /// </summary>
        public const bool isAuto = false;
    }
}
