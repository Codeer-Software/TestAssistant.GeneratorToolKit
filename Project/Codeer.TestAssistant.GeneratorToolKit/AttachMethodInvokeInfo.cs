using System.Reflection;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attach information to Driver.
    /// </summary>
    public class AttachMethodInvokeInfo
    {
        /// <summary>
        /// Method information.
        /// </summary>
        public MethodInfo MethodInfo { get; }

        /// <summary>
        /// Execution arguments.
        /// </summary>
        public object[] Args { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="methodInfo">Method information.</param>
        /// <param name="args">Execution arguments.</param>
        public AttachMethodInvokeInfo(MethodInfo methodInfo, object[] args)
        {
            MethodInfo = methodInfo;
            Args = args;
        }

        /// <summary>
        /// Attach execution.
        /// </summary>
        /// <returns>Driver.</returns>
        public object Invoke()
        {
            try
            {
                return MethodInfo.Invoke(null, Args);
            }
            catch { }
            return null;
        }
    }
}
