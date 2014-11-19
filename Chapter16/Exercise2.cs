using System;
using NUnit.Framework;

namespace Chapter16 {
    [TestFixture]
    public class Exercise2 {
        private int[] iarray = { 1, 12, 19 };

        public void GetIndex(object value) {
            try {
                Console.WriteLine("Accessing index {0}", value);
                if (!(value is int)) {
                    throw new FormatException();
                }
                var intval = (int)value;

                if (intval < 0 || intval > 2) {
                    throw new IndexOutOfRangeException();
                }

                Console.WriteLine("Index {0} : {1}", intval, iarray[intval]);
            } catch (FormatException) {
                Console.WriteLine("Index can only be int");
            } catch (IndexOutOfRangeException) {
                Console.WriteLine("Index range is only between 0-2");
            }
        }

        [Test]
        public void TestArray() {
            GetIndex(2);
            GetIndex(-1);
            GetIndex('a');
        }
    }
}