using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Code added at capture.
    /// </summary>
    public static class CaptureAdaptor
    {
        static List<string> _code = new List<string>();

        /// <summary>
        /// Add code.
        /// </summary>
        /// <param name="code">code.</param>
        public static void AddCode(string code)
        {
            lock (_code)
            {
                _code.Add(code);
            }
        }

        /// <summary>
        /// Get code.
        /// </summary>
        /// <returns>code.</returns>
        internal static string[] PopCode()
        {
            lock (_code)
            {
                var ret = _code.ToArray();
                _code.Clear();
                return ret;
            }
        }
    }
}
