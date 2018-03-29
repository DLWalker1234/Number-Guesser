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
            // Set app Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dustin Walker";

            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write Out App Info
            Console.WriteLine("{0} version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            // Ask Users Name (Input)
            Console.WriteLine("What is your Name? ");

            // Get Input
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Shall we play a game?", userName);

            // Set Number
            int correctNumber = 7;

            // init Guess Var
            int guessNumber = 0;

            // Ask User For Number
            Console.WriteLine("Guess a number between 1 and 10");

            // while guess is not correct
            while(guessNumber != correctNumber)
            {
                // Get Users Input
                string userGuess = Console.ReadLine();

                // Cast to int and put into guessNumber var
                guessNumber = Int32.Parse(userGuess);

                // Match Guess to Correct Number
                if(guessNumber != correctNumber)
                {
                    // Change Text Color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Write Out App Info
                    Console.WriteLine("Wrong Number Please Try Again");

                    Console.ResetColor();
                }
            }


        }
    }
}
