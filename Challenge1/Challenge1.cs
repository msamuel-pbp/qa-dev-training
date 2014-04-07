using NUnit.Framework;
using System;

namespace Challenge1
{
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    // The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.

    [TestFixture]
    public class Challenge1
    {
        public class NaturalSum35
        {
            private int number;

            public NaturalSum35(int number)
            {
                this.number = number;
            }

            public void print()
            {
                int sum = 0;
                for (int i = 0; i < number; i++)
                {
                    if ((i%3 == 0) || (i%5 == 0))
                    {
                        sum += i;
                    }
                }

                Console.WriteLine("Sum of multiples of 3 and 5 for numbers less than {0} is: {1}", number, sum);
            }
        }

        [Test]
        public void NaturalTest()
        {
            NaturalSum35 ns = new NaturalSum35(10);
            ns.print();
        }
    }
}