using System;
using NUnit.Framework;

namespace Chapter10
{
    [TestFixture]
    class Exercise4
    {
        public class ChessBoard
        {
            private const int rows = 8;
            private const int columns = 8;

            private class Cell
            {
                public String Color { get; set; }
            }

            private readonly Cell[,] board;

            public ChessBoard()
            {
                board = new Cell[rows, columns];

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Cell c = new Cell();
                        c.Color = ( (i+j) % 2 == 0 ) ? "white" : "black";
                        board[i, j] = c;
                    }
                }
            }

            public void printBoard()
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write("{0},", board[i,j].Color);
                    }
                    Console.WriteLine();
                }
            }

            public void printCell(int x, int y)
            {
                if ((x < 1) || (x > 8) || (y < 1) || (y > 8))
                {
                    Console.WriteLine("Coordinations can only be between 1-8");
                }
                else
                {
                    Console.WriteLine("Color of {0},{1} is {2}", x, y, board[x-1,y-1].Color);
                }
            }
        }

        [Test]
        public void overBoard()
        {
            ChessBoard cb = new ChessBoard();
            cb.printBoard();

            // Board starts from 1,1 at upper-left and ends at 8,8 at lower-right
            cb.printCell(3,8);
            cb.printCell(5,5);
            cb.printCell(1,2);
            cb.printCell(1,0);
        }
    }
}