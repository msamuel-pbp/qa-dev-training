using System;
using System.Net.Mail;
using NUnit.Framework;

namespace Chapter15
{
    [TestFixture]
    public class Exercise3
    {
        private int count;
        private string s = @"We choose to go to the moon. We choose to go to the moon in this decade and do the other things, not because they are easy, but because they are hard, because that goal will serve to organize and measure the best of our energies and skills, because that challenge is one that we are willing to accept, one we are unwilling to postpone, and one which we intend to win, and the others, too.";
        private string pattern = "the ";

        public void Locate(string input, int startIndex, string pattern)
        {
            var index = input.IndexOf(pattern, startIndex);

            if (index >= 0)
            {
                count++;
                Locate(input, index + pattern.Length, pattern);
            }
        }

        [Test]
        public void recursivecountword()
        {
            count = 0;
            Locate(s, 0, pattern);
            Console.WriteLine("Number of times \"{0}\" shows: {1}", pattern, count);
        }

        [Test]
        public void substringword()
        {
            count = 0;
            var tempstring = String.Copy(s);

            while (tempstring.IndexOf(pattern) >= 0)
            {
                tempstring = tempstring.Substring(tempstring.IndexOf(pattern) + pattern.Length);
                count++;
            }

            Console.WriteLine("Number of times \"{0}\" shows: {1}", pattern, count);
        }
    }
}