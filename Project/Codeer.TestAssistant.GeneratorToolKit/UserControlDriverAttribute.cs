using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attribute to indicate that it is a user control driver.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class UserControlDriverAttribute : Attribute
    {
        /// <summary>
        /// Type full name of the .Net class that the driver corresponds to.
        /// </summary>
        public string TypeFullName { get; set; }
    }
}
