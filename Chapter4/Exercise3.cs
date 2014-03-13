using System;
using NUnit.Framework;

namespace Chapter4
{
    [TestFixture]
    class Exercise3
    {
        private bool calcweight(int person1, int person2)
        {
            const int MAXWEIGHT = 300;
            const int MINWEIGHT = 100;

            return ((person1 + person2 > MINWEIGHT) && (person1 + person2 <= MAXWEIGHT));
        }

        [Test]
        public void amuse()
        {
            const int ABBY = 135;
            const int BOB = 175;
            const int CHARLIE = 55;
            const int DAWN = 45;

            Console.WriteLine("Abby and Bob can ride? {0}", calcweight(ABBY, BOB));
            Console.WriteLine("Bob and Charlie can ride? {0}", calcweight(BOB, CHARLIE));
            Console.WriteLine("Charlie and Dawn can ride? {0}", calcweight(CHARLIE, DAWN));
        }
    }
}