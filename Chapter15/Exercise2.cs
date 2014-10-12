using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Chapter15
{
    [TestFixture]
    public class Exercise2
    {
        private StringBuilder builder;
        private string s = @"To be, or not to be: That is the question: Whether ‘tis nobler in the mind to suffer the slings and arrows of outrageous fortune, or to take arms against a sea of troubles, and by opposing end them?";

        [Test]
        public void charreverse()
        {
            builder = new StringBuilder();
            char[] parms = {' ', ':', ','};

            string[] words = s.Split(parms);
            Array.Reverse(words);

            foreach (string word in words)
            {
                builder.AppendFormat("{0} ", word);
            }

            Console.WriteLine(s);
            Console.WriteLine(builder);
        }

        [Test]
        public void regexreverse()
        {
            builder = new StringBuilder();
            string regex = ", |: | ";;

            string[] words = Regex.Split(s, regex);
            Array.Reverse(words);

            foreach (string word in words)
            {
                builder.AppendFormat("{0} ", word);
            }

            Console.WriteLine(s);
            Console.WriteLine(builder);
        }
    }
}