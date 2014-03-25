using System;
using NUnit.Framework;

namespace Chapter7
{
    [TestFixture]
    public class Exercise4
    {
        public class Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void PrintCoord()
            {
                Console.WriteLine("x is {0} and y is {1}", x, y);
            }
        }

        public class Square
        {
            // A  B
            // C  D
            private Point A, B, C, D;

            public Square(Point A, int length)
            {
                this.A = A;
                B = new Point(A.x + length, A.y);
                C = new Point(A.x, A.y - length);
                D = new Point(B.x, C.y);
            }

            public void Print()
            {
                A.PrintCoord();
                B.PrintCoord();
                C.PrintCoord();
                D.PrintCoord();
            }
        }

        [Test]
        public void squareTest()
        {
            int x = 5;
            int y = 5;
            int length = 3;

            Point start = new Point(x,y);
            Square square = new Square(start, length);

            Console.WriteLine("Start at {0},{1} with a length of {2}",x,y,length);
            square.Print();
        }
    }
}