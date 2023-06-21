using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Board board = new Board();
            //board.DisplayBoard();
            try
            {
                StartGame();
            }
            catch
            {
                Console.WriteLine("Something went wrong, please try again!");

            }


        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Let's start!");

            Console.Write("Enter first player name: ");
            string playerOneName = Console.ReadLine();

            Console.Write("Enter second player name: ");
            string playerTwoName = Console.ReadLine();

            Player playerOne = new Player();
            playerOne.Name = playerOneName;
            playerOne.Marker = "X";

            Player playerTwo = new Player();
            playerTwo.Name = playerTwoName;
            playerTwo.Marker = "O";


            Game game = new Game(playerOne, playerTwo);



            Player winner = game.Play(); // it returns winner

            if (winner != null)
            {
                Console.WriteLine($"The winner is {winner.Name}! ");
            }
            else
            {
                Console.WriteLine("It's a draw! There is no winner.");
            }
        }




    }
}
