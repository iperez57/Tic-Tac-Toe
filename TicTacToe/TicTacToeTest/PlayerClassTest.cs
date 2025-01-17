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
            var player = new PlayerClass(); // PlayerClass initializes currentPlayer as 'X'

            // Act
            var startingPlayer = player.currentPlayer;

            // Assert
            Assert.AreEqual('X', startingPlayer, "The game should start with Player X.");
        }
    }
}