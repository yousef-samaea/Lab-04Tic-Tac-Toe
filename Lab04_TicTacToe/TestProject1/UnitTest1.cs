using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace TestProject1
{
    public class UnitTest1
    {
        public static Player playerOne = new Player
        {
            Name = "yousef",
            Marker = "x",
            IsTurn = true
        };
        public static Player playerTwo = new Player
        {
            Name = "mohammed",
            Marker = "o",
            IsTurn = false
        };

        //test the winner

        [Fact]
        public void TestTheWinner()
        {
            Game game = new Game(playerOne, playerTwo);

            game.Board.GameBoard = new string[,]
            {
                {"1", "2", "O"},
                {"4", "O", "6"},
                {"X", "X", "X"},
            };

            Assert.True(game.CheckForWinner(game.Board));
        }

        //test player turn "Switch "

        [Fact]
        public void Switch()
        {
            Game testGame = new Game(playerOne, playerTwo);
            testGame.PlayerTwo.IsTurn = false;
            testGame.SwitchPlayer();

            Assert.Equal(testGame.PlayerTwo, testGame.NextPlayer());
        }

        //Test the TestForPosition

        [Fact]
        public void TestForPosition()
        {
            Position Position = new Position(2, 2);
            Assert.Equal(Position.Row, Player.PositionForNumber(9).Row);
        }

         // my test:

        [Fact]
        public void Test()
        {
            string[,] Winner = new string[,]
        {
                {"x", "o", "x"},
                {"o", "x", "o"},
                {"o", "x", "o"},
        };
            Game game = new Game(playerOne, playerTwo);
            Assert.False(game.CheckForWinner(game.Board));
        }





    }
}
