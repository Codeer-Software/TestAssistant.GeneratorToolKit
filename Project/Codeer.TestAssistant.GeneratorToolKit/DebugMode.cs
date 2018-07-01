namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// When used in a generator during tests, allows running in debug mode.
    /// Can also be used to force running in async mode.
    /// </summary>
    public static class DebugMode
    {
        static bool _isAllAsync;

        /// <summary>
        /// Flag to indicate generating all tests in asynchronous mode.
        /// </summary>
        public static bool IsAllAsync { get { return _isAllAsync; } set { _isAllAsync = value; } }
    }
}
