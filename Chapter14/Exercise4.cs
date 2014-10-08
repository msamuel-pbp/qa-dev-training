using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Chapter14
{
    [TestFixture]
    public class Exercise4
    {
        abstract public class Animal : IComparable<Animal>
        {
            protected int weight;
            protected string name;

            protected Animal(int weight, string name)
            {
                this.weight = weight;
                this.name = name;
            }

            abstract public void Speak();
            abstract public void Move();
            abstract public override string ToString();

            public static AnimalComparer GetComparer()
            {
                return new AnimalComparer();
            }

            public int CompareTo(Animal rhs)
            {
                return weight.CompareTo(rhs.weight);
            }

            public int CompareTo(Animal rhs, AnimalComparer.ComparisonType whichComparisonType)
            {
                switch (whichComparisonType)
                {
                    case AnimalComparer.ComparisonType.Weight:
                        return weight.CompareTo(rhs.weight);
                    case AnimalComparer.ComparisonType.Name:
                        return name.CompareTo(rhs.name);
                }

                return -1;
            }

            public class AnimalComparer : IComparer<Animal>
            {
                public enum ComparisonType
                {
                    Weight,
                    Name
                }

                private ComparisonType whichComparisonType;
                public ComparisonType WhichComparison
                {
                    get { return whichComparisonType; }
                    set { whichComparisonType = value; }
                }

                public int Compare(Animal lhs, Animal rhs)
                {
                    return lhs.CompareTo(rhs, whichComparisonType);
                }
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

            aAnimals.Add(new Cat(rng.Next(20), "andy"));
            aAnimals.Add(new Dog(rng.Next(20), "bert"));
            aAnimals.Add(new Cat(rng.Next(20), "cathy"));
            aAnimals.Add(new Dog(rng.Next(20), "doggy"));
            aAnimals.Add(new Cat(rng.Next(20), "eggy"));

            Console.WriteLine("------");
            Console.WriteLine("Sort by Weight");
            var compare = Animal.GetComparer();
            compare.WhichComparison = Animal.AnimalComparer.ComparisonType.Weight;
            aAnimals.Sort(compare);
            foreach (var beast in aAnimals)
            {
                Console.WriteLine(beast);
            }

            Console.WriteLine("------");
            Console.WriteLine("Sort by Name");
            compare.WhichComparison = Animal.AnimalComparer.ComparisonType.Name;
            aAnimals.Sort(compare);
            foreach (var beast in aAnimals)
            {
                Console.WriteLine(beast);
            }
        }
    }
}
