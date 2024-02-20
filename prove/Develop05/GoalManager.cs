using System;



public class GoalManager
{
    private List<Goal> _goals;
    private int _score;


    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Goal Manager started!");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. ChecklistGoal");
    }

    public void ListGoalDetails()
    {


        Console.WriteLine("The goals are:");
        int i = 0;
        foreach (var goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            //$"[ ] {_shortName} ({_description}) Points: {_points}";

        }
    }

    public void CreateGoal()
    {

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = new SimpleGoal(goalName, description, points);

        _goals.Add(newGoal);

        Console.WriteLine($"Goal '{goalName}' created!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");
        ListGoalNames();
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename?");
        string fNam = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fNam))
        {
            foreach (Goal entry in _goals)
            {
                //string nameS = entry.getGoal;
                outputFile.WriteLine($"{entry.getGoal()},{entry.getDescription()},{entry.getPoints()}");
            }
        }


    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _goals.Clear();
        foreach (string line in lines)
        {

        }

    }
}