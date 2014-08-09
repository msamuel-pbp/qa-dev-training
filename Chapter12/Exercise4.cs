using System;
using NUnit.Framework;

namespace Chapter12
{
    [TestFixture]
    class Exercise4
    {
        private const double FeetInMeters = 3.28084;

        public class Foot
        {
            public double Length { get; set; }

            public Foot(double feet) { Length = feet; }
            public Foot(Meter m)     { Length = m.Length * FeetInMeters; }

            public static explicit operator Meter(Foot f)
            {
                return new Meter(f);
            }

            public override string ToString()
            {
                return "Length in Feet is " + Length; ;
            }
        }

        public class Meter
        {
            public double Length { get; set; }

            public Meter(double meter) { Length = meter; }
            public Meter(Foot f)       { Length = f.Length / FeetInMeters; }

            public static explicit operator Foot(Meter m)
            {
                return new Foot(m);
            }

            public override string ToString()
            {
                return "Length in Meters is " + Length;
            }
        }

        [Test]
        public void NewFoot()
        {
            var f = new Foot(5);
         
            Console.WriteLine(f);
            Assert.True(f.Length == 5d);
        }

        [Test]
        public void NewMeter()
        {
            var m = new Meter(5);

            Console.WriteLine(m);
            Assert.True(m.Length == 5d);
        }

        [Test]
        public void FootToMeter()
        {
            var f = new Foot(5);
            var m = (Meter) f;

            Console.WriteLine(f);
            Console.WriteLine(m);
            Assert.True(m.Length == f.Length / FeetInMeters);
        }

        [Test]
        public void MeterToFoot()
        {
            var m = new Meter(5);
            var f = (Foot) m;

            Console.WriteLine(f);
            Console.WriteLine(m);
            Assert.True(f.Length == m.Length * FeetInMeters);            
        }
    }
}
