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

        public void MakeMove(char[,] board, int row, int col)
        {
            while (board[row, col] == ' ')
            {
                board[row, col] = currentPlayer;
            }
            SwapPlayer();
        }

        public void SwapPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }


    }
}
