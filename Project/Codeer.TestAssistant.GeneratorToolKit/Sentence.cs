namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Represents a set of items related to code generation. 
    /// A sentence contains multiple tokens. 
    /// Tokens are represented as objects, but you can use any class, value, or structure. 
    /// The objects' ToString() values are treated as their code. 
    /// However, a few types are treated as having special meaning: TokenAsyn, TokenName, and TokenSeparator.
    /// </summary>
    public class Sentence
    {
        GeneratorBase _owner;
        object[] _tokens;
        
        /// <summary>
        /// Returns the generator that generated the sentence.
        /// </summary>
        public GeneratorBase Owner { get { return _owner; } }
        
        /// <summary>
        /// トークン。
        /// </summary>
        public object[] Tokens { get { return _tokens; } }
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="owner">Generator that generated the sentence.</param>
        /// <param name="tokens">Tokens.</param>
        public Sentence(GeneratorBase owner, params object[] tokens)
        {
            _owner = owner;
            _tokens = tokens;
            if (_tokens == null)
            {
                _tokens = new object[0];
            }
        }
        
        /// <summary>
        /// Tests equality.
        /// </summary>
        /// <param name="obj">Object to compare against.</param>
        /// <returns>Comparison result.</returns>
        public override bool Equals(object obj)
        {
            Sentence target = obj as Sentence;
            if (target == null)
            {
                return false;
            }
            if (!ReferenceEquals(_owner, target._owner))
            {
                return false;
            }
            if (_tokens == null && target._tokens == null)
            {
                return true;
            }
            if (_tokens == null || target._tokens == null)
            {
                return false;
            }
            if (_tokens.Length != target._tokens.Length)
            {
                return false;
            }
            for (int i = 0; i < _tokens.Length; i++)
            {
                if (_tokens[i] == null && target._tokens[i] == null)
                {
                    continue;
                }
                if (_tokens[i] == null || target._tokens[i] == null)
                {
                    return false;
                }
                if (!_tokens[i].Equals(target._tokens[i]))
                {
                    return false;
                }
            }
            return true;
        }
        
        /// <summary>
        /// Returns this object's hash code.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            int hash = (_owner == null) ? 0 : _owner.GetHashCode();
            foreach (object element in _tokens)
            {
                if (element == null)
                {
                    continue;
                }
                hash += element.GetHashCode();
            }
            return hash;
        }
    }
}
