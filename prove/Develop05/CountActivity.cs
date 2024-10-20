public class CountActivity
{
    private List<string> _activityList;
    public CountActivity()
    {
        _activityList = [];
    }

    public void AddActivity(string activityName)
    {
        _activityList.Add(activityName);
    }
    public void DisplayActivityCount()
    {
        var result = _activityList.GroupBy(x => x)
        .Select(g => new { activityName = g.Key, activityCount = g.Count() });
        Console.WriteLine("Activity Stats: ");
        foreach (var item in result)
        {
            Console.WriteLine($"{item.activityName} Count: {item.activityCount}");
        }
    }
}