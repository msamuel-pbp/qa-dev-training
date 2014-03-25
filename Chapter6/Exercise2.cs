using NUnit.Framework;

namespace Chapter6
{
    [TestFixture]
    public class Exercise2
    {
        public class Book
        {
            private string title;
            private string author;
            private string ISBN;

            public void Read()
            {
                // read the book
            }

            public void Shelve()
            {
                // shelve the book
            }
        }

        [Test]
        public void checkBook()
        {
            Book fairytale = new Book();

            fairytale.Read();
            fairytale.Shelve();
        }
    }
}
