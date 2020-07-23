using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Used to customize AppFriend. The main use is to support multi-domain applications.
    /// </summary>
    public class AppFriendCustomizerBase
    {
        /// <summary>
        /// Customize at Capture.
        /// </summary>
        /// <param name="targetTypeFullName">Target type fullName.</param>
        /// <param name="methodName">Method name.</param>
        /// <param name="appFriend">AppFriend.</param>
        /// <returns>AppFriend.</returns>
        public virtual object CustomCapture(string targetTypeFullName, string methodName, object appFriend) => appFriend;

        /// <summary>
        /// Customize at Execute.
        /// </summary>
        /// <param name="targetTypeFullName">Target type fullName.</param>
        /// <param name="methodName">Method name.</param>
        /// <param name="appFriend">AppFriend.</param>
        /// <returns>AppFriend.</returns>
        public virtual object CustomExecute(string targetTypeFullName, string methodName, object appFriend) => appFriend;

        /// <summary>
        /// Customize at Analyze.
        /// </summary>
        /// <param name="selecteedNameSpace">Selected Namespace</param>
        /// <param name="appFriend">AppFriend.</param>
        /// <returns>AppFriend.</returns>
        public virtual object CustomAnalyze(string selecteedNameSpace, object appFriend) => appFriend;
    }
}
