using System;
using NUnit.Framework;

namespace Chapter16 {
    [TestFixture]
    public class Exercise1 {
        private int[] iarray = { 1, 12, 19 };

        public int GetInt(int value) {
            return iarray[value];
        }

        [Test]
        public void TestArray() {
            for (int i = -2; i < 5; i++) {
                try {
                    Console.WriteLine("Index {0} : {1}", i, GetInt(i));
                } catch (Exception e) {
                    Console.WriteLine("Index {0} : {1}", i, e.Message);
                }
            }
        }
    }
}
