using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Adapter with driver creator.
    /// </summary>
    public static class DriverCreatorAdapter
    {
        static Dictionary<string, string> _files = new Dictionary<string, string>();

        /// <summary>
        /// Selected namespace.
        /// </summary>
        public static string SelectedNamespace { get; private set; }

        /// <summary>
        /// Add code.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <param name="code">Code.</param>
        public static void AddCode(string fileName, string code)
        {
            lock (_files)
            {
                _files[fileName] = code;
            }
        }

        internal static void SetSelectedNamespace(string @namespace) => SelectedNamespace = @namespace;

        internal static Dictionary<string, string> PopFiles()
        {
            var cpy = new Dictionary<string, string>();
            lock (_files)
            {
                foreach (var e in _files)
                {
                    cpy[e.Key] = e.Value;
                }
            }
            return cpy;
        }
    }
}
