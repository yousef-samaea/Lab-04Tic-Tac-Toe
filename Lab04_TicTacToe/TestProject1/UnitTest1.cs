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

        [Fact]
        public void TestWinnerBoard()
        {
            Game testGame = new Game(new Player(), new Player());
            for (int i = 0; i < 3; i++)
                testGame.Board.GameBoard[0, i] = "X";
            Assert.True(testGame.CheckForWinner(testGame.Board));

            for (int i = 0; i < 3; i++)
                testGame.Board.GameBoard[i, i] = "O";
            Assert.True(testGame.CheckForWinner(testGame.Board));
        }
    }
}
