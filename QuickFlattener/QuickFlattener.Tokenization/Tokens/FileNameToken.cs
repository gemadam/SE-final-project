using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Tokenization
{
    /// <summary>
    /// Token represents file name without extension. F.e:
    /// <code>E:\Movies\Komedie\Piraci z Karaibów Na krańcu świata.mp4</code>
    /// Will result in:
    /// <code>Piraci z Karaibów Na krańcu świata</code>
    /// </summary>
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
