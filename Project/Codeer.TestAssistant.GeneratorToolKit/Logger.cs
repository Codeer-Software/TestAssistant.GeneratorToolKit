using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Logger.
    /// </summary>
    public static class Logger
    {
        static List<string> _buffer;

        internal static void SetLogBuffer(List<string> buffer)
        {
            _buffer = buffer;
        }

        /// <summary>
        /// Write line to log.
        /// </summary>
        /// <param name="line">line.</param>
        public static void WriteLine(string line)
        {
            if (_buffer == null) return;

            lock (_buffer)
            {
                _buffer.Add(line);
            }
        }
    }
}
