// a child class
public class Running : Activity
{
    private double _distance;
    public Running(string activityDate, int activityLength, double distance) : base(activityDate, activityLength)
    {
        _distance = distance;
    }
    protected override double GetDistance()
    {
        return _distance;
    }
    protected override double GetSpeed()
    {
        return _distance / _activityLength * 60;
    }
    protected override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetSummary()
    {
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        return $"{_activityDate} Running ({_activityLength} min)- Distance {_distance} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}