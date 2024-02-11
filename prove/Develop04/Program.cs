using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        choice = 0;
        int opt_num;
        Console.Clear();

        Activity activity = new Activity();
        int seconds = 0;
        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string opt = Console.ReadLine();
            opt_num = int.Parse(opt);
            choice = opt_num;

            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Breathing Activity.");
                Console.WriteLine("");
                Console.WriteLine("This activity will help you relax by walking you through breathing in an out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine("");
                Console.Write("How long in seconds would you like for your session? ");
                seconds = int.Parse(Console.ReadLine());
                activity.SetDuration(seconds);
                activity.SetDescription("Breathing");

                activity.DisplayStartingMessage();
                BreathingActivity bActivity = new BreathingActivity();
                bActivity.Run(activity.GetDuration());
                activity.DisplayEndingMessage();





            }
            if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Reflecting Activity.");
                Console.WriteLine("");
                Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it ino ther aspects of your life.");
                Console.WriteLine("");
                Console.Write("How long in seconds would you like for your session? ");
                seconds = int.Parse(Console.ReadLine());
                activity.SetDuration(seconds);
                activity.SetDescription("Reflecting");
                activity.DisplayStartingMessage();
                ReflectingActivity rActivity = new ReflectingActivity();
                rActivity.Run();

                activity.DisplayEndingMessage();

            }
            if (choice == 3)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Listing Activity.");
                Console.WriteLine("");
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine("");
                Console.Write("How long in seconds would you like for your session? ");
                seconds = int.Parse(Console.ReadLine());
                activity.SetDuration(seconds);
                activity.SetDescription("Listing");
                activity.DisplayStartingMessage();
                ListingActivity lActivity = new ListingActivity();
                lActivity.Run(activity.GetDuration());
                activity.DisplayEndingMessage();
            }

        } while (choice != 4);
    }
}
