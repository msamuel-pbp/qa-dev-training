using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20 {
    public class Exercise1 {
        public class Box {
            public int Length { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public void DisplayBox() {
                Console.WriteLine("{0}x{1}x{2}", Length, Width, Height);
            }
        }
        public class Boxes : List<Box> { }

        public static void Main(string[] args) {
            var storage = new Boxes();
            var rand = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < 5; i++) {
                var ups = new Box();
                ups.Length = rand.Next(1, 5);
                ups.Width = rand.Next(1, 5);
                ups.Height = rand.Next(1, 5);
                storage.Add(ups);
            }

            var query =
                from b in storage
                where b.Length > 3 && b.Width > 3
                select b;

            Console.WriteLine("Total boxes");
            foreach (var b in storage) {
                b.DisplayBox();
            }
            Console.WriteLine("Found boxes");
            foreach (var b in query) {
                b.DisplayBox();
            }
        }
    }
}