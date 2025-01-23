using System.Reflection.Metadata.Ecma335;

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
        // Properties for scores and state
        public int ScoreX { get; private set; } = 0;
        public int ScoreO { get; private set; } = 0;
        public int Draw { get; private set; } = 0;
        public int Turn { get; set; } = 0; // Can be set externally if needed
        public char[,] Board { get; private set; } = new char[3, 3];

        public bool WinnerRound { get; private set; } = true;
        public int GameCounter { get; private set; } = 0;
        public bool GameDraw { get; private set; } = false;
        public bool XWinGame { get; private set; } = false;
        public bool OWinGame { get; private set; } = false;
        #region starts the board for the game
        public Gameboard()
        {
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
        public void GameEndConditions()
        {
            switch (GameCounter)
            {
                case 3:
                case 4:

                    if (ScoreX == 3)
                    {
                        PlayerXWinsGame();
                        ResetGame();

                    }
                    else if (ScoreO == 3)
                    {
                        PlayerOWinsGame();
                        ResetGame();
                    }
                    break;
                case 5:
                    if (ScoreX > ScoreO)
                    {
                        PlayerXWinsGame();
                        ResetGame();
                    }
                    else if (ScoreO > ScoreX)
                    {
                        PlayerOWinsGame();
                        ResetGame();
                    }
                    else
                    {
                        GameIsDraw();
                        ResetGame();
                    }

                    break;
            }
        }

        public void ResetRound()
        {
            BoardInitializer();
            if (WinnerRound == true)
            {
                Turn = 0;
            }
            else
            {
                Turn = 1;
            }
            GameCounter++;
        }
        public void ResetGame()
        {
            ScoreX = 0;
            ScoreO = 0;
            GameCounter = 0;
            Draw = 0;
            GameDraw = false;
            XWinGame = false;
            OWinGame = false;

        }


        #region keeps track of increasing score of the game
        public int PlayerXWinsRound()
        {
            ResetRound();
            ScoreX++;
            GameEndConditions();
            WinnerRound = true;
            return ScoreX;
        }

        public int PlayerOWinsRound()
        {
            ResetRound();
            ScoreO++;
            GameEndConditions();
            WinnerRound = false;
            return ScoreO;
        }

        public int Stalemate()
        {
            ResetRound();
            Draw++;
            GameEndConditions();
            WinnerRound = true;
            return Draw;
        }
        #endregion

        #region checks for win conditions
        public bool PlayerOWinsGame()
        {
            return OWinGame = true;
        }

        public bool PlayerXWinsGame()
        {
            return XWinGame = true;
        }

        public bool GameIsDraw()
        {
            return GameDraw = true;
        }

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
                        PlayerXWinsRound();
                    }
                    else
                    {
                        PlayerOWinsRound();
                    }
                    return true;
                }

                // Check vertical
                if (this.Board[0, i] == player && this.Board[1, i] == player && this.Board[2, i] == player)
                {
                    if (player == 'X')
                    {
                        PlayerXWinsRound();
                    }
                    else
                    {
                        PlayerOWinsRound();
                    }
                    return true;
                }
            }

            // Check diagonal
            if (this.Board[0, 0] == player && this.Board[1, 1] == player && this.Board[2, 2] == player)
            {
                if (player == 'X')
                {
                    PlayerXWinsRound();
                }
                else
                {
                    PlayerOWinsRound();
                }

                return true;
            }

            if (this.Board[0, 2] == player && this.Board[1, 1] == player && this.Board[2, 0] == player)
            {
                //currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                if (player == 'X')
                {
                    PlayerXWinsRound();
                }
                else
                {
                    PlayerOWinsRound();
                }
                return true;
            }
            return false;
        }

        public bool CheckDrawCondition()
        {
            for (var row = 0; row < Board.GetLength(0); row++)
            {
                for (int col = 0; col < Board.GetLength(1); col++)
                {
                    if (this.Board[row, col] == ' ')
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
