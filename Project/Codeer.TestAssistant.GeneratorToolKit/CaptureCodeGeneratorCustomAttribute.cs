using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Used to dynamically customize the capture from the driver during capture.
    /// Please attach it to the method.
    /// The method declaration looks like this:
    /// 
    /// void CustomMethod(AppVar captureCodeGenerator)
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class CaptureCodeGeneratorCustomAttribute : Attribute { }
}
