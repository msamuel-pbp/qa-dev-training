using System;
using NUnit.Framework;

namespace Chapter3
{
    [TestFixture]
    class Exercise2
    {
        [Test]
        public void updatevalues()
        {
            int myint = 42;
            float myfloat = (float)98.6;
            double mydouble = 12345.6789;
            char mychar = 'Z';
            string mystring = "The quick brown fox jumped over the lazy dogs";

            Console.WriteLine("int : " + myint);
            Console.WriteLine("float : " + myfloat);
            Console.WriteLine("double : " + mydouble);
            Console.WriteLine("char : " + mychar);
            Console.WriteLine("string : " + mystring);

            myint = 25;
            myfloat = (float) 100.3;
            mydouble = 98765.4321;
            mychar = 'M';
            mystring = "A quick movement of the enemy will jeopardize six gun boats.";

            Console.WriteLine("updated int : " + myint);
            Console.WriteLine("updated float : " + myfloat);
            Console.WriteLine("updated double : " + mydouble);
            Console.WriteLine("updated char : " + mychar);
            Console.WriteLine("updated string : " + mystring);
        }
    }
}
