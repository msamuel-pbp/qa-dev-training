using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Chapter16 {
    [TestFixture]
    public class Exercise4 {
        private List<Cat> catlist = new List<Cat>();

        public class CustomCatError : Exception {
            public CustomCatError(string message) : base(message) {}
        }

        public class Cat {
            public int Age { get; set; }
        }

        private void CheckAge(int age) {
            if ((age <= 0) || (age > 25)) {
                var e = new CustomCatError("Cats can only be within 1-25 years");
                e.HelpLink = "http://en.wikipedia.org/wiki/Cat_years";
                throw e;
            }
        }

        public void AddCat(object value) {
            try {
                Console.WriteLine("Processing cat that is {0} years old", value);

                if (!(value is int)) {
                    throw new FormatException();
                }
                var age = (int) value;

                CheckAge(age);

                Cat c = new Cat();
                c.Age = age;
                catlist.Add(c);
            } catch (CustomCatError e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.HelpLink);
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