using System;
using NUnit.Framework;

namespace Chapter10
{
    [TestFixture]
    class Exercise2
    {
        [Test]
        public void inputarray()
        {
            var r = new Random();

            int[] inarray = new int[10];
            for (int i = 0; i < inarray.Length; i++)
            {
                inarray[i] = r.Next(0, 1000000);
            }

            Array.Sort(inarray);
            Array.Reverse(inarray);

            foreach (int i in inarray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
