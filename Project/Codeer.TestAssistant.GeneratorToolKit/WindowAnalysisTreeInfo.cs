using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Tree info in Window analysis.
    /// </summary>
    public class WindowAnalysisTreeInfo
    {
        /// <summary>
        /// Tree mode in Window analysis.
        /// </summary>
        public WindowAnalysisTreeMode WindowAnalysisTreeMode { get; set; }

        /// <summary>
        /// Name. It is used at Propety or Field.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Parent object. It is used at Propety or Field.
        /// </summary>
        public object ParentObject { get; set; }

        internal static WindowAnalysisTreeInfo Create(string windowAnalysisTreeMode, string name, object parentObject)
        {
            return new WindowAnalysisTreeInfo
            {
                WindowAnalysisTreeMode = (WindowAnalysisTreeMode)Enum.Parse(typeof(WindowAnalysisTreeMode), windowAnalysisTreeMode),
                Name = name,
                ParentObject = parentObject
            };
        }
    }
}
