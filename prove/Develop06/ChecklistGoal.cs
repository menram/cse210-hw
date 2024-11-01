// a child class
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        string detail = $"{_shortName} ({_description})";
        if (IsComplete())
        {
            detail = "[X] " + detail;
        }
        else
        {
            detail = "[ ] " + detail;
        }
        detail += $" -- Currently completed: {_amountCompleted}/{_target}";
        return detail;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}