using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attribute indicating that it is a property for obtaining ItemDriver.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class ItemDriverGetterAttribute : Attribute 
    {
        /// <summary>
        /// A property that represents the active item. 
        /// You should be able to get the active item when you pass it to the method.
        /// The type must match the method argument or to implement the IItemKey interface.
        /// </summary>
        public string ActiveItemKeyProperty { get; set; }
    }
}
