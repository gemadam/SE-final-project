using QuickFlattener.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Logging
{
    public class CustomLogger : ILogger
    {
        private readonly Func<string, bool> _logFunc;


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
