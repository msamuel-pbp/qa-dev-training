using System;
using NUnit.Framework;

namespace Chapter4
{
    [TestFixture]
    class Exercise2
    {
        [Test]
        public void prepost()
        {
            int varA = 5;
            int varB = ++varA;
            int varC = varB++;
            Console.WriteLine("A: {0}, B: {1}, C: {2}", varA, varB, varC);
        }
    }
}
