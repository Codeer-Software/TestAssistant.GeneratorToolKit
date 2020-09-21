using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attribute indicating that it is an extension method for getting ControlDriver.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class ControlDriverIdentifyAttribute : Attribute
    {
        /// <summary>
        /// Name of the method that supports ControlDriver identification when generating capture code.
        /// T must be defined in the same class.
        /// The type is next.
        /// <para>public static ControlDriver AttachFunction(this Driver driver, out T identifier);</para>
        /// <para>public static T[] CustomFunction(Driver driver);</para>
        /// </summary>
        public string CustomMethod { get; set; }
    }
}
