using NUnit.Framework;

namespace Chapter13
{
    [TestFixture]
    class Exercise2
    {
        public interface IConvertible
        {
            string ConvertToCSharp(string s);
            string ConvertToVB(string s);
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
        }

        [Test]
        public void Conversion()
        {
            var p = new ProgramHelper();

            Assert.True(p.ConvertToCSharp("test").Equals("Converted to CSharp!"));
            Assert.True(p.ConvertToVB("test").Equals("Converted to VB!"));
        }
    }
}
