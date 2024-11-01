// the parent class showing the "abstract" keyword included
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _shortName;
    }
    public int GetPoints()
    {
        return _points;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
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
        return detail;
    }
    public abstract string GetStringRepresentation();
}
