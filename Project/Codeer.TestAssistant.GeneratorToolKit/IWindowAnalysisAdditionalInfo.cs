namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Additional information on Window analysis.
    /// </summary>
    public interface IWindowAnalysisAdditionalInfo
    {
        /// <summary>
        /// Get additional information.
        /// </summary>
        /// <param name="target">Object to be processed.</param>
        /// <param name="info">Tree info in Window analysis.</param>
        /// <returns></returns>
	    string GetAdditionalInfo(object target, WindowAnalysisTreeInfo info);
    }
}
