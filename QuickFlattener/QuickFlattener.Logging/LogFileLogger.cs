using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Logging
{
    /// <summary>
    /// Logger transfers messages to a file. If file exists, logger appends new lines to existing file.
    /// </summary>
    public class LogFileLogger : ILogger
    {
        /// <summary>
        /// URL of the file.
        /// </summary>
        private readonly string _fileURL;


        /// <summary>
        /// Constructor initializes the logger.
        /// </summary>
        /// <param name="fileURL">URL of the log file.</param>
        public LogFileLogger(string fileURL)
        {
            _fileURL = fileURL;
        }


        public void Log(string msg)
        {
            using (StreamWriter file = new StreamWriter(_fileURL, append: true))
            {
                file.WriteLine(msg);
            }
        }
    }
}
