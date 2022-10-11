using System;

namespace RockPaperScissors
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, and Scissors!");
            Console.WriteLine("Please choose an option: Rock, Paper, or Scissors.");

            var answered = false;

            // Check if the player made a valid choice.
            // Currently 'crashes' if the choice is invalid; I need to find a way to push it back to the top.
            while (answered == false)
            {
                string playerChoice = Console.ReadLine();
                switch (playerChoice)
                {
                    case "rock":
                        answered = true;
                        break;
                    case "paper":
                        answered = true;
                        break;
                    case "scissors":
                        answered = true;
                        break;
                    default:
                        Console.WriteLine("Please try again. Choose 'rock', 'paper', or 'scissors'.");
                        break;
                }
            }
        }
    }
}