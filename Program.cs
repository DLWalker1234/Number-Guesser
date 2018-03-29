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

        }
    }
}
