using System.Collections.Generic;
using System;

namespace Codeer.TestAssistant.GeneratorToolKit
{
    /// <summary>
    /// Capture code generator base class. 
    /// All generators must inherit this class. If you define a child class and create a mapping to the target controls using the plugin XML format, the class will be instantiated in the target application and have Attach() called during the "generate code from interactions" operation.
    /// </summary>
    public abstract class CaptureCodeGeneratorBase : IDisposable
    {
        string _name;
        List<Sentence> _currentCode;
        bool _disposed;
        IntPtr _windowHandle;
        object _controlObject;
        
        /// <summary>
        /// Target window handle of the code generation. 
        /// Returns IntPtr.Zero for WPF controls.
        /// </summary>
        public IntPtr WindowHandle { get { return _windowHandle; } }
        
        /// <summary>
        /// Target control object of the code generation operation.
        /// Returns null for native windows.
        /// </summary>
        public object ControlObject { get { return _controlObject; } }
        
        /// <summary>
        /// Variable name that is assigned to the control by TestAssistant.
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }
        
        /// <summary>
        /// The current code.
        /// </summary>
        protected List<Sentence> CurrentCode { get { return _currentCode; } }
                
        /// <summary>
        /// Finalizer
        /// </summary>
        ~CaptureCodeGeneratorBase()
        {
            Dispose(false);
        }
        
        /// <summary>
        /// Dispose.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose.
        /// </summary>
        /// <param name="disposing">flag.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                Detach();
                _disposed = true;
            }
        }

        /// <summary>
        /// Initialization.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="windowHandle">Window handle.</param>
        /// <param name="controlObject">Control object.</param>
        /// <param name="currentCode">Code buffer.</param>
        public void Initialize(string name, IntPtr windowHandle, object controlObject, List<Sentence> currentCode)
        {
            _name = name;
            _windowHandle = windowHandle;
            _controlObject = controlObject;
            _currentCode = currentCode;
            Attach();
        }

        /// <summary>
        /// Adds a sentence.
        /// </summary>
        /// <param name="tokens">Tokens to be included in the sentence.</param>
        protected void AddSentence(params object[] tokens)
        {
            if (tokens == null)
            {
                tokens = new object[0];
            }
            _currentCode.Add(new Sentence(this, tokens));
        }
        
        /// <summary>
        /// Adds a sentence.
        /// </summary>
        /// <param name="sentence">The sentence.</param>
        protected void AddSentence(Sentence sentence)
        {
            _currentCode.Add(sentence);
        }

        /// <summary>
        /// Optimization.
        /// </summary>
        /// <param name="code">Code.</param>
        public virtual void Optimize(List<Sentence> code) { }
        
        /// <summary>
        /// Attach operation. 
        /// Causes the test object to attach to the target window.
        /// Also attaches events in the case of .NET windows.
        /// </summary>
        protected abstract void Attach();
        
        /// <summary>
        /// Detach operation. 
        /// Detaches the test object from the window.
        /// Also disconnects events in the case of .NET windows.
        /// </summary>
        protected abstract void Detach();
    }
}
