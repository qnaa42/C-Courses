using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class Test_Chess
    {
        [TestMethod]
        public void Test_001()
        {
            ////Model
            ////View
            ////Controller
            //var moves = new List<string>();

            //var game = new Chess();
            //var board = new Board();
            //var printer = new BoardPrinter();

            //foreach(var move in moves)
            //{
            //    game.Apply(move, board);

            //    printer.Show(board);
            //}
        }
        [TestMethod]
        public void Test_002()
        {
            //Model
            //View
            //Controller
            var moves = new List<string>();

            var game = new Chess();
            var board = new Board();
            var printer = new BoardPrinter();

            game.Move +=

            foreach (var move in moves)
            {
                game.Apply(move, board);

                printer.Show(board);
            }
        }
    }
}
