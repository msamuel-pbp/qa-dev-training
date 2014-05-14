using System;
using NUnit.Framework;

namespace Chapter10
{
    [TestFixture]
    public class Exercise1
    {
        public class Dog
        {
            public string Name { get; set; }
            public int Weight { get; set; }

            public Dog(string name, int weight)
            {
                Name = name;
                Weight = weight;
            }

            public void printinfo()
            {
                Console.WriteLine("Name: {0}, Weight: {1}", Name, Weight);
            }
        }

        [Test]
        public void Woof()
        {
            Dog Milo = new Dog("milo thunder", 26);
            Dog Frisky = new Dog("frisky the awful", 10);
            Dog Laika = new Dog("laika the tiger", 50);

            var darray = new Dog[3];
            darray[0] = Milo;
            darray[1] = Frisky;
            darray[2] = Laika;

            for (int i = 0; i < darray.Length; i++)
            {
                darray[i].printinfo();
            }

            Dog[] darray2 = {
                Milo,
                Frisky,
                Laika
            };

            foreach (Dog d in darray2)
            {
                d.printinfo();
            }
        }
    }
}