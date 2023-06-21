using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Numerics;

using Lab04_TicTacToe.Classes;/////

namespace TicTacToeTests;

public class UnitTest1
{






    //Given a game board, test for winners

    [Fact]
    public void Play_TestForWinners()
    {
        // Arrange
        Player playerOne = new Player();
        playerOne.Name = "Player1";
        playerOne.Marker = "X";

        Player playerTwo = new Player();
        playerTwo.Name = "Player2";
        playerTwo.Marker = "O";
        Game game = new Game(playerOne, playerTwo);

        //Board board = new Board();
        game.Board.GameBoard[0, 0] = "X";
        game.Board.GameBoard[0, 1] = "X";
        game.Board.GameBoard[0, 2] = "X";

        // Act
        bool hasWinner = game.CheckForWinner(game.Board);

        // Assert
        Assert.Equal(hasWinner, true);
    }














    //    Test that there is a switch in players between turns

    [Fact]
    public void Play_SwitchesBetweenPlayers()
    {
        // Arrange
        Player playerOne = new Player();
        playerOne.Name = "Player1";
        playerOne.Marker = "X";

        Player playerTwo = new Player();
        playerTwo.Name = "Player2";
        playerTwo.Marker = "O";
        Game game = new Game(playerOne, playerTwo);
        playerOne.IsTurn = true;

        // Act
        game.SwitchPlayer();
        game.NextPlayer();
        // Assert
        Assert.Equal(playerOne.IsTurn, false);
    }



    //



    //Test to confirm that the position the player inputs correlates to the correct index of the array

    [Fact]
    public void TakeTurn_PositionUpdatedOnBoard()
    {
        // Arrange
        Player playerOne = new Player();
        playerOne.Name = "Player1";
        playerOne.Marker = "X";

        Player playerTwo = new Player();
        playerTwo.Name = "Player2";
        playerTwo.Marker = "O";

        Game game = new Game(playerOne, playerTwo);
        Position position = new Position(0, 0);

        game.Board.GameBoard[position.Row, position.Column] = playerOne.Marker;

        // Assert
        Assert.Equal(playerOne.Marker, game.Board.GameBoard[position.Row, position.Column]);


    }





    //One other “unique” test of your own

    [Fact]
    public void Play_GameDraw()
    {
        // Arrange
        Player playerOne = new Player();
        playerOne.Name = "Player1";
        playerOne.Marker = "X";

        Player playerTwo = new Player();
        playerTwo.Name = "Player2";
        playerTwo.Marker = "O";
        Game game = new Game(playerOne, playerTwo);

        game.Board.GameBoard = new string[,]
       {
                { "X", "O", "X" },
                { "X", "O", "O" },
                { "O", "X", "X" }
       };

        // Act

         bool winner = game.CheckForWinner(game.Board);

        // Assert
        Assert.Equal(winner, false);
    }




}
