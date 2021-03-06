﻿using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Menu processing at Window analysis.
    /// </summary>
    public interface IWindowAnalysisMenuAction
    {
        /// <summary>
        /// Get Menu processing at Window analysis.
        /// </summary>
        /// <param name="target">Object to be processed.</param>
        /// <param name="info">Tree info in Window analysis.</param>
        /// <returns>Menu processing at Window analysis.</returns>
        Dictionary<string, MenuAction> GetAction(object target, WindowAnalysisTreeInfo info);
    }
}
