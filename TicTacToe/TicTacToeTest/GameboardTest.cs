using TicTacToe;

namespace TicTacToeTest
{
    // USING MUD BLAZOR
    // ** empty grid is created 
    // ** playerX can win
    // ** playerX can lose
    // ** playerO can win 
    // ** playerO can lose
    // bot? can win 
    // bot? can lose
    // ** after player puts x/o swaps to other player to place x/o 
    // ** check vertical wins
    // ** check horizontal wins
    // ** check diagonal wins
    // ** increase p1 score by 1 
    // ** increase p2 score by 1 
    // ** increase draw by 1 
    // ** Ensure that players cannot overwrite a cell that has already been filled. 
    // ** Ensure the game correctly detects a draw when the grid is full, and no player has won
    // ** make sure grid resets after a win 
    // ** make sure game ends after 5 games / ensure bo5
    // create a discord bot to play tic tac toe with ?
    // verify bot chooses a valid move
    // test that bot can win if given opportunity
    // check to see if bot blocks palyer from winning when possible
    // make sure bot doesn't overwrite existing move

    [TestClass]
    public class GameboardTest
    {
        #region Tests for gameboard initialization
        [TestMethod]
        public void GameboardInitialized3by3Grid()
        {
            var game = new Gameboard();

            Assert.AreEqual(3, game.Board.GetLength(0));
            Assert.AreEqual(3, game.Board.GetLength(1));

        }

        [TestMethod]
        public void GameboardInitializedGridPopulatedWithSpace()
        {
            var game = new Gameboard();

            for (var row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Assert.AreEqual(' ', game.Board[row, col]);
                }
            }
        }
        #endregion

        #region Rows
        [TestMethod]
        public void GameboardIdentifiesRowWinForO()
        {
            //arrange
            var game = new Gameboard();
            //act
            game.Board[0, 0] = 'O'; game.Board[0, 1] = 'O'; game.Board[0, 2] = 'O';
            //assert
            Assert.IsTrue(game.CheckWinCondition('O'));
            Assert.AreEqual(1, game.ScoreO);

            //arrange
            var game2 = new Gameboard();
            //act
            game2.Board[1, 0] = 'O'; game2.Board[1, 1] = 'O'; game2.Board[1, 2] = 'O';
            //assert
            Assert.IsTrue(game2.CheckWinCondition('O'));
            Assert.AreEqual(1, game2.ScoreO);

            //arrange
            var game3 = new Gameboard();
            //act
            game3.Board[2, 0] = 'O'; game3.Board[2, 1] = 'O'; game3.Board[2, 2] = 'O';
            //assert
            Assert.IsTrue(game3.CheckWinCondition('O'));
            Assert.AreEqual(1, game3.ScoreO);

        }
        [TestMethod]
        public void GameboardIdentifiesRowWinForX()
        {
            //arrange
            var game = new Gameboard();
            //act
            game.Board[0, 0] = 'X'; game.Board[0, 1] = 'X'; game.Board[0, 2] = 'X';
            //assert
            Assert.IsTrue(game.CheckWinCondition('X'));
            Assert.AreEqual(1, game.ScoreX);

            //arrange
            var game2 = new Gameboard();
            //act
            game2.Board[1, 0] = 'X'; game2.Board[1, 1] = 'X'; game2.Board[1, 2] = 'X';
            //assert
            Assert.IsTrue(game2.CheckWinCondition('X'));
            Assert.AreEqual(1, game2.ScoreX);

            //arrange
            var game3 = new Gameboard();
            //act
            game3.Board[2, 0] = 'X'; game3.Board[2, 1] = 'X'; game3.Board[2, 2] = 'X';
            //assert
            Assert.IsTrue(game3.CheckWinCondition('X'));
            Assert.AreEqual(1, game3.ScoreX);

        }
        #endregion
        #region Columns
        [TestMethod]
        public void GameboardIdentifiesColumnWinForX()
        {
            //arrange
            var game = new Gameboard();
            //act
            game.Board[0, 0] = 'X'; game.Board[1, 0] = 'X'; game.Board[2, 0] = 'X';
            //assert
            Assert.IsTrue(game.CheckWinCondition('X'));
            Assert.AreEqual(1, game.ScoreX);

            //arrange
            var game2 = new Gameboard();
            //act
            game2.Board[0, 1] = 'X'; game2.Board[1, 1] = 'X'; game2.Board[2, 1] = 'X';
            //assert
            Assert.IsTrue(game2.CheckWinCondition('X'));
            Assert.AreEqual(1, game2.ScoreX);

            //arrange
            var game3 = new Gameboard();
            //act
            game3.Board[0, 2] = 'X'; game3.Board[1, 2] = 'X'; game3.Board[2, 2] = 'X';
            //assert
            Assert.IsTrue(game3.CheckWinCondition('X'));
            Assert.AreEqual(1, game3.ScoreX);


        }
        [TestMethod]
        public void GameboardIdentifiesColumnWinsForO()
        {
            //arrange
            var game = new Gameboard();
            //act
            game.Board[0, 0] = 'O'; game.Board[1, 0] = 'O'; game.Board[2, 0] = 'O';
            //assert
            Assert.IsTrue(game.CheckWinCondition('O'));
            Assert.AreEqual(1, game.ScoreO);

            //arrange
            var game2 = new Gameboard();
            //act
            game2.Board[0, 1] = 'O'; game2.Board[1, 1] = 'O'; game2.Board[2, 1] = 'O';
            //assert
            Assert.IsTrue(game2.CheckWinCondition('O'));
            Assert.AreEqual(1, game2.ScoreO);

            //arrange
            var game3 = new Gameboard();
            //act
            game3.Board[0, 2] = 'O'; game3.Board[1, 2] = 'O'; game3.Board[2, 2] = 'O';
            //assert
            Assert.IsTrue(game3.CheckWinCondition('O'));
            Assert.AreEqual(1, game3.ScoreO);


        }
        #endregion
        #region Diagonals
        [TestMethod]
        public void GameboardIdentifiesDiagonalOWin()
        {
            //arrange
            var game = new Gameboard();
            //act
            game.Board[0, 0] = 'O'; game.Board[1, 1] = 'O'; game.Board[2, 2] = 'O';

            Assert.IsTrue(game.CheckWinCondition('O'));
            Assert.AreEqual(1, game.ScoreO);

            var game2 = new Gameboard();
            game2.Board[0, 2] = 'O'; game2.Board[1, 1] = 'O'; game2.Board[2, 0] = 'O';
            //assert
            Assert.IsTrue(game2.CheckWinCondition('O'));
            Assert.AreEqual(1, game2.ScoreO);
        }
        [TestMethod]
        public void GameboardIdentifiesDiagonalXWin()
        {
            //arrange
            var game = new Gameboard();
            //act
            game.Board[0, 0] = 'X'; game.Board[1, 1] = 'X'; game.Board[2, 2] = 'X';

            Assert.IsTrue(game.CheckWinCondition('X'));
            Assert.AreEqual(1, game.ScoreX);

            var game2 = new Gameboard();
            game2.Board[0, 2] = 'X'; game2.Board[1, 1] = 'X'; game2.Board[2, 0] = 'X';
            //assert
            Assert.IsTrue(game2.CheckWinCondition('X'));
            Assert.AreEqual(1, game2.ScoreX);

        }
        #endregion
        [TestMethod]
        public void GameboardIdentifiesDraws()
        {
            //arrnage
            var game = new Gameboard();
            //act
            game.Board[0,0] = 'X'; game.Board[0, 1] = 'O'; game.Board[0, 2] = 'X';
            game.Board[1,0] = 'O'; game.Board[1, 1] = 'O'; game.Board[1, 2] = 'X';
            game.Board[2, 0] = 'X'; game.Board[2, 1] = 'X'; game.Board[2, 2] = 'O';
            //assert
            Assert.IsTrue(game.CheckDrawCondition());
            Assert.AreEqual(1, game.Draw);

        }
        [TestMethod]
        public void GameboardIdentifiesNotWins()
        {
            //arrange
            var game = new Gameboard();
            //act
            game.Board[0, 0] = 'X'; game.Board[1, 0] = 'O'; game.Board[2, 0] = 'O';
            //assert
            Assert.IsFalse(game.CheckWinCondition('O'));
            Assert.AreEqual(0, game.ScoreO);

            //arrange
            var game2 = new Gameboard();
            //act
            game2.Board[0, 1] = 'O'; game2.Board[1, 1] = 'X'; game2.Board[2, 1] = 'O';
            //assert
            Assert.IsFalse(game.CheckWinCondition('O'));
            Assert.AreEqual(0, game.ScoreO);

            //arrange
            var game3 = new Gameboard();
            //act
            game3.Board[0, 2] = 'O'; game3.Board[1, 2] = 'O'; game3.Board[2, 2] = 'X';
            //assert
            Assert.IsFalse(game.CheckWinCondition('O'));
            Assert.AreEqual(0, game.ScoreO);

            //arrange
            var game4 = new Gameboard();
            //act
            game4.Board[0, 0] = 'O'; game4.Board[0, 1] = 'X'; game4.Board[0, 2] = 'X';
            //assert
            Assert.IsFalse(game4.CheckWinCondition('X'));
            Assert.AreEqual(0, game4.ScoreX);

            //arrange
            var game5 = new Gameboard();
            //act
            game5.Board[1, 0] = 'X'; game5.Board[1, 1] = 'O'; game5.Board[1, 2] = 'X';
            //assert
            Assert.IsFalse(game5.CheckWinCondition('X'));
            Assert.AreEqual(0, game5.ScoreX);

            //arrange
            var game6 = new Gameboard();
            //act
            game6.Board[2, 0] = 'X'; game6.Board[2, 1] = 'X'; game6.Board[2, 2] = 'O';
            //assert
            Assert.IsFalse(game6.CheckWinCondition('X'));
            Assert.AreEqual(0, game6.ScoreX);
            //arrange
            var game7 = new Gameboard();
            //act
            game7.Board[0, 0] = 'X'; game7.Board[1, 1] = 'O'; game7.Board[2, 2] = 'O';

            Assert.IsFalse(game7.CheckWinCondition('O'));
            Assert.AreEqual(0, game7.ScoreO);

            var game8 = new Gameboard();
            game8.Board[0, 2] = 'O'; game8.Board[1, 1] = 'O'; game8.Board[2, 0] = 'X';
            //assert
            Assert.IsFalse(game8.CheckWinCondition('O'));
            Assert.AreEqual(0, game8.ScoreO);

        }

        #region tests for scores

        [TestMethod]
        public void MakeSurePlayersScoreStartAt0()
        {
            //arrnage
            var game = new Gameboard();

            //Assert
            Assert.AreEqual(0, game.ScoreX);
            Assert.AreEqual(0, game.ScoreO);
            Assert.AreEqual(0, game.Draw);
            Assert.AreEqual(0, game.Turn);
        }

        [TestMethod]
        public void MakeSurePlayersScoreIncreaseBy1WhenEitherDrawWin()
        {
            //arrnage
            var game = new Gameboard();
            //act
            game.PlayerOWins();
            game.PlayerXWins();
            game.Stalemate();

            //Assert
            Assert.AreEqual(1, game.ScoreX);
            Assert.AreEqual(1, game.ScoreO);
            Assert.AreEqual(1, game.Draw);
            Assert.AreEqual(0, game.Turn);
        }
        #endregion

        [TestMethod]
        public void MakeSureBoardResetsAfterWin()
        {
            //arrange
            var game = new Gameboard();
            //act
            game.Board[0, 0] = 'X'; game.Board[0, 1] = 'X'; game.Board[0, 2] = 'X';
            game.PlayerXWins();
            //assert
            for (var row = 0; row < 3; row++)
            {
                for (var col = 0; col < 3; col++)
                {
                    Assert.AreEqual(' ', game.Board[row, col]);
                }
            }
        }

        [TestMethod]
        public void GameEndsAfterPlayerReaches3Wins()
        {

        }












    }

}
