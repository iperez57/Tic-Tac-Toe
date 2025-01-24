using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class PlayerClass
    {


        public char currentPlayer;
        public  PlayerClass(int turn)
        {
            if (turn == 0)
            {
                currentPlayer = 'X';
            }
            else
            {
                currentPlayer = 'O';
            }
            
        }

        public void MakeMove(Gameboard board, int row, int col)
        {
            if (board.Board[row, col] == ' ')
            {
                board.Board[row, col] = currentPlayer;
                board.CheckWinCondition(currentPlayer);
                board.CheckDrawCondition();
                SwapPlayer();
            }
        }


        public void SwapPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }


    }
}
