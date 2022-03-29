using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Player playerone = new Player();
            Player playertwo = new Player();

            Console.Write("Please enter firs player name ");
            playerone.Name = Console.ReadLine();

            Console.Write("Please enter secons player name ");
            playertwo.Name = Console.ReadLine();

            playerone.Marker = "X";
            playertwo.Marker = "O";

            Game newgame = new Game(playerone, playertwo);
            Player winner = newgame.Play();
            // if no one wins:
            if (winner == null)
            {
                Console.WriteLine("no one wins its a draw");
            }
        }


    }
}
