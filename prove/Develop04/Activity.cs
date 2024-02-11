using System;
using System.Runtime.InteropServices;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Constructor
    public Activity()
    {
        // Initialize or set default values if needed
        _name = "";
        _description = "";
        _duration = 0;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }


    // Method to display a starting message
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

    }

    // Method to display an ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetDescription()} Activity.");
        ShowSpinner(5);
        Console.Clear();
    }

    // Method to show a spinner for a given number of seconds
    public void ShowSpinner(int seconds)
    {

        List<string> spin = new List<string>();
        spin.Add("|");
        spin.Add("/");
        spin.Add("-");
        spin.Add("\\");
        spin.Add("|");
        spin.Add("\\");


        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(5);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spin[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= spin.Count)
            {
                i = 0;
            }
        }


    }

    // Method to show a countdown for a given number of seconds
    public void ShowCounterDown(int seconds)
    {

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            Console.Write("\b \b");
        }



        // You can implement the countdown logic here
    }
}