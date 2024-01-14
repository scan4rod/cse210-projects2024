using System;

class Program
{
    static void Main(string[] args)
    {
        int guesn;
        int num;
        int count = 0;
        string cont = "yes";
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 20);

        Console.WriteLine("What is the magic number? ");
        //string ans = Console.ReadLine();
        //num = int.Parse(ans);
        num = number;
        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guesn = int.Parse(guess);
            count += 1;

            if (guesn > num)
            {
                Console.WriteLine("Lower");
            }
            else if (guesn == num)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"Number of guesses: {count}");

                Console.Write("Do you want to play again? yes or no: ");
                cont = Console.ReadLine();
                if (cont == "yes")
                {
                    guesn = 0;
                    num = number = randomGenerator.Next(1, 20);
                    count = 0;
                }

            }
            else
            {
                Console.WriteLine("Higher");
            }
        } while (guesn != num);


    }
}