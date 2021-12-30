using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Tokenization
{
    internal class ShortFilePathToken : IToken
    {
        public string Value()
        {
            return "<<#ShortFilePathToken#>>";
        }

        public string Tokenize(FileInfo fileInfo)
        {
            var o = string.Empty;

            string[] a = fileInfo.FullName.Split(Path.DirectorySeparatorChar);
            foreach (var e in a)
            {
                var value = e.Substring(0, 2) + "_";

                foreach (var il in Path.GetInvalidFileNameChars())
                    value = value.Replace(il.ToString(), string.Empty);

                o += value;
            }

            return o;
        }
    }
}
