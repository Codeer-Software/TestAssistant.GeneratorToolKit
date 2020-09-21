namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Implementing this interface allows you to convert that object to an argument. Used in the property specified by ActiveItemKeyProperty of ItemDriverGetterAttribute.
    /// </summary>
    public interface IItemKey
    {
        /// <summary>
        /// Convert to arguments.
        /// </summary>
        /// <returns>Arguments</returns>
        object[] GetArguments();

        /// <summary>
        /// Convert to code of arguments.
        /// </summary>
        /// <returns>Code of arguments.</returns>
        string GetArgumentsCode();
    }
}
