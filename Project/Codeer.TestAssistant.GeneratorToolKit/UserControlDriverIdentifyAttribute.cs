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
        /// <para>public static UserControlDriver AttachFunction(this WindowDriver window, out T identifier);</para>
        /// <para>public static void CustomFunction(WindowDriver window, out T[] identifier);</para>
        /// </summary>
        public string CustomMethod { get; set; }
    }
}
