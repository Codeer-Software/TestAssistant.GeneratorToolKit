using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Execute target initializer.
    /// </summary>
    public interface IExecuteTargetInitializer
    {
        /// <summary>
        /// Initialization of class to execute target.
        /// </summary>
        /// <param name="targetType">Target type.</param>
        /// <param name="target">Target.</param>
        /// <param name="methodName">Method name.</param>
        /// <param name="appFriend">AppFriend.</param>
        void Initialize(Type targetType, object target, string methodName, object appFriend);
    }
}
