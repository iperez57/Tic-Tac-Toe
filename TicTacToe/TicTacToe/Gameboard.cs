namespace TicTacToe
{
    // USE MUD BLAZOR
    // creates grid 
    // create player 1 and player 2
    //  keep counter for player 1 and player 2 wins
    //  keep counter for draw
    // method to check for win cases
    //   use a while loop horizontal vertical diagonal
    // method to swap turns between players
    //   if player clicks player swap to p2
    // method to check for draw
    // 
    public class Gameboard
    {
        public int ScoreX = 0;
        public int ScoreO = 0;
        public int Draw = 0;
        public int Turn = 0;

        #region starts the board for the game
        public Gameboard()
        {
            BoardInitializer();
            int playerXScore = ScoreX;
            int playerOScore = ScoreO;
            int stalemate = Draw;
            int turn = Turn;

        }

        public char[,] BoardInitializer()
        {
            char[,] board = new char[3, 3];
            for (var row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
            return board;
        }
        #endregion

        #region keeps track of score of the game
        public int PlayerXWins()
        {
            return ++ScoreX;
        }

        public int PlayerOWins()
        {
            return ++ScoreO;
        }

        public int Stalemate()
        {
            return ++Draw;
        }
        #endregion

        #region checks for win conditions
        public bool WinConditionsForO()
        {
            return true;
        }

        public bool WinConditionsForX()
        {
            return false;
        }

        public bool CheckWinCondition(char player)
        {
            return false;
        } 
        #endregion
    }
}
