public class ProgressiveGoal : Goal
{
    private int _currentProgress;
    private int _target;
    private string _progressDescription;

    public ProgressiveGoal(string name, string description, int points, int target, string progressDescription) 
        : base(name, description, points)
    {
        _currentProgress = 0;
        _target = target;
        _progressDescription = progressDescription;
    }

    public override void RecordEvent()
    {
        if (_currentProgress < _target)
        {
            _currentProgress++;
        }
    }

    public override bool IsComplete()
    {
        return _currentProgress >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points}, Progress: {_currentProgress}/{_target} - {_progressDescription})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - Progressive Goal";
    }
}
