using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Advanced capture customization function.
    /// </summary>
    public abstract class AdvancedCaptureCustomizer
    {
        internal delegate VisualItemState GetVisualItemStateDelegate(object driver);
        internal delegate AttachMethodInvokeInfo[] GetTopLevelWindowAttacDriverInfoDelegate(IntPtr handle);
        internal delegate AttachMethodInvokeInfo[] GetAttacDriverInfoDelegate(object parentDriver);

        internal GetVisualItemStateDelegate GetVisualItemStateCore { get; set; }
        internal GetTopLevelWindowAttacDriverInfoDelegate GetTopLevelWindowAttacDriverInfoCore { get; set; }
        internal GetAttacDriverInfoDelegate GetAttacDriverInfoCore { get; set; }

        /// <summary>
        /// Get the status of VisualItem.
        /// </summary>
        /// <param name="driver">Driver.</param>
        /// <returns>VisualItemState.</returns>
        protected VisualItemState GetVisualItemState(object driver) => GetVisualItemStateCore(driver);

        /// <summary>
        /// Get driver attachment information for top level window.
        /// </summary>
        /// <param name="handle">Window handle.</param>
        /// <returns>Attachment information.</returns>
        protected AttachMethodInvokeInfo[] GetTopLevelWindowAttacDriverInfo(IntPtr handle) => GetTopLevelWindowAttacDriverInfoCore(handle);

        /// <summary>
        /// Get driver attachment information.
        /// </summary>
        /// <param name="parentDriver">Parent driver.</param>
        /// <returns>Attachment information.</returns>
        protected AttachMethodInvokeInfo[] GetAttacDriverInfo(object parentDriver) => GetAttacDriverInfoCore(parentDriver);

        /// <summary>
        /// Initialize.
        /// </summary>
        /// <param name="app">AppFriend.</param>
        public abstract void Initialize(object app);

        /// <summary>
        /// It is called at the timing of updating the driver.
        /// </summary>
        public abstract void RefleshDrivers();
    }
}