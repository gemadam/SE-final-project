using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Tokenization
{
    public class Tokenizer
    {
        ICollection<IToken> tokens;

        public Tokenizer()
        {
            tokens = new List<IToken>();

            tokens.Add(new FileNameToken());
            tokens.Add(new ShortFilePathToken());
            tokens.Add(new FileExtensionToken());
            tokens.Add(new ConcatPathToken());
        }

        public string Tokenize(string input, FileInfo fileInfo)
        {
            var output = input;

            foreach (var token in tokens)
            {
                var tokenValue = token.Value();

                output = output.Replace(tokenValue, token.Tokenize(fileInfo));
            }


            return output;
        }
    }
}
