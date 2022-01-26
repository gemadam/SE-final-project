using QuickFlattener.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Flattening.Algorithms
{
    public class JustLogFile : IFlatteningAlgorithm
    {

        public ICollection<ILogger> Loggers { get; set; }


        public JustLogFile()
        {
            Loggers = new List<ILogger>();
        }

        private void log(string msg)
        {
            foreach (var logger in Loggers)
                logger.Log(msg);
        }

        public void Execute(IDictionary<string, FileInfo> files, string outputPath)
        {
            // Ensure output directory exists
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
                this.log($"[!] Warning: Directory {Path.GetFullPath(outputPath)} does not exist. Directory created.");
            }
            else if (Directory.GetFiles(outputPath).Count() > 0)
                this.log($"[!] Warning: Directory {Path.GetFullPath(outputPath)} is not empty.");

            foreach (var file in files)
            {
                var p = Path.GetFullPath(Path.Combine(outputPath, file.Key));

                try
                {
                    if (File.Exists(p))
                        this.log($"[!] Error: File {p} already exists! Omitting this file...");
                    else
                        this.log($"[*] {file.Value.FullName} -> {p}");
                }
                catch (System.IO.FileNotFoundException ex)
                {
                    this.log($"[!] Error: Input file {file.Value.FullName} was not found!");
                }
            }
        }

        public void Reverse(FileInfo logFile)
        {

        }
    }
}
