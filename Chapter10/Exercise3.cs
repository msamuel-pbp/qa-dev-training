using System;
using NUnit.Framework;

namespace Chapter10
{
    [TestFixture]
    class Exercise3
    {
        public class Dog
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public string[] Awards { get; set; }

            public Dog(string name, int weight, string[] awards)
            {
                Name = name;
                Weight = weight;
                Awards = awards;
            }

            public void printinfo()
            {
                Console.WriteLine("Name: {0}, Weight: {1}", Name, Weight);
            }
        }

        [Test]
        public void Woof()
        {
            Dog Milo   = new Dog("milo thunder",     26, new [] {"Best in Show", "Best of Breed", "Judge's Cup"});
            Dog Frisky = new Dog("frisky the awful", 10, new [] {"Worst Trained Toy Dog"});
            Dog Laika  = new Dog("laika the tiger",  50, new [] {"Best Working Dog", "Best Large Dog"});

            String[] dogs =
            {
                Milo.Name,
                Frisky.Name,
                Laika.Name
            };

            String[][] awardslist =
            {
                Milo.Awards,
                Frisky.Awards,
                Laika.Awards
            };

            for (int i = 0; i < dogs.Length; i++)
            {
                Console.Write("{0} : ", dogs[i]);
                
                for(int j = 0; j < awardslist[i].Length; j++)
                {
                    Console.Write("{0}, ", awardslist[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}