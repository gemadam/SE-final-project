using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Tokenization
{
    /// <summary>
    /// Token represents file extension without a dot. F.e:
    /// <code>E:\Movies\Komedie\Piraci z Karaibów Na krańcu świata.mp4</code>
    /// Will result in:
    /// <code>.mp4</code>
    /// </summary>
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
