using System;

public class BreathingActivity : Activity
{
    // Constructor for BreathingActivity
    public BreathingActivity()
    {

    }

    // Method specific to BreathingActivity
    public void Run(int dur)
    {

        DateTime starTime = DateTime.Now;

        DateTime endTime = starTime.AddSeconds(dur);


        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Breathe in...");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);

                Console.Write("\b \b");
            }
            Console.WriteLine("");
            Console.Write("Now breathe out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);

                Console.Write("\b \b");
            }

        }


    }
}

