// a child class called ListingActivity
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    // calling the parent constructor using "base"!
    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>() { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
        _count = 0;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine();
        Console.Write("You may being in: ");
        ShowCountDown(5);
        Console.WriteLine();
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
        Console.Clear();
    }
    private string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int promptsRandomIndex = randomGenerator.Next(0, _prompts.Count);
        return _prompts[promptsRandomIndex];
    }
    public List<string> GetListFromUser()
    {
        string fromUser;
        List<string> _listFromUser = [];
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            fromUser = Console.ReadLine();
            _listFromUser.Add(fromUser);
        }
        return _listFromUser;
    }
}
