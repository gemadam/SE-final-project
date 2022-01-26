using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using QuickFlattener.Flattening;
using QuickFlattener.Logging;
using QuickFlattener.Flattening.Algorithms;

namespace QuickFlattener
{
    /// <summary>
    /// GUI controller.
    /// </summary>
    public class UIController
    {
        private readonly ILogger _uiLogger;

        /// <summary>
        /// Flattening algorithms supported by the program
        /// </summary>
        public IDictionary<string, IFlatteningAlgorithm> AvailableAlgorithms { get; private set; }

        private FlatteningAlgorithmContext _algorithmContext;
        private FileMapper _fileMapper;

        public UIController(ILogger uiLogger)
        {
            _uiLogger = uiLogger;

            AvailableAlgorithms = new Dictionary<string, IFlatteningAlgorithm>();
            AvailableAlgorithms.Add("QuickFlattenerUltra v1.0", new QuickFlattenerUltra());
            AvailableAlgorithms.Add("JustLogFile v1.0", new JustLogFile());

            _algorithmContext = new FlatteningAlgorithmContext(new QuickFlattenerUltra());

            _fileMapper = new FileMapper();
        }

        public void ChangeAlgorithm(string sAlgorithmName)
        {
            if (!AvailableAlgorithms.ContainsKey(sAlgorithmName))
                return;

            _algorithmContext.SetAlgorithm(AvailableAlgorithms[sAlgorithmName]);
        }

        public ICollection<FileInfo> Scan(string inputPath)
        {
            var scanner = new FileScanner(_uiLogger);

            return scanner.GetFiles(inputPath);
        }

        public IDictionary<string, List<FileInfo>> MapFiles(ICollection<FileInfo> files, string outputPattern)
        {
            return _fileMapper.MapFiles(files, outputPattern);
        }

        public void ExecuteFlattening(IDictionary<string, FileInfo> files, string outputPath)
        {
            _algorithmContext.Algorithm.Loggers = new List<ILogger>()
            {
                _uiLogger,
                new LogFileLogger(Path.Combine(outputPath, "OUTPUT.LOG")),
                new CustomLogger((string msg) => {
                    Console.WriteLine(msg);
                    return true;
                })
            };

            try
            {
                 _algorithmContext.Algorithm.Execute(files, outputPath);

                _uiLogger.Log($"Diretory was successfully flattend.");
            }
            catch (DirectoryNotFoundException ex)
            {
                _uiLogger.Log(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                _uiLogger.Log(ex.Message);
            }
            catch (Exception ex)
            {
                _uiLogger.Log(ex.Message);
            }
        }
    }
}
