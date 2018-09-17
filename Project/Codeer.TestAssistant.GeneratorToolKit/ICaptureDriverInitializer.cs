namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Initialize the driver at the time of capture.
    /// </summary>
    public interface ICaptureDriverInitializer
    {
        /// <summary>
        /// Set editing class information.
        /// </summary>
        /// <param name="app">AppFriend.</param>
        /// <param name="editingTypeFullName">Type full name of the editing class.</param>
        /// <param name="edittingMethodName">Name of the editing method.</param>
        void SetEditingClassInfo(object app, string editingTypeFullName, string edittingMethodName);

        /// <summary>
        /// Initialize driver.
        /// </summary>
        /// <param name="driver">Driver.</param>
        void Initialize(object driver);
    }
}
