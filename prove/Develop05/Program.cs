using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        choice = 0;
        int opt_num;
        int goalType;
        Console.Clear();

        GoalManager goal1 = new GoalManager();



        int seconds = 0;
        do
        {
            Console.WriteLine("You have 0 points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string opt = Console.ReadLine();
            opt_num = int.Parse(opt);
            choice = opt_num;

            if (choice == 1)
            {


                goal1.ListGoalNames();
                Console.Write("Which type of goal would you like to create? ");
                goalType = int.Parse(Console.ReadLine());
                if (goalType == 1)
                {

                    goal1.CreateGoal();

                }
                if (goalType == 2)
                {

                    goal1.CreateGoal();

                }

            }
            if (choice == 2)
            {
                goal1.ListGoalDetails();

            }
            if (choice == 3)
            {
                goal1.SaveGoals();

            }
            if (choice == 4)
            {
                goal1.LoadGoals();

            }
            if (choice == 5)
            {


            }

        } while (choice != 6);
    }

}