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

        public UIController()
        {
            AvailableAlgorithms = new Dictionary<string, IFlatteningAlgorithm>();
            AvailableAlgorithms.Add("QuickFlattenerUltra v1.0", new FlatteningAlgorithm());

            _algorithmContext = new FlatteningAlgorithmContext(new FlatteningAlgorithm());
        }

        public void ChangeAlgorithm(string sAlgorithmName)
        {
            _algorithmContext.SetAlgorithm(AvailableAlgorithms[sAlgorithmName]);
        }

        public ICollection<string> ExecuteFlattening(string inputPath, string outputPath, string outputPattern, out int filesCount)
        {
            _algorithmContext.Algorithm.Loggers = new List<ILogger>()
            {
                new LogFileLogger(Path.Combine(outputPath, "OUTPUT.LOG")),
                new CustomLogger((string msg) => {
                    Console.WriteLine(msg);
                    return true;
                })
            };

            var scanner = new FileScanner();

            var files = scanner.GetFiles(inputPath);

            filesCount = files.Count;

            return _algorithmContext.Algorithm.Execute(files, outputPattern);
        }
    }
}
