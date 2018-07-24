using System.Windows.Forms;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Interface of generating name for WinForms.
    /// </summary>
    public interface IFormsNameGenerator
    {
        /// <summary>
        /// Generate name.
        /// </summary>
        /// <param name="target">Target.</param>
        /// <returns>Name.</returns>
        string GenerateName(Control target);
    }
}
