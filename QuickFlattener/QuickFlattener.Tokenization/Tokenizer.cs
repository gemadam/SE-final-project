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

        /// <summary>
        /// Default constructor. Initializes all tokens.
        /// </summary>
        public Tokenizer()
        {
            tokens = new List<IToken>();

            tokens.Add(new FileNameToken());
            tokens.Add(new ShortFilePathToken());
            tokens.Add(new FileExtensionToken());
            tokens.Add(new ConcatPathToken());
        }

        /// <summary>
        /// Function populates input string with data.
        /// </summary>
        /// <param name="input">Input to be tokenized.</param>
        /// <param name="fileInfo">Data to be used in tokenization.</param>
        /// <returns>Tokenized string.</returns>
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
