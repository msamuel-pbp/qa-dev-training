using System;
using NUnit.Framework;

namespace Chapter13
{
    class Exercise4
    {
        public interface IConvertible
        {
            string ConvertToCSharp(string s);
            string ConvertToVB(string s);
        }

        public class ProgramConverter : IConvertible
        {
            public string ConvertToCSharp(string s)
            {
                return "Converted to CSharp!";
            }

            public string ConvertToVB(string s)
            {
                return "Converted to VB!";
            }
        }

        public interface ICodeChecker : IConvertible
        {
            bool CodeCheckSyntax(string s, string language);
        }

        public class ProgramHelper : ProgramConverter, ICodeChecker
        {
            public bool CodeCheckSyntax(string s, string language)
            {
                return (language.Equals("CSharp") || language.Equals("VB"));
            }
        }

        [Test]
        public void ProgramCorrect()
        {
            var p = new ProgramHelper();

            Assert.True(p.CodeCheckSyntax("test","CSharp"));
            Assert.True(p.CodeCheckSyntax("test", "VB"));
        }

        [Test]
        public void ProgramIncorrect()
        {
            var p = new ProgramHelper();

            Assert.False(p.CodeCheckSyntax("test", "foobar"));
            Assert.False(p.CodeCheckSyntax("test", ""));
        }

        [Test]
        public void ValidateInterfaces()
        {
            var aInterfaces = new IConvertible[5];

            for(int i = 0; i < 5; i++)
            {
                aInterfaces[i] = (i % 2 == 0)
                    ? new ProgramConverter()
                    : new ProgramHelper();
            }

            Console.WriteLine("Using IS validation");
            foreach (IConvertible conv in aInterfaces)
            {
                Console.WriteLine("Testing array item");
                Console.WriteLine(conv.ConvertToCSharp("test"));
                Console.WriteLine(conv.ConvertToVB("test"));
                if (conv is ICodeChecker)
                {
                    Console.WriteLine("This item IS a ICodeChecker");
                    var check = conv as ICodeChecker;
                    check.CodeCheckSyntax("test", "CSharp");
                }
                else
                {
                    Console.WriteLine("This item IS NOT a ICodeChecker");                    
                }

                if (conv is ProgramHelper)
                {
                    Console.WriteLine("This item IS a ProgramHelper");
                    var check = conv as ProgramHelper;
                    check.CodeCheckSyntax("test", "CSharp");
                }
                else
                {
                    Console.WriteLine("This item IS NOT a ProgramHelper");
                }
            }

            Console.WriteLine("Using AS validation");
            foreach (IConvertible conv in aInterfaces)
            {
                Console.WriteLine("Testing array item");
                Console.WriteLine(conv.ConvertToCSharp("test"));
                Console.WriteLine(conv.ConvertToVB("test"));

                var check = conv as ICodeChecker;
                if (check != null)
                {
                    Console.WriteLine("This item AS a ICodeChecker");
                    check.CodeCheckSyntax("test", "CSharp");
                }
                else
                {
                    Console.WriteLine("This item AS NOT a ICodeChecker");
                }

                var helper = conv as ProgramHelper;
                if (helper != null) {
                    Console.WriteLine("This item AS a ProgramHelper");
                    helper.CodeCheckSyntax("test", "CSharp");
                }
                else
                {
                    Console.WriteLine("This item AS NOT a ProgramHelper");
                }
            }
        }
    }
}