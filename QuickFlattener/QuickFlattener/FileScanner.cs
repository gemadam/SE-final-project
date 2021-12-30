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
        private ICollection<FileInfo> scanDir(string path)
        {
            var files = new List<FileInfo>();

            foreach (var dir in Directory.GetDirectories(path))
            {
                var ent = new DirectoryInfo(dir);

                files.AddRange(scanDir(ent.FullName));
            }

            foreach (var f in Directory.GetFiles(path))
                files.Add(new FileInfo(f));

            return files;
        }


        public ICollection<FileInfo> GetFiles(string path)
        {
            return scanDir(path);
        }
    }
}
