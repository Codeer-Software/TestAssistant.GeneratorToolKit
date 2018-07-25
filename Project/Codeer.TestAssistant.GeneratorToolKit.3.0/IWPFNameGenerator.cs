using System.Windows;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Interface of generating name for WPF.
    /// </summary>
    public interface IWPFNameGenerator
    {
        /// <summary>
        /// Priority. The higher the value, the higher the priority.
        /// </summary>
        int Priority { get; }

        /// <summary>
        /// Generate name.
        /// </summary>
        /// <param name="target">Target.</param>
        /// <returns>Name.</returns>
        string GenerateName(DependencyObject target);
    }
}
