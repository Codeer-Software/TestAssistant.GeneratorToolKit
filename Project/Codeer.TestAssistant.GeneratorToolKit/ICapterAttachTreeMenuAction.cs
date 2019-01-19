using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Menu processing at Capture Attach Tree.
    /// </summary>
    public interface ICapterAttachTreeMenuAction
    {
        /// <summary>
        /// Get Menu processing at Capture Attach Tree.
        /// </summary>
        /// <param name="driver">Window driver or UserControl driver or Control driver.</param>
        /// <returns>Menu processing at Capture Attach Tree.</returns>
        Dictionary<string, MenuAction> GetAction(object driver);
    }
}
