using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    // Constructor for ListingActivity
    public ListingActivity()
    {
        // Initialize or set default values for ListingActivity-specific properties
        _count = 0;
        _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?",
    "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};
    }

    // Method specific to ListingActivity
    public void Run(int dur)
    {
        ListingActivity prompt = new ListingActivity();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        string prompt1 = prompt.GetRandomPrompt();
        Console.WriteLine($" --- {prompt1} ---");
        Console.Write("You may begin in: ");
        prompt.ShowCounterDown(5);
        Console.WriteLine("");
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(dur);

        List<string> userPromptList = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string getList = Console.ReadLine();
            userPromptList.Add(getList);
        }
        //int countList = ;

        Console.Write($"You have listed {userPromptList.Count} items!");
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}