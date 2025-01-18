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
        public char[,] Board = new char[3, 3];

        #region starts the board for the game
        public Gameboard()
        {
            int playerXScore = ScoreX;
            int playerOScore = ScoreO;
            int stalemate = Draw;
            int turn = Turn;
            BoardInitializer();
        }

        public void BoardInitializer()
        {
            for (var row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    this.Board[row, col] = ' ';
                }
            }
        }
        #endregion

        #region keeps track of increasing score of the game
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
        //public bool WinConditionsForO()
        //{
        //    return CheckWinCondition('O');
        //}

        //public bool WinConditionsForX()
        //{
        //    return CheckWinCondition('X');
        //}

        //attempt a while loo[ later to ass draw into win conditions
        public bool CheckWinCondition(char player)
        {
            // Check horizontal, vertical, and diagonal win conditions
            for (int i = 0; i < 3; i++)
            {
                // Check horizontal
                if (this.Board[i, 0] == player && this.Board[i, 1] == player && this.Board[i, 2] == player)
                {
                    if (player == 'X')
                    {
                        PlayerXWins();
                    }
                    else
                    {
                        PlayerOWins();
                    }
                    return true;
                }

                // Check vertical
                if (this.Board[0, i] == player && this.Board[1, i] == player && this.Board[2, i] == player)
                {
                    if (player == 'X')
                    {
                        PlayerXWins();
                    }
                    else
                    {
                        PlayerOWins();
                    }
                    return true;
                }
            }

            // Check diagonal
            if (this.Board[0, 0] == player && this.Board[1, 1] == player && this.Board[2, 2] == player)
            {
                if (player == 'X')
                {
                    PlayerXWins();
                }
                else
                {
                    PlayerOWins();
                }

                return true;
            }

            if (this.Board[0, 2] == player && this.Board[1, 1] == player && this.Board[2, 0] == player)
            {
                //currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                if (player == 'X')
                {
                    PlayerXWins();
                }
                else
                {
                    PlayerOWins();
                }
                return true;
            }

            return false;
        }

        public bool CheckDrawCondition()
        {
            for (var row = 0; row < Board.GetLength(0)-1; row++)
            {
                for (int col = 0; col < Board.GetLength(1) - 1; col++)
                {
                    if (this.Board[row,col] == ' ')
                    {
                        return false;
                    }
                }
            }
            Stalemate();
            return true;
        }
        #endregion
    }
}
