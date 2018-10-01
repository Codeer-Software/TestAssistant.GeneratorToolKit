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
        /// Window class name and control driver info dictionary.
        /// </summary>
        public static Dictionary<string, ControlDriverInfo> WindowClassNameAndControlDriver { get; set; } = new Dictionary<string, ControlDriverInfo>();

        /// <summary>
        /// .Net type full name and control driver info dictionary.
        /// </summary>
        public static Dictionary<string, ControlDriverInfo> NetTypeAndControlDriver { get; set; } = new Dictionary<string, ControlDriverInfo>();

        /// <summary>
        /// .Net type full name and window driver info dictionary.
        /// </summary>
        public static Dictionary<string, WindowDriverInfo> NetTypeAndWindowDriverTypeFullName { get; set; } = new Dictionary<string, WindowDriverInfo>();

        /// <summary>
        /// Window class name and window driver info dictionary.
        /// </summary>
        public static Dictionary<string, WindowDriverInfo> WindowClassNameAndWindowDriverTypeFullName { get; set; } = new Dictionary<string, WindowDriverInfo>();

        /// <summary>
        /// Window text and window driver info dictionary.
        /// </summary>
        public static Dictionary<string, WindowDriverInfo> WindowTextAndWindowDriverTypeFullName { get; set; } = new Dictionary<string, WindowDriverInfo>();

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
                _files.Clear();
            }
            return cpy;
        }
    }
}
