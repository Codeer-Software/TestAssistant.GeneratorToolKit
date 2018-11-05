using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Control driver info.
    /// </summary>
    [Serializable]
    public class ControlDriverInfo
    {
        /// <summary>
        /// ControlDriver type full name.
        /// </summary>
        public string ControlDriverTypeFullName { get; set; }

        /// <summary>
        /// Flag to go looking for descendant user controls.
        /// </summary>
        public bool SearchDescendantUserControls { get; set; }

        /// <summary>
        /// Whether mapping at driver generation is valid.
        /// </summary>
        public bool DriverMappingEnabled { get; set; } = true;
    }
}
