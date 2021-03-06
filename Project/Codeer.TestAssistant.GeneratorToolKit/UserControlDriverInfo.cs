﻿using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// UserControl driver info.
    /// </summary>
    [Serializable]
    public class UserControlDriverInfo
    {
        /// <summary>
        /// Driver type full name.
        /// </summary>
        public string DriverTypeFullName { get; set; }

        /// <summary>
        /// Constructor Arguments.
        /// </summary>
        public string[][] ConstructorArguments { get; set; } = new string[0][];
    }
}
