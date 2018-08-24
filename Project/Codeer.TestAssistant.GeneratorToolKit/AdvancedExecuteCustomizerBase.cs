namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Advanced customization of process execution.
    /// </summary>
    public abstract class AdvancedExecuteCustomizerBase
    {
        /// <summary>
        /// Initialization of class to execute processing.
        /// </summary>
        /// <param name="target">Target.</param>
        /// <param name="methodName">Method name.</param>
        /// <param name="appFriend">AppFriend.</param>
        public abstract void Initialize(object target, string methodName, object appFriend);
    }
}
