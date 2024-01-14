using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int conti = 1;
        int sum = 0;
        int cont = 0;
        double ave;
        do
        {
            Console.Write("Enter number: ");
            string x = Console.ReadLine();
            int y = int.Parse(x);
            numbers.Add(y);
            if (y == 0)
            {
                conti = 0;
            }
        } while (conti != 0);

        foreach (int num in numbers)
        {
            sum += num;
            cont += 1;

        }

        ave = (double)sum / (cont - 1);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}