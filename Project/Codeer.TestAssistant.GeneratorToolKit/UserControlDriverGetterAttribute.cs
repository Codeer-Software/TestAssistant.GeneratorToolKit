using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attribute indicating that it is a property for obtaining UserControlDriver.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class UserControlDriverGetterAttribute : Attribute { }
}
