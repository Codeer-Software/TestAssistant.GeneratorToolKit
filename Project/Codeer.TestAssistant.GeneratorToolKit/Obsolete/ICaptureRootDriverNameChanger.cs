namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Change the variable name of the root driver.
    /// </summary>
    public interface ICaptureRootDriverNameChanger
    {
        /// <summary>
        /// Set editing class information.
        /// </summary>
        /// <param name="app">AppFriend.</param>
        /// <param name="editingTypeFullName">Type full name of the editing class.</param>
        /// <param name="edittingMethodName">Name of the editing method.</param>
        void SetEditingClassInfo(object app, string editingTypeFullName, string edittingMethodName);

        /// <summary>
        /// Change name.
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="name">Name</param>
        /// <param name="declear">Declear?</param>
        void ChangeName(object driver, ref string name, ref bool declear);
    }
}
