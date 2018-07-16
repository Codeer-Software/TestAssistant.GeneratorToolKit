using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// An attribute indicating that it is a WindowDriver extension method for itself to obtain a UserControlDriver.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class UserControlDriverIdentifyAttribute : Attribute
    {
        /// <summary>
        /// Name of the method that supports UserControl identification when generating capture code.
        /// It must be defined in the same class.
        /// The type is next.
        /// static UserControlDriver[] CustomFunction(WindowDriver window, out T[] identifier);
        /// </summary>
        public string CustomMethod { get; set; }
    }
}
