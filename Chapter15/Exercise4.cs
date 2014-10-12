using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Chapter15
{
    [TestFixture]
    public class Exercise4
    {
        private string s = @"We hold these truths to be self-evident, that all men are created equal, that they are endowed by their Creator with certain unalienable Rights, that among these are Life, Liberty and the pursuit of Happiness.";

        [Test]
        public void wordsplit()
        {
            var regex = ", | ";
            var words = Regex.Split(s, regex);
            var builder = new StringBuilder();
            var count = 1;

            foreach (string word in words)
            {
                builder.AppendFormat("{0}: {1}\n", count++, word);
            }

            Console.WriteLine(builder);
        }
    }
}
