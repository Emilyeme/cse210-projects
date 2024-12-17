public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Record an event (increment the amount completed)
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                _bonus += _points;  // Add bonus upon completion
            }
        }
    }

    // Check if the checklist goal is complete
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Get details about the checklist goal
    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points}, Completed: {_amountCompleted}/{_target})";
    }

    // Get a string representation of the checklist goal
    public override string GetStringRepresentation()
    {
        return $"{_shortName} - Checklist Goal";
    }
}
