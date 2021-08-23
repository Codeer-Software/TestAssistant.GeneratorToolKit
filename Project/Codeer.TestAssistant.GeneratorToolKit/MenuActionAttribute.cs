using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Attributes for expanding the menu
    /// </summary>
    public class MenuActionAttribute : Attribute
    {
        /// <summary>
        /// Item name to be displayed in the menu
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// AccessPath of the Item
        /// </summary>
        public string AccessPath { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="accessPath">AccessPath of the Item</param>
        public MenuActionAttribute(string accessPath)
        {
            AccessPath = accessPath;
        }
    }
}
