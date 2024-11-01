// the parent class showing the "abstract" keyword included
public abstract class Activity
{
    protected string _activityDate;
    protected int _activityLength;
    public Activity(string activityDate, int activityLength)
    {
        _activityDate = activityDate;
        _activityLength = activityLength;
    }
    protected abstract double GetDistance();
    protected abstract double GetSpeed();
    protected abstract double GetPace();
    public abstract string GetSummary();
}
