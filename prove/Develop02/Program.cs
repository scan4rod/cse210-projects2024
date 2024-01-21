using System;
using System.IO;



class Program
{
    static void Main(string[] args)
    {
        int jor;
        jor = 0;
        int opt_num;
        PromptGenerator prompt = new PromptGenerator();
        Journal jour = new Journal();

        Console.WriteLine("Welcome to the journal program! ");
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string opt = Console.ReadLine();
            opt_num = int.Parse(opt);
            jor = opt_num;

            if (jor == 1)
            {
                string prompt1 = prompt.GetPrompt();
                Console.WriteLine(prompt1);
                Console.Write("> ");
                string get_rec = Console.ReadLine();
                Entry entry = new Entry();
                DateTime today = DateTime.Now;
                string date = today.ToShortDateString();
                entry._date = date;
                entry._promptDay = $"Prompt: {prompt1}";
                entry._entryDay = get_rec;
                jour._entries.Add(entry);


            }
            if (jor == 2)
            {
                jour.DisplayEntries();
            }
            if (jor == 4)
            {
                jour.SaveFile();
            }
            if (jor == 3)
            {
                jour.LoadFile();
            }
        } while (jor != 5);
    }
}