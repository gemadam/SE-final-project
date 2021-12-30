using QuickFlattener.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Flattening
{
    public interface IFlatteningAlgorithm
    {
        ICollection<ILogger> Loggers { get; set; }

        ICollection<string> Execute(ICollection<FileInfo> files, string outputPattern);

        void Reverse(FileInfo logFile);
    }
}
