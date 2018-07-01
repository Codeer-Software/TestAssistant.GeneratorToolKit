using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attributes for checking if the driver can be attached to the Window.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class WindowTryIdentifierAttribute : Attribute { }
}
