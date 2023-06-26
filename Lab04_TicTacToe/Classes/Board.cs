using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
        public string[,] GameBoard = new string[,]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };

        public void DisplayBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(GameBoard[row, col]);

                    if (col < 2)
                    {
                        Console.Write(" | ");
                    }
                }

                Console.WriteLine();
                if (row < 2)
                {
                    Console.WriteLine("---------");
                }
            }
        }
    }
}