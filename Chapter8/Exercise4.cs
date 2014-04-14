using System;
using NUnit.Framework;

namespace Chapter8
{
    [TestFixture]
    public class Exercise4
    {
        public class Tester
        {
            public void DoubleTrip(int value, out int doubleval, out int tripleval)
            {
                doubleval = value * 2;
                tripleval = value * 3;
            }
        }

        [Test]
        public void math()
        {
            int value = 5;
            int doubleval;
            int tripleval;
            Tester test = new Tester();

            test.DoubleTrip(value, out doubleval, out tripleval);

            Console.WriteLine("Value is {0}. Doubled is {1} and Tripled is {2}", value, doubleval, tripleval);
        }
    }
}
