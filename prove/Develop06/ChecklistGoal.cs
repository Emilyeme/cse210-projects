public class ChecklistGoal : Goal
{
    private int _currentProgress;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _currentProgress = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_currentProgress < _target)
        {
            _currentProgress++;
            if (_currentProgress == _target)
            {
                _points += _bonus; // Add bonus points when target is reached
            }
        }
    }

    public override bool IsComplete()
    {
        return _currentProgress >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points}, Progress: {_currentProgress}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - Checklist Goal";
    }
}
