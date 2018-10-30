using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Adapter with driver creator.
    /// </summary>
    public static class DriverCreatorAdapter
    {
        static Dictionary<string, CreatedDriverInfo> _files = new Dictionary<string, CreatedDriverInfo>();

        internal class CreatedDriverInfo
        {
            internal string Code { get; set; }
            internal object Target { get; set; }
            internal Dictionary<string, object> KeyAndTarget { get; } = new Dictionary<string, object>();
        }

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
        /// <param name="target">An object of type corresponding to the driver code (or Window handle).</param>
        public static void AddCode(string fileName, string code, object target)
        {
            lock (_files)
            {
                if (!_files.TryGetValue(fileName, out var info))
                {
                    info = new CreatedDriverInfo();
                    _files.Add(fileName, info);
                }
                info.Code = code;
                info.Target = target;
            }
        }

        /// <summary>
        /// When the generated code is displayed in the preview, add information on the object to be highlighted when selecting the line of code.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <param name="key">What can be uniquely identified in the file with keywords contained in the line.</param>
        /// <param name="target">Object to highlight (or Window handle).</param>
        public static void AddCodeLineSelectInfo(string fileName, string key, object target)
        {
            if (!_files.TryGetValue(fileName, out var info))
            {
                info = new CreatedDriverInfo();
                _files.Add(fileName, info);
            }
            info.KeyAndTarget[key] = target;
        }

        internal static void SetSelectedNamespace(string @namespace) => SelectedNamespace = @namespace;

        internal static Dictionary<string, CreatedDriverInfo> PopFiles()
        {
            var cpy = new Dictionary<string, CreatedDriverInfo>();
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
