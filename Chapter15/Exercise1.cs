using System;
using NUnit.Framework;

namespace Chapter15
{
    [TestFixture]
    public class Exercise1
    {
        [Test]
        public void manystrings()
        {
            string s1 = "Hello ";
            string s2 = "World";
            string s3 = @"Come visit us at http://www.LibertyAssociates.com";
            string s4 = s1 + s2;
            string s5 = "world";
            string s6 = String.Copy(s3);

            string[] sarray = { s1,s2,s3,s4,s5,s6 };

            foreach (string s in sarray)
            {
                Console.WriteLine("String is --- \"{0}\"", s);
                Console.WriteLine("Length: {0}", s.Length);
                Console.WriteLine("3rd char: {0}", s[2]);
                Console.WriteLine("H char present: {0}", s.IndexOf('H') >= 0);
                Console.WriteLine("Equal to s2: {0}", s == s2);
                Console.WriteLine("Equal to s2 (case insensitive): {0}", (String.Compare(s, s2, true) == 0));
                Console.WriteLine("---");
            }
        }
    }
}
