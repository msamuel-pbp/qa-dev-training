using System;
using NUnit.Framework;

namespace Chapter5
{
    [TestFixture]
    class Exercise2
    {
        [Test]
        public void validate()
        {
            Console.Write("Enter in a number: ");
            var input = Convert.ToInt32(Console.ReadLine());

            if (input <= 100)
            {
                if (input % 2 == 0)
                {
                    if (input == 0)
                    {
                        Console.WriteLine("Zero is not even, odd, or multiple of 10");
                    }
                    else
                    {
                        if (input % 10 == 0)
                        {
                            Console.WriteLine("Multiple of 10");
                        }
                        else
                        {
                            Console.WriteLine("Input is even");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Input is odd");
                }
            }
            else
            {
                Console.WriteLine("Input is too large");
            }
        }
    }
}
