using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21 {
    public class Sample1 {
        public class Book {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public int PublicationYear { get; set; }
        }
        public class Books : List<Book> { }

        public class PurchaseOrder {
            public int OrderNumber { get; set; }
            public string Title { get; set; }
            public int Quantity { get; set; }
        }
        public class PurchaseOrders : List<PurchaseOrder> { }

        public static void Maint(string[] args) {
            var bookList = new Books {
                new Book { Title = "Learning C# 3.0",
                           Author = "Jesse Liberty",
                           Publisher = "O'Reilly",
                           PublicationYear = 2008 },
                new Book { Title = "Programming C# 3.0",
                           Author = "Jesse Liberty",
                           Publisher = "O'Reilly",
                           PublicationYear = 2008 },
                new Book { Title = "C# 3.0 Cookbook",
                           Author = "Jay Hilyard",
                           Publisher = "O'Reilly",
                           PublicationYear = 2007 },
                new Book { Title = "C# 3.0 in a Nutshell",
                           Author = "Ben Albahari",
                           Publisher = "O'Reilly",
                           PublicationYear = 2007 },
                new Book { Title = "Head First C#",
                           Author = "Andrew Stellman",
                           Publisher = "O'Reilly",
                           PublicationYear = 2007 },
                new Book { Title = "Programming C#, fourth edition",
                           Author = "Jesse Liberty",
                           Publisher = "O'Reilly",
                           PublicationYear = 2005 }
            };
            var orderList = new PurchaseOrders {
                new PurchaseOrder { OrderNumber = 23483,
                                    Title = "C# 3.0 Cookbook",
                                    Quantity = 57 },
                new PurchaseOrder { OrderNumber = 34598,
                                    Title = "Learning C# 3.0",
                                    Quantity = 8 },
                new PurchaseOrder { OrderNumber = 5895,
                                    Title = "Head First C#",
                                    Quantity = 943 }
            };

            var resultsOrdered =
                from myBook in bookList
                orderby myBook.Title
                select myBook;
            Console.WriteLine("Ordered book list");
            foreach (var myBook in resultsOrdered) {
                Console.WriteLine(myBook.Title);
            }

            var resultAuthor =
                from myBook in bookList
                where myBook.Author.Contains("Jesse")
                select myBook;
            Console.WriteLine("Books written by Jesse");
            foreach(var myBook in resultAuthor) {
                Console.WriteLine(myBook.Title);
            }

            var resultsOrders =
                from myBook in bookList
                join myOrder in orderList on myBook.Title equals myOrder.Title
                select new { myBook.Title, myBook.Author, myOrder.Quantity };
            Console.WriteLine("Book orders");
            foreach (var order in resultsOrders) {
                Console.WriteLine(String.Format("Title:{0},Author{1},Quantity{2}",order.Title,order.Author,order.Quantity));
            }
        }
    }
}