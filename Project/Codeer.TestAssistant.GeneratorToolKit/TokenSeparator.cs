namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// A separator token. 
    /// Can be added as the only token in a Sentence to produce a blank line. 
    /// Optimized to a single line when multiple TokenSeparators occur together.
    /// </summary>
    public class TokenSeparator 
    {
        /// <summary>
        /// Returns this object's string value.
        /// </summary>
        /// <returns>Token string value.</returns>
        public override string ToString()
        {
            return string.Empty;
        }
    }
}
