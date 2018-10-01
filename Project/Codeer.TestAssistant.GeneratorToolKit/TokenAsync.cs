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
        readonly string _textWhenNormal;
        readonly string _textWhenAsync;

        /// <summary>
        /// Async type.
        /// </summary>
        public TokenAsyncType AsyncType { get; set; }

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
            AsyncType = TokenAsyncType.Argument;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="asyncType">Async type.</param>
        /// <param name="comma">Comma.</param>
        public TokenAsync(TokenAsyncType asyncType, CommaType comma)
        {
            AsyncType = asyncType;
            _comma = comma;
        }

        /// <summary>
        /// Constructor for TokenAsyncType is 
        /// </summary>
        /// <param name="textWhenNormal">when not use async.</param>
        /// <param name="textWhenAsync">When use async.</param>
        public TokenAsync(string textWhenNormal, string textWhenAsync)
        {
            AsyncType = TokenAsyncType.Replace;
            _textWhenNormal = textWhenNormal;
            _textWhenAsync = textWhenAsync;
        }

        /// <summary>
        /// Returns this object's string value.
        /// </summary>
        /// <returns>Token string value.</returns>
        public override string ToString()
        {
            if (AsyncType == TokenAsyncType.Replace)
            {
                return string.IsNullOrEmpty(Name) ? _textWhenNormal : _textWhenAsync;
            }

            if (string.IsNullOrEmpty(Name))
            {
                return string.Empty;
            }

            switch (AsyncType)
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
