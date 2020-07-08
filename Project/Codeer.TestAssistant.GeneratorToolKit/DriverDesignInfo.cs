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

        /// <summary>
        /// attach extention class.
        /// </summary>
        public string AttachExtensionClass { get; set; }

        /// <summary>
        /// attach method.
        /// </summary>
        public string AttachMethod { get; set; }

        /// <summary>
        /// many exists.
        /// </summary>
        public bool ManyExists { get; set; }
    }
}
