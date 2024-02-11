using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor for ReflectingActivity
    public ReflectingActivity()
    {
        // Initialize or set default values for ReflectingActivity-specific properties
        _prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

        _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?",
    "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    }

    // Method specific to ReflectingActivity
    public void Run()
    {
        DisplayPrompt();
        DisplayQuestions();


    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {

        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];

    }

    // Method to get a random question from the list
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        return _questions[randomIndex];
    }

    // Method to display a random prompt
    public void DisplayPrompt()
    {
        ReflectingActivity prompt = new ReflectingActivity();
        Console.WriteLine("Consider the following prompt: ");
        string prompt1 = prompt.GetRandomPrompt();
        Console.WriteLine($" --- {prompt1} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        string userInput = Console.ReadLine();
    }

    // Method to display a random question
    public void DisplayQuestions()
    {
        ReflectingActivity prompt = new ReflectingActivity();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("\nYou may begin: ");
        prompt.ShowCounterDown(5);
        Console.Clear();

        string question1 = prompt.GetRandomQuestion();
        Console.Write($"> {question1} -");
        prompt.ShowSpinner(30);
        Console.WriteLine("");
        string question2 = prompt.GetRandomQuestion();
        Console.Write($"> {question2} -");
        prompt.ShowSpinner(30);
    }
}