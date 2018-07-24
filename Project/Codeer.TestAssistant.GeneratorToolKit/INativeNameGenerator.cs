using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Interface of generating name for native.
    /// </summary>
    public interface INativeNameGenerator
    {
        /// <summary>
        /// Generate name.
        /// </summary>
        /// <param name="target">Target.</param>
        /// <returns>Name.</returns>
        string GenerateName(IntPtr target);
    }
}