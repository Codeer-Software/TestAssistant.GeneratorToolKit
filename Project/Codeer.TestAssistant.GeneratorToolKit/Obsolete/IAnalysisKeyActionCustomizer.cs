﻿namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Customize key action at analyze window.
    /// </summary>
    public interface IAnalysisKeyActionCustomizer
    {
        /// <summary>
        /// Preview key.
        /// </summary>
        /// <param name="key">System.Windows.Forms.Keys</param>
        /// <param name="modifyKeys">System.Windows.Forms.Keys</param>
        /// <returns>Is target key ?</returns>
        bool PreviewKey(int key, int modifyKeys);

        /// <summary>
        /// Customize key action.
        /// </summary>
        /// <param name="controlObject">selected control object.</param>
        /// <param name="key">System.Windows.Forms.Keys</param>
        /// <param name="modifyKeys">System.Windows.Forms.Keys</param>
        /// <returns>Is handled ?</returns>
        bool Invoke(object controlObject, int key, int modifyKeys);
    }
}
