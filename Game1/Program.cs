using System;
//Simple Rock, Paper, and Scissors game.

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome the player
            Console.WriteLine("Hello Welcome to Rock Paper and scissors!");
            Console.Write("Before we began what is your name?: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Okay " + playerName + " lets see who can win three times!");

            //Declare any varaiables for the program
            string playerChoice;
            string CPU;
            int playerScore = 0;
            int CPUScore = 0;

            //Ask for player input
            do
            {
                Random rnd = new Random();
                int randomInt = rnd.Next(1, 4);

                Console.WriteLine("");
                Console.Write("Okay " + playerName + " What do you choose Rock Paper OR Scissors?:");
                playerChoice = Console.ReadLine();


                //Create switch case to determine who wins
                switch (randomInt)
                {
                    case 1:
                        CPU = "Rock";
                        Console.WriteLine("I chose Rock!");
                        if (playerChoice == "Rock")
                        {
                            Console.WriteLine("Its a Draw!");
                            Console.WriteLine("Your score:" + playerScore + " ------ " + "My score:" + CPUScore);
                        }
                        else if (playerChoice == "Paper")
                        {
                            Console.WriteLine("Dang i lose, you win Paper beats Rock!");
                            playerScore++;
                            Console.WriteLine("Your score:" + playerScore + " ------ " + "My score:" + CPUScore);
                        }
                        else if (playerChoice == "Scissors")
                        {
                            Console.WriteLine("Ha i win, you lose Rock Beats Scissors");
                            CPUScore++;
                            Console.WriteLine("Your score:" + playerScore + " ------ " + "My score:" + CPUScore);
                        }
                        break;

                    case 2:
                        CPU = "Paper";
                        Console.WriteLine("I chose Paper!");
                        if (playerChoice == "Rock")
                        {
                            Console.WriteLine("Ha you lost, i win Paper beats Rock!");
                            CPUScore++;
                            Console.WriteLine("Your score:" + playerScore + " ------ " + "My score:" + CPUScore);
                        }
                        else if (playerChoice == "Paper")
                        {
                            Console.WriteLine("Its a Draw!");
                            Console.WriteLine("Your score:" + playerScore + " ------ " + "My score:" + CPUScore);
                        }
                        else if (playerChoice == "Scissors")
                        {
                            Console.WriteLine("Dang i lost, you win Scissors beats Paper");
                            playerScore++;
                            Console.WriteLine("Your score:" + playerScore + " ------ " + "My score:" + CPUScore);
                        }
                        break;

                    case 3:
                        CPU = "Scissors";
                        Console.WriteLine("I chose Scissors!");
                        if (playerChoice == "Rock")
                        {
                            Console.WriteLine("Dang i lost, you win Rock beats Scissors");
                            playerScore++;
                            Console.WriteLine("Your score:" + playerScore + " ------ " + "My score:" + CPUScore);
                        }
                        else if (playerChoice == "Paper")
                        {
                            Console.WriteLine("Ha i win, you lost Scissors beats Paper!");
                            CPUScore++;
                            Console.WriteLine("Your score:" + playerScore + " ------ " + "My score:" + CPUScore);
                        }
                        else if (playerChoice == "Scissors")
                        {
                            Console.WriteLine("Dang its a draw!");
                            Console.WriteLine("Your score:" + playerScore + " ------ " + "My score:" + CPUScore);
                        }
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (playerScore < 3 && CPUScore < 3);


            if (playerScore == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Wow " + playerName + " You won the game your really good!");
            }
            else if (CPUScore == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Wow i won the game good try " + playerName + " That was fun");
            }
        }
    }
}
