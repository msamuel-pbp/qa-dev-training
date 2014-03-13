using System;
using NUnit.Framework;

namespace Chapter3
{
    [TestFixture]
    class Exercise4
    {
        enum Calendar : int
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        [Test]
        public void printenumerate()
        {
            Console.WriteLine("June is {0}", (int) Calendar.June);
        }
    }
}
