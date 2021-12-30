using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Logging
{
    public class LogFileLogger : ILogger
    {
        private readonly string _fileURL;


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
