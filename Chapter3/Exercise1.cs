using System;
using NUnit.Framework;

namespace Chapter3
{
    [TestFixture]
    public class Exercise1
    {
        [Test]
        public void printvalues()
        {
            int myint = 42;
            float myfloat = (float) 98.6;
            double mydouble = 12345.6789;
            char mychar = 'Z';
            string mystring = "The quick brown fox jumped over the lazy dogs";

            Console.WriteLine("int : " + myint);
            Console.WriteLine("float : " + myfloat);
            Console.WriteLine("double : " + mydouble);
            Console.WriteLine("char : " + mychar);
            Console.WriteLine("string : " + mystring);
        }
    }
}
