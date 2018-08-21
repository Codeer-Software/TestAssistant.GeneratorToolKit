using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attribute to indicate that it is a control driver.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ControlDriverAttribute : Attribute
    {
        /// <summary>
        /// Window class name of the control corresponding to the driver.
        /// If there are more than one, please separate them with |.
        /// </summary>
        public string WindowClassName { get; set; }

        /// <summary>
        /// Type full name of the .Net class that the driver corresponds to.
        /// </summary>
        public string TypeFullName { get; set; }

        /// <summary>
        /// If more than one generator is assigned to the target ControlDriver, use the one with the higher priority.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Flag to go looking for descendant user controls.
        /// </summary>
        public bool SearchDescendantUserControls { get; set; }
    }
}
