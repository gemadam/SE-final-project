using QuickFlattener.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Logging
{
    /// <summary>
    /// Logger executes specified function for a message.
    /// Convinient to log message form various parts of the program on the UI.
    /// </summary>
    public class CustomLogger : ILogger
    {
        /// <summary>
        /// Function to be called for each message
        /// </summary>
        private readonly Func<string, bool> _logFunc;


        /// <summary>
        /// Constructor initializes the logger.
        /// </summary>
        /// <param name="fileURL">Function to be called for each message.</param>
        public CustomLogger(Func<string, bool> logFunc)
        {
            _logFunc = logFunc;
        }


        public void Log(string msg)
        {
            _logFunc.Invoke(msg);
        }
    }
}
