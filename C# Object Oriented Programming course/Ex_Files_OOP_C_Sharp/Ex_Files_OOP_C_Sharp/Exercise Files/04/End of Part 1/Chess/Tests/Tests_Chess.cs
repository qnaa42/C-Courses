using ChessMVC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Tests
{
    [TestClass]
    public class Tests_Chess
    {
        [TestMethod]
        public void Test_001()
        {
            // Model
            // View
            // Controller

            //var moves = new List<string>();

            //var game = new Chess();
            //var board = new Board();
            //var printer = new BoardPrinter();

            //foreach (var move in moves)
            //{
            //    game.Apply(move, board);

            //    printer.Show(board);
            //}
        }
        [TestMethod]
        public void Test_002()
        {
            // Model
            // View
            // Controller

            var moves = new List<string>()
            {
              // White, Black
                "G1F3", "G8F6",
                "C2C4", "G7G6",
                "B1C3", "F8G7",
                "D1D4", "E8G8", // castle
                "C1C4", "D7D5",
                "D1B3", "D5C4", // capture
                "B3C4", // capture, ...

            };

            var game = new Chess();
            var board = new Board();
            var printer = new BoardPrinter();

            //board.Move += (move) => Debug.WriteLine("");

            //game.Result += (result) => Debug.WriteLine("");
            //game.Capture += (piece, position) => Debug.WriteLine("");

            foreach (var move in moves)
            {
                game.Apply(move, board);

                printer.Show(board);
            }
        }

        private class BoardPrinter
        {
            internal void Show(Board board)
            {
                for (int c = 1; c <= 8; c++)
                {
                    for (int r = 1; r <= 8; r++)
                    {
                        Debug.Write($"[{board[c, r]?.ToString() ?? " "}]");
                    }
                    Debug.WriteLine(string.Empty);
                }
                Debug.WriteLine(string.Empty.PadRight(8 * 3, '-'));
            }
        }

        [TestMethod]
        public void Test_999_ColumnsRows()
        {
            var board = new Board();

            //                  c, r
            Assert.IsTrue(board[1, 1].ToString() == "R");
            Assert.IsTrue(board[2, 1].ToString() == "N");
            Assert.IsTrue(board[3, 1].ToString() == "B");
            Assert.IsTrue(board[4, 1].ToString() == "Q");
            Assert.IsTrue(board[5, 1].ToString() == "K");
            Assert.IsTrue(board[6, 1].ToString() == "B");
            Assert.IsTrue(board[7, 1].ToString() == "N");
            Assert.IsTrue(board[8, 1].ToString() == "R");

            Assert.IsTrue(board[1, 8].ToString() == "R");
            Assert.IsTrue(board[2, 8].ToString() == "N");
            Assert.IsTrue(board[3, 8].ToString() == "B");
            Assert.IsTrue(board[4, 8].ToString() == "Q");
            Assert.IsTrue(board[5, 8].ToString() == "K");
            Assert.IsTrue(board[6, 8].ToString() == "B");
            Assert.IsTrue(board[7, 8].ToString() == "N");
            Assert.IsTrue(board[8, 8].ToString() == "R");
        }
    }
}
