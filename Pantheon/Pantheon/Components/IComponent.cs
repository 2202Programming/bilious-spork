using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantheon.Components
{
    /// <summary>
    /// Basic Inharited source for all components and should be inharited, and also have more stuff
    /// </summary>
    public class IComponent : IControl
    {
        public ControlMode mode;
    }
}
