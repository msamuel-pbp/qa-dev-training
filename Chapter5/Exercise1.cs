using System;
using NUnit.Framework;

namespace Chapter5
{
    [TestFixture]
    public class Exercise1
    {
        [Test]
        public void counter()
        {
            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine(count++);
            }

            count = 1;
            do
            {
                Console.WriteLine(count++);
            } while (count <= 10);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
