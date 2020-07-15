using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Adapter with driver creator.
    /// </summary>
    public static class DriverCreatorAdapter
    {
        static Dictionary<string, CreatedDriverInfo> _files = new Dictionary<string, CreatedDriverInfo>();
        static List<object> _driverElements = new List<object>();

        internal class CreatedDriverInfo
        {
            internal string Code { get; set; }
            internal object Target { get; set; }
            internal Dictionary<string, object> KeyAndTarget { get; } = new Dictionary<string, object>();
        }

        /// <summary>
        /// Client project extension.
        /// </summary>
        public static string ClientProjectExtension { get; private set; }

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
        public static Dictionary<string, ControlDriverInfo> TypeFullNameAndControlDriver { get; set; } = new Dictionary<string, ControlDriverInfo>();

        /// <summary>
        /// .Net type full name and window driver info dictionary.
        /// </summary>
        public static Dictionary<string, WindowDriverInfo> TypeFullNameAndWindowDriver { get; set; } = new Dictionary<string, WindowDriverInfo>();

        /// <summary>
        /// Window class name and window driver info dictionary.
        /// </summary>
        public static Dictionary<string, WindowDriverInfo> WindowClassNameAndWindowDriver { get; set; } = new Dictionary<string, WindowDriverInfo>();

        /// <summary>
        /// Window text and window driver info dictionary.
        /// </summary>
        public static Dictionary<string, WindowDriverInfo> WindowTextAndWindowDriver { get; set; } = new Dictionary<string, WindowDriverInfo>();

        /// <summary>
        /// .Net type full name and user control driver info dictionary.
        /// </summary>
        public static Dictionary<string, UserControlDriverInfo> TypeFullNameAndUserControlDriver { get; set; } = new Dictionary<string, UserControlDriverInfo>();

        /// <summary>
        /// Window class name and control driver info multi dictionary.
        /// </summary>
        public static Dictionary<string, List<ControlDriverInfo>> MultiWindowClassNameAndControlDriver { get; set; } = new Dictionary<string, List<ControlDriverInfo>>();

        /// <summary>
        /// .Net type full name and control driver info multi dictionary.
        /// </summary>
        public static Dictionary<string, List<ControlDriverInfo>> MultiTypeFullNameAndControlDriver { get; set; } = new Dictionary<string, List<ControlDriverInfo>>();

        /// <summary>
        /// .Net type full name and window driver info multi dictionary.
        /// </summary>
        public static Dictionary<string, List<WindowDriverInfo>> MultiTypeFullNameAndWindowDriver { get; set; } = new Dictionary<string, List<WindowDriverInfo>>();

        /// <summary>
        /// Window class name and window driver info multi dictionary.
        /// </summary>
        public static Dictionary<string, List<WindowDriverInfo>> MultiWindowClassNameAndWindowDriver { get; set; } = new Dictionary<string, List<WindowDriverInfo>>();

        /// <summary>
        /// Window text and window driver info multi dictionary.
        /// </summary>
        public static Dictionary<string, List<WindowDriverInfo>> MultiWindowTextAndWindowDriver { get; set; } = new Dictionary<string, List<WindowDriverInfo>>();

        /// <summary>
        /// .Net type full name and user control driver info multi dictionary.
        /// </summary>
        public static Dictionary<string, List<UserControlDriverInfo>> MultiTypeFullNameAndUserControlDriver { get; set; } = new Dictionary<string, List<UserControlDriverInfo>>();

        /// <summary>
        /// Add driver elements.
        /// </summary>
        /// <param name="driverElement">Driver element.</param>
        public static void AddDriverElements(object driverElement)
        {
            lock (_driverElements)
            {
                _driverElements.Add(driverElement);
            }
        }

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

        internal static void SetClientProjectExtension(string clientProjectExtension) => ClientProjectExtension = clientProjectExtension;
        
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

        internal static List<object> PopDriverElements()
        {
            lock (_driverElements)
            {
                var ret = new List<object>(_driverElements);
                _driverElements.Clear();
                return ret;
            }
        }
    }
}
