using QuickFlattener.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener
{
    internal class FileScanner
    {
        private readonly ILogger _logger;


        public FileScanner(ILogger logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Method scans a directory recursively.
        /// </summary>
        /// <param name="path">Path to the directory</param>
        /// <returns>Collection of detected files.</returns>
        private ICollection<FileInfo> scanDir(string path)
        {
            var files = new List<FileInfo>();

            foreach (var dir in Directory.GetDirectories(path))
            {
                var ent = new DirectoryInfo(dir);

                try { 
                    files.AddRange(scanDir(ent.FullName));
                }
                catch (DirectoryNotFoundException ex)
                {
                    _logger.Log(ex.Message);
                }
                catch (UnauthorizedAccessException ex)
                {
                    _logger.Log(ex.Message);
                }
            }

            foreach (var f in Directory.GetFiles(path))
                files.Add(new FileInfo(f));

            return files;
        }

        /// <summary>
        /// Method scans a directory recursively.
        /// </summary>
        /// <param name="path">Path to the directory</param>
        /// <returns>Collection of detected files.</returns>
        public ICollection<FileInfo> GetFiles(string path)
        {
            return scanDir(path);
        }
    }
}
