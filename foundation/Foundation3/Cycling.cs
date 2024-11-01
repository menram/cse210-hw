// a child class
public class Cycling : Activity
{
    private double _speed;
    public Cycling(string activityDate, int activityLength, double speed) : base(activityDate, activityLength)
    {
        _speed = speed;
    }
    protected override double GetDistance()
    {
        return _speed * _activityLength / 60;
    }
    protected override double GetSpeed()
    {
        return _speed;
    }
    protected override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        return $"{_activityDate} Cycling ({_activityLength} min)- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}