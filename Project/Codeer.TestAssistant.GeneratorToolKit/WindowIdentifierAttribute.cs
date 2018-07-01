using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// An attribute indicating that it is a WindowsAppFriend extension method for itself to obtain a window driver.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
	public class WindowIdentifierAttribute : Attribute
	{
        /// <summary>
        /// Window class.
        /// </summary>
        public string WindowClass { get; set; }

        /// <summary>
        /// .Net type full name.
        /// </summary>
        public string TypeFullName { get; set; }

        /// <summary>
        /// Window text.
        /// </summary>
        public string WindowText { get; set; }
    }
}
