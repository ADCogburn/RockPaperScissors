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
            while (check == 0)
            {
                if (playerChoice == "rock")
                {
                    check++;
                }
                else if (playerChoice == "paper")
                {
                    check++;
                }
                else if (playerChoice == "scissor")
                {
                    check++;
                }
            }
        }
    }
}