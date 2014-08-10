using NUnit.Framework;

namespace Chapter13
{
    [TestFixture]
    public class Exercise1
    {
        public interface IConvertible
        {
            string ConvertToCSharp(string s);
            string ConvertToVB(string s);
        }

        [Test]
        public void InterfaceRef()
        {
            var aconv = new IConvertible[5];
            Assert.IsNotNull(aconv);
        }
    }
}