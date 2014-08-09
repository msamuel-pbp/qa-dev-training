using System;
using NUnit.Framework;

namespace Chapter11
{
    [TestFixture]
    public class Exercise1
    {
        public class Telephone
        {
            private string phonetype;

            public Telephone(string type)
            {
                phonetype = type;
            }

            public void Ring()
            {
                Console.WriteLine("Ringing the " + phonetype);
            }
        }

        class ElectricPhone : Telephone
        {
            public ElectricPhone() : base("digital") {}
        }

        [Test]
        public void ringthyphone()
        {
            var iphone = new ElectricPhone();
            iphone.Ring();
        }
    }
}