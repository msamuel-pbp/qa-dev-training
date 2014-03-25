using NUnit.Framework;

namespace Chapter7
{
    [TestFixture]
    public class Exercise1
    {
        public class Math
        {
            public double Add(double One, double Two)
            {
                return (One + Two);
            }
            public double Subtract(double One, double Two)
            {
                return (One - Two);
            }
            public double Multiply(double One, double Two)
            {
                return (One*Two);
            }
            public double Divide(double One, double Two)
            {
                return (One/Two);
            }
        }

        [Test]
        public void MathTest()
        {
            Math calc = new Math();
            Assert.AreEqual(15d, calc.Add(10,5), "Result should be 15");
            Assert.AreEqual(5d, calc.Subtract(10, 5), "Result should be 5");
            Assert.AreEqual(50d, calc.Multiply(10, 5), "Result should be 50");
            Assert.AreEqual(2d, calc.Divide(10, 5), "Result should be 2");
        }
    }
}