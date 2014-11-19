using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Chapter16 {
    [TestFixture]
    public class Exercise3 {
        private List<Cat> catlist = new List<Cat>();

        public class Cat {
            public int Age { get; set; }
        }

        public void AddCat(object value) {
            try {
                Console.WriteLine("Processing cat that is {0} years old", value);

                if (!(value is int)) {
                    throw new FormatException();
                }

                var age = (int)value;
                if ((age <= 0) || (age > 25)) {
                    throw new ArgumentOutOfRangeException();
                }

                Cat c = new Cat();
                c.Age = age;
                catlist.Add(c);
            } catch (ArgumentOutOfRangeException) {
                Console.WriteLine("Cats can only be within 1-25 years");
            } catch (Exception e) {
                Console.WriteLine("Unknown error happened: {0}", e.Message);
            } finally {
                Console.WriteLine("Cat consumed");
                catlist.Clear();
            }
        }

        [Test]
        public void TestAge() {
            AddCat(1);
            AddCat(6);
            AddCat(11);
            AddCat('a');
            AddCat(-1);
            AddCat(0);
            AddCat(26);
        }
    }
}