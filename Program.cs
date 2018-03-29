using System;

// Namespace
namespace numberguesser2
{
    // Main Class
    class Program
    {
        // Method Entry Point
        static void Main(string[] args)
        {
            GetAppInfo(); // Run Get App Info Function

            GreetUser(); // Greets user by Name

            while (true)
            {
                // Set Number
                // Create a New Random Object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // init Guess Var
                int guessNumber = 0;

                // Ask User For Number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guessNumber != correctNumber)
                {
                    // Get Users Input
                    string userGuess = Console.ReadLine();

                    // Make Sure its a Number
                    if (!int.TryParse(userGuess, out guessNumber))
                    {
                        // Print Error Message
                        PrintColorMessage(ConsoleColor.Red,"Please and ACTUAL NUMBER BRO!")

                        // Kepp Going
                        continue;
                    }

                    // Cast to int and put into guessNumber var
                    guessNumber = Int32.Parse(userGuess);

                    // Match Guess to Correct Number
                    if (guessNumber != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Numver Please Try Again!");
                    }
                }

                // Output Success Message               
                PrintColorMessage(ConsoleColor.Yellow, "Correct, What are the ODDS!?!");

                // Ask to Play Again
                Console.WriteLine("Play again [y/n]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // Set app Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dustin Walker";

            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write Out App Info
            Console.WriteLine("{0} version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask Users Name (Input)
            Console.WriteLine("What is your Name? ");

            // Get Input
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Shall we play a game?", userName);
        }
        // Print Color Message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change Text Color
            Console.ForegroundColor = color;

            // Tell User its NOT A NUMBER
            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
