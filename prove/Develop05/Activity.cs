// a parent class called Activity
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }
    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");
        try
        {
            _duration = Int32.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Not a valid seconds value was entered.");
        }
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }
    protected void ShowSpinner(int seconds)
    {
        int sleepTime = 150;
        string[] animationCharacters = ["|", "/", "—", "\\"];
        int i = 0;
        DateTime futureTime = DateTime.Now.AddSeconds(seconds);
        Console.CursorVisible = false;
        while (DateTime.Now < futureTime)
        {
            Console.Write(animationCharacters[i]);
            Thread.Sleep(sleepTime);
            Console.Write("\b \b");
            i++;
            if (i == animationCharacters.Length) { i = 0; }
        }
        Console.CursorVisible = true;
    }
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public string GetActivityName()
    {
        return _name;
    }
}