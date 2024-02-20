public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Specific logic for SimpleGoal recording event
        // Implement this in derived class
    }

    public override bool IsComplete()
    {
        // Specific logic for SimpleGoal completion check
        // Implement this in derived class
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Specific string representation for SimpleGoal
        // Implement this in derived class
        //return $"Simple Goal: {_shortName}";
        return "nothing";
    }
}