namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Tree mode in Window analysis.
    /// </summary>
    public enum WindowAnalysisTreeMode
    {
        /// <summary>
        /// Win32 Window Tree.
        /// </summary>
        Window,

        /// <summary>
        /// WinForms Controls.
        /// </summary>
        Controls,

        /// <summary>
        /// WPF Logical Tree.
        /// </summary>
        LogicalTree,

        /// <summary>
        /// WPF Visual Tree.
        /// </summary>
        VisualTree,

        /// <summary>
        /// .Net Field.
        /// </summary>
        Field,

        /// <summary>
        /// .Net Property.
        /// </summary>
        Property
    }
}
