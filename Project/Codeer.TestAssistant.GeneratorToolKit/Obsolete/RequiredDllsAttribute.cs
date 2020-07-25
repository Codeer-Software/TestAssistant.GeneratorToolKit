using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attribute that specifies dll required at runtime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    public class RequiredDllsAttribute : Attribute
    {
        /// <summary>
        /// Attribute that specifies dll required at runtime.
        /// Separate by |.
        /// </summary>
        public string Dlls { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public RequiredDllsAttribute() { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="dlls">Attribute that specifies dll required at runtime.</param>
        public RequiredDllsAttribute(string dlls) => Dlls = dlls;
    }
}
