using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int playerScore,
                computerScore,
                random;
            string playerInput,
                computerInput;

            while (true)
            {
                playerScore = computerScore = 0;
                while ((playerScore < 3) && (computerScore < 3))
                {
                    Console.Write("Chose between ROCK, PAPER and SCISSORS : ");
                    playerInput = Console.ReadLine().ToUpper();
                    random = rand.Next(1, 4);
                    switch (random)
                    {
                        case 1:
                            computerInput = "ROCK";
                            if(playerInput == computerInput)
                            {
                                ResultInfo(ConsoleColor.Yellow, "DRAW", playerScore, computerScore);
                            }
                            else if(playerInput == "SCISSORS")
                            {
                                ResultInfo(ConsoleColor.Red, "COMPUTER WON!", playerScore, ++computerScore);
                            }
                            else if(playerInput == "PAPER")
                            {
                                ResultInfo(ConsoleColor.Green, "PLAYER WON!", ++playerScore, computerScore);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Enter valid data!");
                                Console.ResetColor();
                            }
                            break;
                        case 2:
                            computerInput = "PAPER";
                            if (playerInput == computerInput)
                            {
                                ResultInfo(ConsoleColor.Yellow, "DRAW", playerScore, computerScore);
                            }
                            else if (playerInput == "ROCK")
                            {
                                ResultInfo(ConsoleColor.Red, "COMPUTER WON!", playerScore, ++computerScore);
                            }
                            else if(playerInput == "SCISSORS")
                            {
                                ResultInfo(ConsoleColor.Green, "PLAYER WON!", ++playerScore, computerScore);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Enter valid data!");
                                Console.ResetColor();
                            }
                            break;
                        case 3:
                            computerInput = "SCISSORS";
                            if (playerInput == computerInput)
                            {
                                ResultInfo(ConsoleColor.Yellow, "DRAW", playerScore, computerScore);
                            }
                            else if (playerInput == "PAPER")
                            {
                                ResultInfo(ConsoleColor.Red, "COMPUTER WON!", playerScore, ++computerScore);
                            }
                            else if(playerInput == "ROCK")
                            {
                                ResultInfo(ConsoleColor.Green, "PLAYER WON!", ++playerScore, computerScore);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Enter valid data!");
                                Console.ResetColor();
                            }
                            break;
                    }
                }

                Console.Write("Do you want to play again?[y/n] : ");
                if (Console.ReadLine() != "y") break;
            }
        }
        static void ResultInfo(ConsoleColor color, string message, int playerScore, int computerScore)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("{0}! - PLAYER [{1}] : [{2}] COMPUTER",message,playerScore,computerScore);
            Console.ResetColor();
        }
    }
}
