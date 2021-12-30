
using QuickFlattener.Tokenization;
using System.IO;

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
