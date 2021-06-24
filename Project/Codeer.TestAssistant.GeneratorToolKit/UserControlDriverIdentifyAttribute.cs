using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attribute indicating that it is an extension method for getting UserControlDriver.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class UserControlDriverIdentifyAttribute : Attribute
    {
        /// <summary>
        /// Name of the method that supports UserControlDriver identification when generating capture code.
        /// T must be defined in the same class.
        /// The type is next.
        /// <para>public static UserControlDriver AttachFunction(this Driver driver, T identifier);</para>
        /// <para>public static T[] CustomFunction(Driver driver);</para>
        /// <para></para>
        /// <para>public static void AttachFunction(this Driver driver, T1 identifier1, T2 identifier2);</para>
        /// <para>public static void CustomFunction(this Driver driver, out T1[] identifier1, out T2[] identifier2);</para>
        /// </summary>
        public string CustomMethod { get; set; }
    }
}
