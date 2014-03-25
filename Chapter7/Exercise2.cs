using NUnit.Framework;

namespace Chapter7
{
    [TestFixture]
    public class Exercise2
    {
        public class Math
        {
            public static double Add(double One, double Two)
            {
                return (One + Two);
            }
            public static double Subtract(double One, double Two)
            {
                return (One - Two);
            }
            public static double Multiply(double One, double Two)
            {
                return (One * Two);
            }
            public static double Divide(double One, double Two)
            {
                return (One / Two);
            }
        }

        [Test]
        public void MathTest()
        {
            Assert.AreEqual(15d, Math.Add(10, 5), "Result should be 15");
            Assert.AreEqual(5d, Math.Subtract(10, 5), "Result should be 5");
            Assert.AreEqual(50d, Math.Multiply(10, 5), "Result should be 50");
            Assert.AreEqual(2d, Math.Divide(10, 5), "Result should be 2");
        }
    }
}