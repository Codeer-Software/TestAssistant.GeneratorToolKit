namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Driver property info.
    /// </summary>
    public class DriverPropertyInfo
    {
        /// <summary>
        /// is it a complete identification method?
        /// </summary>
        public bool? IsPerfect { get; set; }

        /// <summary>
        /// element.
        /// </summary>
        public object Element { get; set; }
        
        /// <summary>
        /// type full name.
        /// </summary>
        public string TypeFullName { get; set; }

        /// <summary>
        /// name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// identification code.
        /// </summary>
        public string Identify { get; set; }
    }
}
