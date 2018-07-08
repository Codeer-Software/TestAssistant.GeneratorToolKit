using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// An attribute indicating that it is a WindowsAppFriend extension method for itself to obtain a WindowDriver.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
	public class WindowDriverIdentifyAttribute : Attribute
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

        /// <summary>
        /// Name of the method that supports Window identification when generating capture code.
        /// It must be defined in the same class.
        /// The type is next.
        /// static bool CustomFunction(WindowControl window, out T identifier);
        /// </summary>
        public string CustomMethod { get; set; }
    }
}
