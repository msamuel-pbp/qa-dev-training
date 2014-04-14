using System;
using NUnit.Framework;

namespace Chapter8
{
    [TestFixture]
    public class Exercise2
    {
        public enum Color
        {
            White = 1,
            Yellow = 2,
            Orange = 3,
            Red = 4,
            Green = 5,
            Blue = 6,
            Purple = 7,
            Brown = 8,
            Black = 9,
            Unknown = 0
        }

        public class Dog
        {
            private int weight;
            private Color color;

            public Dog()
            {
                weight = 0;
                color = Color.Unknown;
            }

            public Dog(int weight, Color color)
            {
                this.weight = weight;
                this.color = color;
            }

            public int Weight {
                get { return weight; }
                set { weight = value; } 
            }

            public Color Color
            {
                get { return color; } 
                set { color = value; }
            }

            public void report()
            {
                Console.WriteLine("Dog's weight = {0}", weight);
                Console.WriteLine("Dog's color = {0}", color);
            }
        }

        [Test]
        public void DogColor()
        {
            int weight = 50;
            Color color = Color.Red;
            Dog duckHound = new Dog(weight, color);
            duckHound.report();

            duckHound.Weight = 60;
            duckHound.Color = Color.Black;
            Console.WriteLine("Dog's weight = {0}", duckHound.Weight);
            Console.WriteLine("Dog's color = {0}", duckHound.Color);
        }
    }
}