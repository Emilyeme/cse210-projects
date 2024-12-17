public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // No change needed for eternal goal
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - Eternal Goal";
    }
}
