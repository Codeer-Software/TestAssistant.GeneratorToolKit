namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// A name token. 
    /// Used as a variable name when added to a generator.
    /// </summary>
    public class TokenName
    {
        string _name = string.Empty;
       
        /// <summary>
        /// The name.
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }
       
        /// <summary>
        /// Returns this object's string value.
        /// </summary>
        /// <returns>Token string value.</returns>
        public override string ToString()
        {
            return _name;
        }

        /// <summary>
        /// Tests equality.
        /// </summary>
        /// <param name="obj">Object to compare against.</param>
        /// <returns>Comparison result.</returns>
        public override bool Equals(object obj)
        {
            TokenName target = obj as TokenName;
            return (target == null) ? false : _name == target._name;
        }
        
        /// <summary>
        /// Returns this object's hash code.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return (_name == null) ? 0 : _name.GetHashCode();
        }
    }
}
