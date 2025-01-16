using TicTacToe;

namespace TicTacToeTest
{
    // USING MUD BLAZOR
    // empty grid is created *
    // player1 can win
    // player1 can lose
    // p2 can win 
    // p2 can lose
    // bot? can win 
    // bot? can lose
    // after player puts x/o swaps to other player to place x/o
    // check vertical wins
    // check horizontal wins
    // check diagonal wins
    // increase p1 score by 1
    // increase p2 score by 1
    // increase draw by 1
    // 5 games total best of 5
    // Ensure that players cannot overwrite a cell that has already been filled. 
    // Ensure the game correctly detects a draw when the grid is full, and no player has won
    // make sure grid resets after a win 
    // make sure game ends after 5 games
    // create a discord bot to play tic tac toe with ?
    // verify bot chooses a valid move
    // test that bot can win if given opportunity
    // check to see if bot blocks palyer from winning when possible
    // make sure bot doesn't overwrite existing move

    [TestClass]
    public class GameboardTest
    {
        [TestMethod]
        public void GameboardInitialized3by3Grid()
        {
            //arrnage
            var game = new Gameboard();
            //act
            var board = game.BoardInitializer();
            //assert
            Assert.AreEqual(3, board.GetLength(0));
            Assert.AreEqual(3, board.GetLength(1));

        }

        [TestMethod]
        public void GameboardInitializedGridPopulatedWithSpace()
        {
            //arrnage
            var game = new Gameboard();
            //act
            var board = game.BoardInitializer();
            //assert
            Assert.AreEqual(3, board.GetLength(0));
            Assert.AreEqual(3, board.GetLength(1));

            for (var row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Assert.AreEqual(' ', board[row, col]);
                }
            }
        }

    }
}
