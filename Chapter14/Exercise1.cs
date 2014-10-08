using System;
using NUnit.Framework;

namespace Chapter14
{
    [TestFixture]
    public class Exercise1
    {
        public abstract class Animal
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
        }

        public class Dog : Animal
        {
            public Dog(int weight, string name) : base(weight, name) {}

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
            public Cat(int weight, string name) : base(weight, name) {}

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
                return String.Format("Animal is {0} with name {1} and weight {2}", GetType().Name, name, weight);
            }
        }

        [Test]
        public void AnimalArray()
        {
            var rng = new Random(Guid.NewGuid().GetHashCode());

            var aAnimals = new Animal[5];
            aAnimals[0] = new Cat(rng.Next(20), "cat1");
            aAnimals[1] = new Dog(rng.Next(20), "dog1");
            aAnimals[2] = new Cat(rng.Next(20), "cat2");
            aAnimals[3] = new Dog(rng.Next(20), "dog2");
            aAnimals[4] = new Cat(rng.Next(20), "cat3");
            
            foreach(var beast in aAnimals)
            {
                Console.WriteLine(beast);
                beast.Speak();
                beast.Move();
            }
        }
    }
}
