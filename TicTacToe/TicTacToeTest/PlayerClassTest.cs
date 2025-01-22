using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeTest
{
    [TestClass]
    public class PlayerClassTest
    {
        [TestMethod]
        public void GameStartsWithPlayerX()
        {
            // Arrange
            var player = new PlayerClass(0); // PlayerClass initializes currentPlayer as 'X'

            // Act
            var startingPlayer = player.currentPlayer;

            // Assert
            Assert.AreEqual('X', startingPlayer, "The game should start with Player X.");
        }

        [TestMethod]
        public void PlayerSwapsXtoO()
        {
            //new init gameboard
            var game = new Gameboard();
            var player = new PlayerClass(0);

            //player places something
            Assert.AreEqual('X', player.currentPlayer);
            player.MakeMove(game.Board, 0, 0);
            Assert.AreEqual('O', player.currentPlayer);
            player.MakeMove(game.Board, 0, 1);
            Assert.AreEqual('X', player.currentPlayer);

            //gameboard contains said something
            Assert.AreEqual('X', game.Board[0, 0]);
            Assert.AreEqual('O', game.Board[0, 1]);
        }

        [TestMethod]
        public void PlayerMakesMoveOnEmptySpace()
        {
            var player = new PlayerClass(0);
            //new init gameboard
            var game = new Gameboard();

            //player places something
            player.MakeMove(game.Board, 0, 0);


            //gameboard contains said something
            Assert.AreEqual('X', game.Board[0, 0]);

        }

        [TestMethod]
        public void PlayerMakesMoveOnOccupiedSpace()
        {
            var player = new PlayerClass(0);
            //new init gameboard
            var game = new Gameboard();

            //player places something
            player.MakeMove(game.Board, 0, 0);
            player.MakeMove(game.Board, 0, 0);

            //gameboard contains said something
            Assert.AreEqual('X', game.Board[0, 0]);
        }


    }
}