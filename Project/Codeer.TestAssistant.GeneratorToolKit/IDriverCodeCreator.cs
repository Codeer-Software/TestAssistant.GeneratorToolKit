namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Advanced customization of driver creation.
    /// </summary>
    public interface IDriverCodeCreator
    {
        /// <summary>
        /// Create code.
        /// </summary>
        /// <param name="targetObj">Target object.</param>
        /// <returns>true -> Executed.</returns>
        bool Create(object targetObj);
    }
}
