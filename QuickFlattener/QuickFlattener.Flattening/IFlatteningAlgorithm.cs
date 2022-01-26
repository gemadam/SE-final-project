using QuickFlattener.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Flattening
{
    /// <summary>
    /// General interface of flattening algorithm
    /// </summary>
    public interface IFlatteningAlgorithm
    {
        /// <summary>
        /// Collection of loggers
        /// </summary>
        ICollection<ILogger> Loggers { get; set; }


        /// <summary>
        /// Method executes algorithm.
        /// </summary>
        /// <param name="files">Files mapping.</param>
        /// <param name="outputPath">Output diretory.</param>
        void Execute(IDictionary<string, FileInfo> files, string outputPath);


        /// <summary>
        /// Method executes reverse algorithm.
        /// </summary>
        /// <param name="logFile">Log file generated during flattening.</param>
        void Reverse(FileInfo logFile);
    }
}
