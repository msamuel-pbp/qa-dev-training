using System.IO;
using NUnit.Framework;
using System;

namespace Chapter8
{
    [TestFixture]
    public class Exercise1
    {
        public class Tester
        {
            private static int ival = 1;
            private static float fval = 1;

            public static int Ival
            {
                get { return ival; }
                set { ival = value; }
            }

            public static float Fval
            {
                get { return fval; }
                set { fval = value; }
            }

            public static int tripler(int val)
            {
                return val*3;
            }
            public static float tripler(float val)
            {
                return val*3;
            }
            public static void tripler(ref int val)
            {
                val *= 3;
            }
            public static void tripler(ref float val)
            {
                val *= 3;
            }
            public static void triplerset(out int val)
            {
                val = ival*3;
            }
            public static void triplerset(out float val)
            {
                val = fval*3;
            }
        }

        [Test]
        public void TestMe()
        {
            int myint = 3;
            float myfloat = 5f;
            Tester.Ival = myint;
            Tester.Fval = myfloat;

            Console.WriteLine("Original int value: {0}", myint);
            Console.WriteLine("Original float value: {0}", myfloat);
            Console.WriteLine("Via Return int value: {0}", Tester.tripler(myint));
            Console.WriteLine("Via Return float value: {0}", Tester.tripler(myfloat));
            Tester.tripler(ref myint);
            Tester.tripler(ref myfloat);
            Console.WriteLine("Referenced int value: {0}", myint);
            Console.WriteLine("Referenced float value: {0}", myfloat);

            int myemptyint;
            float myemptyfloat;
            Tester.triplerset(out myemptyint);
            Tester.triplerset(out myemptyfloat);
            Console.WriteLine("Out int value: {0}", myemptyint);
            Console.WriteLine("Out float value: {0}", myemptyfloat);
        }
    }
}