using System;
using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Driver tree attached at capture time
    /// </summary>
    [Serializable]
    public class CaptureDriverTree
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Children.
        /// </summary>
        public List<CaptureDriverTree> Children { get; } = new List<CaptureDriverTree>();
    }
}
