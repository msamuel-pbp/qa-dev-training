using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Chapter14
{
    [TestFixture]
    public class Exercise2
    {
        public abstract class Animal : IComparable<Animal>
        {
            protected int weight;
            protected string name;

            protected Animal(int weight, string name)
            {
                this.weight = weight;
                this.name = name;
            }

            public abstract void Speak();
            public abstract void Move();
            public abstract override string ToString();

            public int CompareTo(Animal rhs)
            {
                return weight.CompareTo(rhs.weight);
            }
        }

        public class Dog : Animal
        {
            public Dog(int weight, string name) : base(weight, name) { }

            public override void Speak()
            {
                Console.WriteLine("woof");
            }
            public override void Move()
            {
                Console.WriteLine("dog moves");
            }
            public override string ToString()
            {
                return String.Format("Animal is {0} with name {1} and weight {2}", GetType().Name, name, weight);
            }
        }

        public class Cat : Animal
        {
            public Cat(int weight, string name) : base(weight, name) { }

            public override void Speak()
            {
                Console.WriteLine("meow");
            }
            public override void Move()
            {
                Console.WriteLine("cat moves");
            }
            public override string ToString()
            {
                return String.Format("Animal is {0}, name {1}, weight {2}", GetType().Name, name, weight);
            }
        }

        [Test]
        public void AnimalArray()
        {
            var rng = new Random(Guid.NewGuid().GetHashCode());

            var aAnimals = new List<Animal>();

            aAnimals.Add(new Cat(rng.Next(20), "cat1"));
            aAnimals.Add(new Dog(rng.Next(20), "dog1"));
            aAnimals.Add(new Cat(rng.Next(20), "cat2"));
            aAnimals.Add(new Dog(rng.Next(20), "dog2"));
            aAnimals.Add(new Cat(rng.Next(20), "cat3"));

            Console.WriteLine("Not Sorted");
            foreach (var beast in aAnimals)
            {
                Console.WriteLine(beast);
            }

            Console.WriteLine("------");
            Console.WriteLine("Sorted");
            aAnimals.Sort();
            foreach (var beast in aAnimals)
            {
                Console.WriteLine(beast);
            }
        }
    }
}
