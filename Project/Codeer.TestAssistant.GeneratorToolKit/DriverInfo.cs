using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Driver info.
    /// </summary>
    public static class DriverInfo
    {
        /// <summary>
        /// Window class name and control driver info dictionary.
        /// </summary>
        public static Dictionary<string, ControlDriverInfo> WindowClassNameAndControlDriver { get; set; } = new Dictionary<string, ControlDriverInfo>();

        /// <summary>
        /// .Net type full name and control driver info dictionary.
        /// </summary>
        public static Dictionary<string, ControlDriverInfo> NetTypeAndControlDriver { get; set; } = new Dictionary<string, ControlDriverInfo>();

        /// <summary>
        /// .Net type full name and mapping driver info dictionary.
        /// </summary>
        public static Dictionary<string, MappingDriverInfo> NetTypeAndMappingDriverTypeFullName { get; set; } = new Dictionary<string, MappingDriverInfo>();

        /// <summary>
        /// Window class name and mapping driver info dictionary.
        /// </summary>
        public static Dictionary<string, MappingDriverInfo> WindowClassNameAndMappingDriverTypeFullName { get; set; } = new Dictionary<string, MappingDriverInfo>();

        /// <summary>
        /// Window text and mapping driver info dictionary.
        /// </summary>
        public static Dictionary<string, MappingDriverInfo> WindowTextAndMappingDriverTypeFullName { get; set; } = new Dictionary<string, MappingDriverInfo>();
    }
}
