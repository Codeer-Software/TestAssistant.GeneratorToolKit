using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Data with this attribute will be transferred to the capture code generator upon capture. 
    /// The data must be Serializable.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class CaptureSettingAttribute : Attribute { }
}
