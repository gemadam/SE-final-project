using QuickFlattener.Tokenization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Flattening
{
    public class FileMapper
    {
        private readonly Tokenizer _tokenizer;


        public FileMapper()
        {
            _tokenizer = new Tokenizer();
        }

        /// <summary>
        /// Method maps files on the specific output.
        /// </summary>
        /// <param name="files">Files to be mapped.</param>
        /// <param name="sOutputPattern">Untokenized output pattern.</param>
        /// <returns>Files mapping.</returns>
        public IDictionary<string, List<FileInfo>> MapFiles(ICollection<FileInfo> files, string sOutputPattern)
        {
            var outVal = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                var tokenizedPath = _tokenizer.Tokenize(sOutputPattern, file);

                if (outVal.ContainsKey(tokenizedPath))  // Conflict
                    outVal[tokenizedPath].Add(file);
                else                                    // First time here
                    outVal.Add(tokenizedPath, new List<FileInfo>() { file });
            }

            return outVal;
        }
    }
}
