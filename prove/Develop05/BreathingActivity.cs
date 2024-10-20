// a child class called BreathingActivity
public class BreathingActivity : Activity
{
    // calling the parent constructor using "base"!
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        // Console.CursorVisible = false;
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("\nBreath in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breath out...");
            ShowCountDown(6);
            Console.WriteLine();
        }
        Console.WriteLine();
        DisplayEndingMessage();
        Console.Clear();
    }
}
