// a child class
public class Swimming : Activity
{
    private double _laps;
    public Swimming(string activityDate, int activityLength, int laps) : base(activityDate, activityLength)
    {
        _laps = laps;
    }
    protected override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    protected override double GetSpeed()
    {
        return GetDistance() / _activityLength * 60;
    }
    protected override double GetPace()
    {
        return _activityLength / GetDistance();
    }
    public override string GetSummary()
    {
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        return $"{_activityDate} Swimming ({_activityLength} min)- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}