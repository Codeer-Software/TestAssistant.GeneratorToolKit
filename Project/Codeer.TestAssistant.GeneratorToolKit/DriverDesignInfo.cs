namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Driver design info
    /// </summary>
    public class DriverDesignInfo
    {
        /// <summary>
        /// class name.
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// properties
        /// </summary>
        public DriverPropertyInfo[] Properties { get; set; }

        /// <summary>
        /// do you create attach code.
        /// </summary>
        public bool CreateAttachCode { get; set; }
    }
}
