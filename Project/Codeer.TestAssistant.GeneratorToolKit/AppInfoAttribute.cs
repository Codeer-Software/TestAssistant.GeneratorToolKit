using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Information on the application to be connected.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Field| AttributeTargets.Property)]
    public class AppInfoAttribute : Attribute
    {
        /// <summary>
        /// Name of the application.
        /// </summary>
        public string Name { get; set; }
    }
}
