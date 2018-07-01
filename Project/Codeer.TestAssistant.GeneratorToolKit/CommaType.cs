namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Can specify whether to add commas before or after a token during code generation.
    /// </summary>
    public enum CommaType
    {
        /// <summary>
        /// No comma.
        /// </summary>
        Non,
        
        /// <summary>
        /// Place a comma before the token.
        /// </summary>
        Before,

        /// <summary>
        /// Place a comma after the token.
        /// </summary>
        After,
    }
}
