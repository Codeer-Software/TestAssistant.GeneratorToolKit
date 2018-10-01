namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Send info to target.
    /// </summary>
    public interface ISenderToTarget
    {
        /// <summary>
        /// This method is called in the host process when Analyze and CreateDrvier are initialized. 
        /// Since the host process loads the dll that started Analyze or CreateDriver, 
        /// internally it can acquire the information using reflection etc. Information can be written to 
        /// arbitrary memory of target process by app.
        /// </summary>
        /// <param name="app">WindowsAppFriend.</param>
        void Send(object app);
    }
}
