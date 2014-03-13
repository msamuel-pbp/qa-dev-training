using System;
using NUnit.Framework;

namespace Chapter4
{
    [TestFixture]
    public class Exercise1
    {
        [Test]
        public void calcstuff()
        {
            int x = 25;
            int y = 5;

            Console.WriteLine("Sum is {0}", x + y);
            Console.WriteLine("Difference is {0}", x - y);
            Console.WriteLine("Product is {0}", x * y);
            Console.WriteLine("Quotient is {0}", x / y);
            Console.WriteLine("Modulus is {0}", x % y);
        }
    }
}
