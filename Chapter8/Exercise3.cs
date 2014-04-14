using System;
using NUnit.Framework;

namespace Chapter8
{
    [TestFixture]
    public class Exercise3
    {
        public class Tester
        {
            public void DoubleTrip(int value, ref int doubleval, ref int tripleval)
            {
                doubleval = value*2;
                tripleval = value*3;
            }
        }

        [Test]
        public void math()
        {
            int value = 5;
            int doubleval = value;
            int tripleval = value;
            Tester test = new Tester();

            test.DoubleTrip(value, ref doubleval, ref tripleval);

            Console.WriteLine("Value is {0}. Doubled is {1} and Tripled is {2}", value, doubleval, tripleval);
        }
    }
}
