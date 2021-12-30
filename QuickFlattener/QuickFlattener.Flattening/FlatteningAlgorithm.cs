using QuickFlattener.Logging;
using QuickFlattener.Tokenization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Flattening
{
    public class FlatteningAlgorithm : IFlatteningAlgorithm
    {
        private readonly Tokenizer _tokenizer;

        public ICollection<ILogger> Loggers { get; set; }


        public FlatteningAlgorithm()
        {
            Loggers = new List<ILogger>();
            _tokenizer = new Tokenizer();
        }

        private void log(string msg)
        {
            foreach (var logger in Loggers)
                logger.Log(msg);
        }

        public ICollection<string> Execute(ICollection<FileInfo> files, string outputPattern)
        {
            var lstFiles = new List<string>();

            foreach (var file in files)
            {
                lstFiles.Add(file.FullName + " -> " + _tokenizer.Tokenize(outputPattern, file));
                log(file.FullName + " -> " + _tokenizer.Tokenize(outputPattern, file));
            }

            return lstFiles;
        }

        public void Reverse(FileInfo logFile)
        {

        }
    }
}
