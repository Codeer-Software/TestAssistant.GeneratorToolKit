using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attribute indicating that it is a property for obtaining UserControlDriver.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property| AttributeTargets.Method)]
    public class UserControlDriverGetterAttribute : Attribute 
    {
        /// <summary>
        /// A property that represents the active item. You should be able to get the active item when you pass it to the method. The type must match the method argument.
        /// </summary>
        public string ActiveProperty { get; set; }
    }
}
