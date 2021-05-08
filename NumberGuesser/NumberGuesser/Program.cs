using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("'Guess a number between 1 and 10'");
                while (guess != correctNumber)
                {
                    string guessS = Console.ReadLine();

                    if (!int.TryParse(guessS, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");
                        continue;
                    }

                    guess = int.Parse(guessS);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                    else
                    {
                        PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!");

                        Console.WriteLine("PLay Again? [Y/N]");
                        string answer = Console.ReadLine().ToUpper();

                        if (answer == "Y") continue;
                        else  return;
                    }
                }
            }
        }
        static void GetAppInfo() {
            string appName = "NumberGuesser",
                    appVersion = "1.0.0",
                    appAuthor = "Łukasz Michalik";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
        static void GreetUser() {
            Console.WriteLine("What is your name ? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", name);
        }
        static void PrintColorMessage(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine("{0}",message);
            Console.ResetColor();
        }
    }
}
