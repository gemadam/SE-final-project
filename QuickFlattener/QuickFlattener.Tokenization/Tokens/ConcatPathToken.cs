
using QuickFlattener.Tokenization;
using System.IO;

namespace QuickFlattener.Tokenization
{
    /// <summary>
    /// Token represents concatenated path to the file. F.e:
    /// <code>E:\Movies\Komedie\Piraci z Karaibów Na krańcu świata.mp4</code>
    /// Will result in:
    /// <code>E:---Movies---Komedie---Piraci z Karaibów Na krańcu świata.mp4</code>
    /// </summary>
    internal class ConcatPathToken : IToken
    {
        public string Value()
        {
            return "<<#ConcatPathToken#>>";
        }

        public string Tokenize(FileInfo fileInfo)
        {
            var o = fileInfo.FullName.Replace(Path.DirectorySeparatorChar.ToString(), "---");

            return o;
        }
    }
}

