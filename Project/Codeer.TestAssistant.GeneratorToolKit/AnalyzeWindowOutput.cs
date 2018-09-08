using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Analyze Window Output.
    /// </summary>
    public class AnalyzeWindowOutput
    {
        List<string> _lines = new List<string>();
        internal bool ToldToShow { get; set; }
        internal bool ToldToClear { get; set; }

        internal string[] PopLines()
        {
            var lines = _lines.ToArray();
            _lines.Clear();
            return lines;
        }

        /// <summary>
        /// Show Output.
        /// </summary>
        public void Show() => ToldToShow = true;

        /// <summary>
        /// Write line to Output.
        /// </summary>
        /// <param name="line"></param>
        public void WriteLine(string line) => _lines.Add(line);

        /// <summary>
        /// Clear Output.
        /// </summary>
        public void Clear()
        {
            ToldToClear = true;
            _lines.Clear();
        }
    }
}
