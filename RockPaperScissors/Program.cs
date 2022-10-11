using System;

namespace RockPaperScissors
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, and Scissors!");
            Console.WriteLine("Please choose an option: Rock, Paper, or Scissors.");

            string playerChoice = Console.ReadLine();
            int check = 0;

            playerChoice = playerChoice.ToLower();
            // Check if the player made a valid choice.
            // Currently 'crashes' if the choice is invalid; I need to find a way to push it back to the top.
            if (playerChoice == "rock")
            {
                Console.WriteLine("Great, your choice is rock.");
            }
            else if (playerChoice == "paper")
            {
                Console.WriteLine("Great, your choice is paper.");
            }
            else if (playerChoice == "scissors")
            {
                Console.WriteLine("Great, your choice is scissors.");
            }
            else
            {
                Console.WriteLine("You did not chose a valid option. Please restart.");
            }
        }
    }
}