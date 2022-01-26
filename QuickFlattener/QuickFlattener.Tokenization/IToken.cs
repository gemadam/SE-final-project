using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Tokenization
{
    /// <summary>
    /// General interface of token
    /// </summary>
    public interface IToken
    {
        /// <summary>
        /// Token string. A substring that will be replaced with data.
        /// </summary>
        /// <returns>Token value.</returns>
        string Value();

        /// <summary>
        /// Function replaces token value with data.
        /// </summary>
        /// <param name="fileInfo">Data to be used.</param>
        /// <returns>Tokenized string.</returns>
        string Tokenize(FileInfo fileInfo);
    }
}
