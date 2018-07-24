using System.Windows;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Interface of generating name for WPF.
    /// </summary>
    public interface IWPFNameGenerator
    {
        /// <summary>
        /// Generate name.
        /// </summary>
        /// <param name="target">Target.</param>
        /// <returns>Name.</returns>
        string GenerateName(DependencyObject target);
    }
}
