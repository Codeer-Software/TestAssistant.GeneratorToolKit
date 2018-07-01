namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Asynchronous token. 
    /// When this token is included, an Async object will be used when a situation is deemed to need asynchronous execution . 
    /// Please use DebugMode class if you want to check the operations related to this token during tests while the generator is attached.
    /// </summary>
    public class TokenAsync
    {
        CommaType _comma;
        string _name = string.Empty;
        
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="comma">Comma.</param>
        public TokenAsync(CommaType comma)
        {
            _comma = comma;
        }
        
        /// <summary>
        /// Returns this object's string value.
        /// </summary>
        /// <returns>Token string value.</returns>
        public override string ToString()
        {
            if (string.IsNullOrEmpty(_name))
            {
                return string.Empty;
            }
            switch (_comma)
            {
                case CommaType.Non:
                    return _name;
                case CommaType.Before:
                    return ", " + _name;
                case CommaType.After:
                    return _name + ", ";
                default:
                    return _name;
            }
        }
        
        /// <summary>
        /// Tests equality.
        /// </summary>
        /// <param name="obj">Object to compare against.</param>
        /// <returns>Comparison result.</returns>
        public override bool Equals(object obj)
        {
            TokenAsync target = obj as TokenAsync;
            return (target == null) ? false : (_name == target._name && _comma == target._comma);
        }
        
        /// <summary>
        /// Returns this object's hash code.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return ((_name == null) ? 0 : _name.GetHashCode()) + _comma.GetHashCode();
        }
    }
}
