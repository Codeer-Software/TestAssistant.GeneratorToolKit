namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Interface of generating driver element name.
    /// </summary>
    public interface IDriverElementNameGenerator
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
        string GenerateName(object target);
    }
}
