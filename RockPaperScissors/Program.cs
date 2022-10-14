using System;

namespace RockPaperScissors
{

    class Program
    {
        static void Main(string[] args)
        {
            string playerChoice = "a";
            string computerChoice;
            var stillPlaying = true;
            Console.WriteLine("Welcome to Rock, Paper, and Scissors!");
            Console.WriteLine("Please choose an option: Rock, Paper, or Scissors.");
            //Repeat if playing

            while (stillPlaying == true)
            {
                // Check if the player made a valid choice.
                var answered = false;
                while (answered == false)
                {
                    playerChoice = Console.ReadLine();
                    playerChoice = playerChoice.ToLower();
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


                Random computerNumber = new Random();
                int computerRoll = computerNumber.Next(0, 2);

                if (computerRoll == 0)
                {
                    computerChoice = "rock";
                }
                else if (computerRoll == 1)
                {
                    computerChoice = "paper";
                }
                else
                {
                    computerChoice = "scissors";
                }

                Console.WriteLine($"The computer's choice is {computerChoice}.");

                //Player is rock.
                if (playerChoice == "rock" && computerChoice == "rock")
                {
                    Console.WriteLine("Tie game!");
                }
                else if (playerChoice == "rock" && computerChoice == "scissors")
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == "rock" && computerChoice == "paper")
                {
                    Console.WriteLine("You lose!");
                }


                //Player is paper.
                if (playerChoice == "paper" && computerChoice == "rock")
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == "paper" && computerChoice == "paper")
                {
                    Console.WriteLine("Tie game!");
                }
                else if (playerChoice == "paper" && computerChoice == "scissor")
                {
                    Console.WriteLine("You lose!");
                }

                //Player is scissors.
                if (playerChoice == "scissors" && computerChoice == "rock")
                {
                    Console.WriteLine("You lose!");
                }
                else if (playerChoice == "scissors" && computerChoice == "paper")
                {
                    Console.WriteLine("You win!");
                }
                else if (playerChoice == "scissors" && computerChoice == "scissors")
                {
                    Console.WriteLine("Tie game!");
                }


                var finalQuestionCheck = false;

                while (finalQuestionCheck == false)
                {
                Console.WriteLine("Do you still want to play?");
                var answerToPlay = Console.ReadLine();
                answerToPlay = answerToPlay.ToLower();
                    switch (answerToPlay)
                    {
                        case "yes":
                            stillPlaying = true;
                            finalQuestionCheck = true;
                            Console.WriteLine("Okay. Good luck on your next game!");
                            Console.WriteLine("Welcome to Rock, Paper, and Scissors!");
                            Console.WriteLine("Please choose an option: Rock, Paper, or Scissors.");
                            break;
                        case "no":
                            stillPlaying = false;
                            finalQuestionCheck = true;
                            Console.WriteLine("Okay. Thank you for playing!");
                            Console.WriteLine("Press any key to exit.");
                            break;
                        default:
                            Console.WriteLine("Please say 'yes' or 'no'.");
                            break;
                    }
                }
            }
        }
    }
}