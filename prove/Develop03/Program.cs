using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the Scripture class with specific values
        Reference reference = new Reference("Proverbs", 3, 5);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        string userInput;

        do
        {
            // Display the current state of the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Ask the user to press Enter to continue or type 'quit' to finish
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

            // If the user doesn't type 'quit', hide a random number of words on each iteration
            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(2);
            }

        } while (userInput.ToLower() != "quit");

    }
}