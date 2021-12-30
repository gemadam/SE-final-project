using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Tokenization
{
    public interface IToken
    {
        string Value();

        string Tokenize(FileInfo fileInfo);
    }
}
