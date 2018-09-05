namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Visual item state.
    /// </summary>
    public class VisualItemState
    {
        internal delegate bool EqualsDelegate(object lhs, object rhs);
        internal EqualsDelegate EqualsCore { get; set; }
        internal object Core { get; set; }

        /// <summary>
        /// Equivalent comparison.
        /// </summary>
        /// <param name="obj">Comparison.</param>
        /// <returns>Is it the same object?</returns>
        public override bool Equals(object obj)
        {
            var state = obj as VisualItemState;
            if (ReferenceEquals(state, null)) return false;
            return EqualsCore(Core, state.Core);
        }

        /// <summary>
        /// Get hash code.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode() => 0;

        /// <summary>
        /// Is it the same object?
        /// </summary>
        /// <param name="lhs">lhs</param>
        /// <param name="rhs">rhs</param>
        /// <returns>Is it the same object?</returns>
        public static bool operator ==(VisualItemState lhs, VisualItemState rhs)
        {
            if (ReferenceEquals(lhs, null) && ReferenceEquals(rhs, null)) return true;
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null)) return false;
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Is it a different object?
        /// </summary>
        /// <param name="lhs">lhs</param>
        /// <param name="rhs">rhs</param>
        /// <returns>Is it a different object?</returns>
        public static bool operator !=(VisualItemState lhs, VisualItemState rhs) => !(lhs == rhs);
    }
}
