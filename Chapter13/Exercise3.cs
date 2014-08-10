using NUnit.Framework;

namespace Chapter13
{
    [TestFixture]
    class Exercise3
    {
        public interface IConvertible
        {
            string ConvertToCSharp(string s);
            string ConvertToVB(string s);
        }

        public interface ICodeChecker : IConvertible
        {
            bool CodeCheckSyntax(string s, string language);
        }

        public class ProgramHelper : IConvertible
        {
            public string ConvertToCSharp(string s)
            {
                return "Converted to CSharp!";
            }

            public string ConvertToVB(string s)
            {
                return "Converted to VB!";
            }

            public bool CodeCheckSyntax(string s, string language)
            {
                return (language.Equals("CSharp") || language.Equals("VB"));
            }
        }

        [Test]
        public void CorrectLanguage()
        {
            var p = new ProgramHelper();

            Assert.True(p.CodeCheckSyntax("test", "CSharp"));
            Assert.That(p.CodeCheckSyntax("test", "VB"));
        }

        [Test]
        public void IncorrectLanguage()
        {
            var p = new ProgramHelper();

            Assert.False(p.CodeCheckSyntax("test", ""));
            Assert.False(p.CodeCheckSyntax("test", "test"));
        }
    }
}
