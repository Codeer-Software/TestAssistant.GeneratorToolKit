namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Driver identify info.
    /// </summary>
    public class DriverIdentifyInfo
    {
        /// <summary>
        /// is it a complete identification method?
        /// </summary>
        public bool IsPerfect { get; set; }

        /// <summary>
        /// identification code.
        /// </summary>
        public string Identify { get; set; }
        
        /// <summary>
        /// default name.
        /// </summary>
        public string DefaultName { get; set; }
    }
}
