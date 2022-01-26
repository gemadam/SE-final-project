using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Tokenization
{
    internal class FileExtensionToken : IToken
    {
        public string Value()
        {
            return "<<#FileExtensionToken#>>";
        }

        public string Tokenize(FileInfo fileInfo)
        {
            if (fileInfo.Extension.Length < 2)
                return "";

            return fileInfo.Extension.Remove(0, 1);
        }
    }
}
