using System;
using NUnit.Framework;

namespace Chapter7
{
    [TestFixture]
    public class Exercise3
    {
        public class Book
        {
            private string title;
            private string author;
            private string publisher = "O’Reilly";
            private string ISBN;

            public Book(string title, string author, string ISBN)
            {
                this.title = title;
                this.author = author;
                this.ISBN = ISBN;
            }

            public void DisplayBook()
            {
                Console.WriteLine("Title is {0}", title);
                Console.WriteLine("Author is {0}", author);
                Console.WriteLine("Publisher is {0}", publisher);
                Console.WriteLine("ISBN is {0}", ISBN);
            }
        }

        [Test]
        public void Books()
        {
            Book progC3 = new Book("Programming C# 3.0", "Jesse Liberty and Donald Xie", "9780596527433");
            Book nutC3 = new Book("C# 3.0 In a Nutshell", "Joseph Albahari and Ben Albahari", "9780596527570");
            Book cookC3 = new Book("C# 3.0 Cookbook", "Jay Hilyard and Stephen Teilhet", "9780596516109");

            progC3.DisplayBook();
            nutC3.DisplayBook();
            cookC3.DisplayBook();
        }
    }
}