using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using QuickFlattener.Flattening;
using QuickFlattener.Logging;

namespace QuickFlattener
{
    public class UIController
    {
        public IDictionary<string, IFlatteningAlgorithm> AvailableAlgorithms { get; private set; }

        private FlatteningAlgorithmContext _algorithmContext;
        private FileMapper _fileMapper;

        public UIController()
        {
            AvailableAlgorithms = new Dictionary<string, IFlatteningAlgorithm>();
            AvailableAlgorithms.Add("QuickFlattenerUltra v1.0", new FlatteningAlgorithm());

            _algorithmContext = new FlatteningAlgorithmContext(new FlatteningAlgorithm());

            _fileMapper = new FileMapper();
        }

        public void ChangeAlgorithm(string sAlgorithmName)
        {
            _algorithmContext.SetAlgorithm(AvailableAlgorithms[sAlgorithmName]);
        }

        public ICollection<FileInfo> Scan(string inputPath)
        {
            var scanner = new FileScanner();

            return scanner.GetFiles(inputPath);
        }

        public IDictionary<string, List<FileInfo>> MapFiles(ICollection<FileInfo> files, string outputPattern)
        {
            return _fileMapper.MapFiles(files, outputPattern);
        }

        public ICollection<string> ExecuteFlattening(IDictionary<string, FileInfo> files, string outputPath)
        {
            _algorithmContext.Algorithm.Loggers = new List<ILogger>()
            {
                new LogFileLogger(Path.Combine(outputPath, "OUTPUT.LOG")),
                new CustomLogger((string msg) => {
                    Console.WriteLine(msg);
                    return true;
                })
            };

            return _algorithmContext.Algorithm.Execute(files, outputPath);
        }
    }
}
