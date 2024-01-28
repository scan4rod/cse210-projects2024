using System;
using System.Linq;

class SentenceMemoryGame
{
    static void Main()
    {
        string sentence = "This is a sample sentence for the memory game.";
        string[] words = sentence.Split(' ');

        Console.WriteLine("Welcome to the Sentence Memory Game!");
        Console.WriteLine("Try to memorize the sentence:");

        // Display the sentence with random words removed
        DisplaySentenceWithBlanks(words);

        Console.WriteLine("\nGuess the missing word:");

        // Randomly remove a word and get the index
        int missingWordIndex = RemoveRandomWord(words);

        // Get user input for the missing word
        string userGuess = Console.ReadLine();

        // Check if the user's guess is correct
        if (string.Equals(userGuess, words[missingWordIndex], StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Congratulations! Your guess is correct.");
        }
        else
        {
            Console.WriteLine($"Sorry, the correct word was: {words[missingWordIndex]}");
        }
    }

    static void DisplaySentenceWithBlanks(string[] words)
    {
        Random random = new Random();
        foreach (var word in words)
        {
            if (random.Next(2) == 0) // 50% chance of displaying a blank
            {
                Console.Write("____ ");
            }
            else
            {
                Console.Write(word + " ");
            }
        }
    }

    static int RemoveRandomWord(string[] words)
    {
        Random random = new Random();
        int missingWordIndex = random.Next(words.Length);
        words[missingWordIndex] = ""; // Remove the word at the selected index
        return missingWordIndex;
    }
}

