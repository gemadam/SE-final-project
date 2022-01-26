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

        public IDictionary<string, List<FileInfo>> MapFiles(ICollection<FileInfo> files, string sOutputPattern)
        {
            var outVal = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                var tokenizedPath = _tokenizer.Tokenize(sOutputPattern, file);

                if (outVal.ContainsKey(tokenizedPath))
                    outVal[tokenizedPath].Add(file);
                else
                    outVal.Add(tokenizedPath, new List<FileInfo>() { file });
            }

            return outVal;
        }
    }
}
