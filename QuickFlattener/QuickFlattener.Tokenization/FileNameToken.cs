using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Tokenization
{
    internal class FileNameToken : IToken
    {
        public string Value()
        {
            return "<<#FileNameToken#>>";
        }

        public string Tokenize(FileInfo fileInfo)
        {
            return Path.GetFileNameWithoutExtension(fileInfo.Name);
        }
    }
}
