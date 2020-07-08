namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Driver Designer.
    /// </summary>
    public interface IDriverDesigner
    {
        /// <summary>
        /// priority.
        /// </summary>
        int Priority { get; }

        /// <summary>
        /// candidates of attach extension class.
        /// </summary>
        /// <param name="obj">obj.</param>
        /// <returns>candidates of attach extension class.</returns>
        string[] GetAttachExtensionClassCandidates(object obj);

        /// <summary>
        /// candidates of attach method.
        /// </summary>
        /// <param name="obj">obj.</param>
        /// <returns>candidates of attach method.</returns>
        string[] GetAttachMethodCandidates(object obj);

        /// <summary>
        /// can you design a driver for a given object?
        /// </summary>
        /// <param name="obj">obj.</param>
        /// <returns>Can you design a driver for a given object?</returns>
        bool CanDesign(object obj);

        /// <summary>
        /// candidate code to identify element.
        /// </summary>
        /// <param name="root">root.</param>
        /// <param name="element">elemnet.</param>
        /// <returns>candidate code to identify element.</returns>
        DriverIdentifyInfo[] GetIdentifyingCandidates(object root, object element);

        /// <summary>
        /// generate code.
        /// </summary>
        /// <param name="root">root.</param>
        /// <param name="info">information.</param>
        void GenerateCode(object root, DriverDesignInfo info);

        /// <summary>
        /// create driver class name.
        /// </summary>
        /// <param name="root">root.</param>
        /// <returns>driver class name.</returns>
        string CreateDriverClassName(object root);
    }
}
