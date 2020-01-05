using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Window driver info.
    /// </summary>
    [Serializable]
    public class WindowDriverInfo
    {
        /// <summary>
        /// Driver type full name.
        /// </summary>
        public string DriverTypeFullName { get; set; }

        /// <summary>
        /// Constructor Arguments.
        /// </summary>
        public string[][] ConstructorArguments { get; set; } = new string[0][];
    }
}
