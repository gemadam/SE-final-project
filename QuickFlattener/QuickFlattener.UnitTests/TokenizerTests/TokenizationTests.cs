using NUnit.Framework;
using QuickFlattener.Tokenization;
using System.IO;

namespace QuickFlattener.UnitTests
{
    public class TokenizationTests
    {
        private Tokenizer tokenizer;

        [SetUp]
        public void Setup()
        {
            tokenizer = new Tokenizer();
        }

        [Test]
        [TestCase("<<#FileNameToken#>>", "D:\\Studia\\[Sem-V][MaES]\\Presentation", ExpectedResult = "Presentation")]
        [TestCase("<<#FileNameToken#>>", "D:\\Test\\Path-to-file\\my File with space", ExpectedResult = "my File with space")]
        [TestCase("<<#FileNameToken#>>", "D:\\Test\\Path-to-file\\.exe", ExpectedResult = "")]
        public string FileNameToken__ShouldTokenizeInput(string sInputPattern, string sFileInfo)
        {
            FileInfo fileInfo = new FileInfo(sFileInfo);

            return tokenizer.Tokenize(sInputPattern, fileInfo);
        }

        [Test]
        [TestCase("<<#FileExtensionToken#>>", "D:\\Studia\\[Sem-V][MaES]\\Presentation.pptx", ExpectedResult = "pptx")]
        [TestCase("<<#FileExtensionToken#>>", "D:\\Test\\Path-to-file\\my File with space.exe", ExpectedResult = "exe")]
        [TestCase("<<#FileExtensionToken#>>", "D:\\Test\\Path-to-file\\NoExtension", ExpectedResult = "")]
        [TestCase("<<#FileExtensionToken#>>", "D:\\Test\\Path-to-file\\.gitignore", ExpectedResult = "gitignore")]
        public string FileExtensionToken__ShouldTokenizeInput(string sInputPattern, string sFileInfo)
        {
            FileInfo fileInfo = new FileInfo(sFileInfo);

            return tokenizer.Tokenize(sInputPattern, fileInfo);
        }

        [Test]
        [TestCase("<<#ConcatPathToken#>>", "D:\\Studia\\[Sem-V][MaES]\\Presentation.pptx", ExpectedResult = "D:---Studia---[Sem-V][MaES]---Presentation.pptx")]
        [TestCase("<<#ConcatPathToken#>>", "D:\\Studia\\----\\Presentation.pptx", ExpectedResult = "D:---Studia----------Presentation.pptx")]
        public string ConcatPathToken__ShouldTokenizeInput(string sInputPattern, string sFileInfo)
        {
            FileInfo fileInfo = new FileInfo(sFileInfo);

            return tokenizer.Tokenize(sInputPattern, fileInfo);
        }

        [Test]
        [TestCase("<<#ShortFilePathToken#>>", "D:\\Studia\\[Sem-V][MaES]\\Presentation.pptx", ExpectedResult = "D_St_[S_Pr_")]
        [TestCase("<<#ShortFilePathToken#>>", "D:\\Studia\\----\\Presentation.pptx", ExpectedResult = "D_St_--_Pr_")]
        public string ShortFilePathToken__ShouldTokenizeInput(string sInputPattern, string sFileInfo)
        {
            FileInfo fileInfo = new FileInfo(sFileInfo);

            return tokenizer.Tokenize(sInputPattern, fileInfo);
        }
    }
}