using System;
using NUnit.Framework;

namespace Chapter4
{
    [TestFixture]
    class Exercise4
    {
        private const float PI = 3.14159f;
        private const float RADIUS = 5f;

        private float calcsurfacearea()
        {
            return 4f * PI * (RADIUS * RADIUS);
        }

        private float calcvolume()
        {
            return (4f / 3f) * PI * (RADIUS * RADIUS * RADIUS);
        }

        [Test]
        public void calcsphere()
        {
            Console.WriteLine("Surface area is {0}", calcsurfacearea());
            Console.WriteLine("Volume is {0}", calcvolume());
            float larger = calcsurfacearea() > calcvolume() ? calcsurfacearea() : calcvolume();
            Console.WriteLine("Larger is {0}", larger);
        }
    }
}