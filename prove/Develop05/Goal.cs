using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public void setGoal(string goal)
    {
        _shortName = goal;
    }
    public string getGoal()
    {
        return _shortName;
    }

    public void setDescription(string description)
    {
        _description = description;
    }
    public string getDescription()
    {
        return _description;
    }
    public void setPoints(int points)
    {
        _points = points;
    }
    public int getPoints()
    {
        return _points;
    }

    // Record an event related to the goal
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    // Get a string with details about the goal
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) Points: {_points}";
    }
    public abstract string GetStringRepresentation();

}