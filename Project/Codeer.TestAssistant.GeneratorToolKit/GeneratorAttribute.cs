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
    }
}
