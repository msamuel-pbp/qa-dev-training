using System;
using NUnit.Framework;

namespace Chapter11
{
    [TestFixture]
    class Exercise3
    {
        public abstract class Telephone
        {
            protected string phonetype;

            public abstract void Ring();
        }

        public class DigitalPhone : Telephone
        {
            public DigitalPhone()
            {
                phonetype = "digital";
            }

            public override void Ring()
            {
                Console.WriteLine("I am " + phonetype);
            }
        }

        public class TalkingPhone : Telephone
        {
            public TalkingPhone()
            {
                phonetype = "talkingphone1000";
            }

            public override void Ring()
            {
                Console.WriteLine("I am " + phonetype);
            }
        }

        [Test]
        public void abstractedphones()
        {
            var d = new DigitalPhone();
            var t = new TalkingPhone();

            d.Ring();
            t.Ring();
        }
    }
}