using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        List<Activity> activities = [];
        Running running = new Running("10/31/2024", 30, 5);
        activities.Add(running);
        Cycling cycling = new Cycling("10/31/2024", 30, 24);
        activities.Add(cycling);
        Swimming swimming = new Swimming("10/31/2024", 30, 20);
        activities.Add(swimming);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}