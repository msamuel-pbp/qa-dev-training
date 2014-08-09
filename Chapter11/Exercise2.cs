using System;
using NUnit.Framework;

namespace Chapter11
{
    [TestFixture]
    class Exercise2
    {
        public class Telephone
        {
            protected string phonetype;

            public virtual void Ring()
            {
                Console.WriteLine("Ringing the " + phonetype);
            }
        }

        class PublicBellPhone : Telephone
        {
            public PublicBellPhone()
            {
                phonetype = "Analog";
            }
        }

        public class iPhone : Telephone
        {
            public override void Ring()
            {
                Console.WriteLine("Siri says hi!");
            }
        }

        [Test]
        public void ringthyphone()
        {
            var rotary = new PublicBellPhone();
            rotary.Ring();
            
            var digital = new iPhone();
            digital.Ring();
        }
    }
}