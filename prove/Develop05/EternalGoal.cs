public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Specific logic for EternalGoal recording event
        // Implement this in derived class
    }

    public override bool IsComplete()
    {
        // Specific logic for EternalGoal completion check
        // Implement this in derived class
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Specific string representation for EternalGoal
        // Implement this in derived class
        //return $"Eternal Goal: {_shortName}";
        return "nothing";
    }
}