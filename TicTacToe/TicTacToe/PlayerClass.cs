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
        public  PlayerClass()
        {
            currentPlayer = 'X';
        }

        public void SwapPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }


    }
}
