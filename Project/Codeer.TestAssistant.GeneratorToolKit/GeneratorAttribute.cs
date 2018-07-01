using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attribute to indicate that it is a generator.
    /// </summary>
    public class GeneratorAttribute : Attribute
    {
        /// <summary>
        /// TypeFullName of the corresponding ControlDriver.
        /// </summary>
        public string ControlDriverTypeFullName { get; set; }

        /// <summary>
        /// If more than one generator is assigned to the target ControlDriver, use the one with the higher priority.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public GeneratorAttribute() { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="controlDriverTypeFullName">TypeFullName of the corresponding ControlDriver.</param>
        public GeneratorAttribute(string controlDriverTypeFullName)
        {
            ControlDriverTypeFullName = controlDriverTypeFullName;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="controlDriverTypeFullName">TypeFullName of the corresponding ControlDriver.</param>
        /// <param name="priority">If more than one generator is assigned to the target ControlDriver, use the one with the higher priority.</param>
        public GeneratorAttribute(string controlDriverTypeFullName, int priority)
        {
            ControlDriverTypeFullName = controlDriverTypeFullName;
            Priority = priority;
        }
    }
}
