using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string usern = PromptUserName();
        int userNum = PromptUserNumber();

        int square = SquareNumber(userNum);

        DisplayResult(usern, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string nam = Console.ReadLine();

        return nam;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());

        return num;
    }

    static int SquareNumber(int num)
    {
        int square = num * num;
        return square;
    }

    static void DisplayResult(string nam, int square)
    {
        Console.WriteLine($"{nam}, the square of your number is {square}");
    }
}