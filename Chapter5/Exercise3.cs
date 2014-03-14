using System;
using NUnit.Framework;

namespace Chapter5
{
    [TestFixture]
    class Exercise3
    {
        enum condition
        {
            toobig,
            even,
            odd,
            multiple,
            zero,
            unknown
        }

        [Test]
        public void validate()
        {
            Console.Write("Enter in a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var value = condition.unknown;

            value = (input % 2 == 0) ? condition.even : condition.odd;
            if (input % 10 == 0) { value = condition.multiple; }
            if (input == 0) { value = condition.zero; }
            if (input > 100) { value = condition.toobig; }
            
            switch (value)
            {
                case condition.even:
                    Console.WriteLine("Even");
                    break;
                case condition.odd:
                    Console.WriteLine("Odd");
                    break;
                case condition.multiple:
                    Console.WriteLine("Multiple of 10");
                    break;
                case condition.toobig:
                    Console.WriteLine("Greater than 100");
                    break;
                case condition.zero:
                    Console.WriteLine("Zero");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            };
        }
    }
}