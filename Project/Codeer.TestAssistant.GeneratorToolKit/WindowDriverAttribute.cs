using System;
using System.Collections.Generic;
using System.Text;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attribute to indicate that it is a window driver.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class WindowDriverAttribute : Attribute
    {
        /// <summary>
        /// Type full name of the .Net class that the driver corresponds to.
        /// </summary>
        public string TypeFullName { get; set; }
    }
}
