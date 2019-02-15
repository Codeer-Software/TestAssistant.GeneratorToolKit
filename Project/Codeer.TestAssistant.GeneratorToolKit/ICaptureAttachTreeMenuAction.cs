using System;
using System.Collections.Generic;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Menu processing at Capture Attach Tree.
    /// </summary>
    public interface ICaptureAttachTreeMenuAction
    {
        /// <summary>
        /// Get Menu processing at Capture Attach Tree.
        /// </summary>
        /// <param name="accessPath">Access path to driver.</param>
        /// <param name="driver">Window driver or UserControl driver or Control driver.</param>
        /// <returns>Menu processing at Capture Attach Tree.</returns>
        Dictionary<string, MenuAction> GetAction(string accessPath, object driver);
    }

    /// <summary>
    /// Obsolete.
    /// </summary>
    [Obsolete("Sorry this class name is typo. ：_(  Please use ICaptureAttachTreeMenuAction.", false)]
    public interface ICapterAttachTreeMenuAction
    {
        /// <summary>
        /// Obsolete.
        /// </summary>
        /// <param name="accessPath">Obsolete.</param>
        /// <param name="driver">Obsolete.</param>
        /// <returns>Obsolete.</returns>
        Dictionary<string, MenuAction> GetAction(string accessPath, object driver);
    }
}
