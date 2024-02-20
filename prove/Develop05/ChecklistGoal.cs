public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        // Specific logic for ChecklistGoal recording event
        // Implement this in derived class
        _amountCompleted++;

        // Check if the goal is complete based on the checklist
        // Implement this in derived class
    }

    public override bool IsComplete()
    {
        // Specific logic for ChecklistGoal completion check
        // Implement this in derived class
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        // Additional details for ChecklistGoal
        return $"{base.GetDetailsString()}, Amount Completed: {_amountCompleted}, Target: {_target}, Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        // Specific string representation for ChecklistGoal
        // Implement this in derived class
        // return $"Checklist Goal: {_shortName}";
        return "nothing";

    }
}