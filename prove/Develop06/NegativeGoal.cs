public class NegativeGoal : Goal
{
    private int _penaltyAmount;
    private string _reasonForPenalty;

    
    public NegativeGoal(string name, string description, int points, int penaltyAmount, string reasonForPenalty) 
        : base(name, description, points)
    {
        _penaltyAmount = penaltyAmount;
        _reasonForPenalty = reasonForPenalty;
    }

    public override void RecordEvent()
    {
        _points -= _penaltyAmount;  
        Console.WriteLine($"Penalty applied: {_reasonForPenalty}. {points} points deducted.");
    }

    
    public override bool IsComplete()
    {
        return _points <= 0;  
    }

   
    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points}, Penalty: {_penaltyAmount}, Reason: {_reasonForPenalty})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - Negative Goal";
    }
}
