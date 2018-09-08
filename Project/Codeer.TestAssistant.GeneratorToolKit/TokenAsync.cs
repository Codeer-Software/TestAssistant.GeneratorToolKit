namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Asynchronous token. 
    /// When this token is included, an Async object will be used when a situation is deemed to need asynchronous execution . 
    /// Please use DebugMode class if you want to check the operations related to this token during tests while the generator is attached.
    /// </summary>
    public class TokenAsync
    {
        readonly CommaType _comma;
        readonly TokenAsyncType _asyncType;

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="comma">Comma.</param>
        public TokenAsync(CommaType comma)
        {
            _comma = comma;
            _asyncType = TokenAsyncType.Argument;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="asyncType">Async type.</param>
        /// <param name="comma">Comma.</param>
        public TokenAsync(TokenAsyncType asyncType, CommaType comma)
        {
            _asyncType = asyncType;
            _comma = comma;
        }

        /// <summary>
        /// Returns this object's string value.
        /// </summary>
        /// <returns>Token string value.</returns>
        public override string ToString()
        {
            if (string.IsNullOrEmpty(Name))
            {
                return string.Empty;
            }

            switch (_asyncType)
            {
                case TokenAsyncType.MethodSuffix:
                    return "Async";
                case TokenAsyncType.Declear:
                    return "var " + Name + " = ";
            }

            switch (_comma)
            {
                case CommaType.Non:
                    return Name;
                case CommaType.Before:
                    return ", " + Name;
                case CommaType.After:
                    return Name + ", ";
                default:
                    return Name;
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
            return (target == null) ? false : (Name == target.Name && _comma == target._comma);
        }
        
        /// <summary>
        /// Returns this object's hash code.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return ((Name == null) ? 0 : Name.GetHashCode()) + _comma.GetHashCode();
        }
    }
}
