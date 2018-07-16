using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attributes for specifying Driver's core.
    /// Core can specify WindowControl, IAppVarOwner, AppVar, DynamicAppVar.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DriverCoreIdentifyAttribute : Attribute { }
}
