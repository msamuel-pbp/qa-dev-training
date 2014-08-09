using System;
using NUnit.Framework;

namespace Chapter12
{
    class Exercise2
    {
        public class Invoice
        {
            public string Vendor { get; set; }
            public double Amount { get; set; }

            public Invoice(string v = "", double a = 0.0)
            {
                Vendor = v;
                Amount = a;
            }

            public static Invoice operator+ (Invoice lhs, Invoice rhs)
            {
                if (lhs == rhs)
                {
                    return new Invoice(lhs.Vendor, lhs.Amount + rhs.Amount);
                }

                return new Invoice();
            }

            public override bool Equals(object obj)
            {
                if (! (obj is Invoice))
                {
                    return false;
                }

                return this == (Invoice) obj;
            }

            public static bool operator== (Invoice lhs, Invoice rhs)
            {
                if (lhs.Vendor.Equals(rhs.Vendor) && (lhs.Amount == rhs.Amount))
                {
                    return true;
                }

                return false;
            }

            public static bool operator !=(Invoice lhs, Invoice rhs)
            {
                return !(lhs == rhs);
            }

            public override string ToString()
            {
                return ("Vendor: " + Vendor + "\r\nAmount: " + Amount);
            }
        }

        [Test]
        public void blankInvoice()
        {
            var i = new Invoice();
            Console.WriteLine(i.ToString());
            Assert.IsNullOrEmpty(i.Vendor);
            Assert.True(i.Amount == 0.0);
        }

        [Test]
        public void setInvoice()
        {
            var i = new Invoice("UBC", 5d);
            Console.WriteLine(i);
            Assert.That(i.Vendor.Equals("UBC"));
            Assert.True(i.Amount == 5d);
        }

        [Test]
        public void checkEqual()
        {
            var invoice1 = new Invoice("UBC", 5d);
            var invoice2 = new Invoice("UBC", 5d);
            Console.WriteLine("Invoice1:\n" + invoice1);
            Console.WriteLine("Invoice2:\n" + invoice2);

            Assert.True(invoice1 == invoice2);
        }

        [Test]
        public void checkNotEqual()
        {
            var invoice1 = new Invoice("UBC", 5d);
            var invoice2 = new Invoice("SFMTA", 3d);
            Console.WriteLine("Invoice1:\n" + invoice1);
            Console.WriteLine("Invoice2:\n" + invoice2);

            Assert.True(invoice1 != invoice2);
        }

        [Test]
        public void checkNotEqualVendor()
        {
            var invoice1 = new Invoice("UBC", 5d);
            var invoice2 = new Invoice("SFMTA", 5d);
            Console.WriteLine("Invoice1:\n" + invoice1);
            Console.WriteLine("Invoice2:\n" + invoice2);

            Assert.True(invoice1 != invoice2);
        }

        [Test]
        public void checkNotEqualAmount()
        {
            var invoice1 = new Invoice("UBC", 5d);
            var invoice2 = new Invoice("UBC", 3d);
            Console.WriteLine("Invoice1:\n" + invoice1);
            Console.WriteLine("Invoice2:\n" + invoice2);

            Assert.True(invoice1 != invoice2);
        }

        [Test]
        public void addSameInvoice()
        {
            var invoice1 = new Invoice("UBC", 5d);
            var invoice2 = new Invoice("UBC", 5d);
            Console.WriteLine("Invoice1:\n" + invoice1);
            Console.WriteLine("Invoice2:\n" + invoice2);

            var i = invoice1 + invoice2;
            Console.WriteLine("Invoice:\n" + i);
            Assert.That(i.Vendor.Equals("UBC"));
            Assert.True(i.Amount == 10d);
        }

        [Test]
        public void addSameVendorOnly()
        {
            var invoice1 = new Invoice("UBC", 5d);
            var invoice2 = new Invoice("UBC", 10d);
            Console.WriteLine("Invoice1:\n" + invoice1);
            Console.WriteLine("Invoice2:\n" + invoice2);

            var i = invoice1 + invoice2;
            Console.WriteLine("Invoice:\n" + i);
            Assert.IsNullOrEmpty(i.Vendor);
            Assert.True(i.Amount == 0.0);
        }

        [Test]
        public void addSameAmountOnly()
        {
            var invoice1 = new Invoice("UBC", 5d);
            var invoice2 = new Invoice("SFMTA", 5d);
            Console.WriteLine("Invoice1:\n" + invoice1);
            Console.WriteLine("Invoice2:\n" + invoice2);

            var i = invoice1 + invoice2;
            Console.WriteLine("Invoice:\n" + i);
            Assert.IsNullOrEmpty(i.Vendor);
            Assert.True(i.Amount == 0.0);
        }

        [Test]
        public void addDiffInvoice()
        {
            var invoice1 = new Invoice("UBC", 5d);
            var invoice2 = new Invoice("SFMTA", 3d);
            Console.WriteLine("Invoice1:\n" + invoice1);
            Console.WriteLine("Invoice2:\n" + invoice2);

            var i = invoice1 + invoice2;
            Console.WriteLine("Invoice:\n" + i);
            Assert.IsNullOrEmpty(i.Vendor);
            Assert.True(i.Amount == 0.0);
        }
    }
}