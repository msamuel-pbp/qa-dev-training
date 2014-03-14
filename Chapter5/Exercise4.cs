using System;
using NUnit.Framework;

namespace Chapter5
{
    [TestFixture]
    class Exercise4
    {
        [Test]
        public void crossed()
        {
            int i;
            int j;
            for (i = 0, j = 25; i < j; i++, j--)
            {
                Console.WriteLine("i is {0} and j is {1}", i, j);
            }
            Console.WriteLine("Crossed over! i is {0} and j is {1}", i, j);
        }
    }
}
