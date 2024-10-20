// a child class called ReflectingActivity
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // calling the parent constructor using "base"!
    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>() { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        _questions = new List<string>() { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        // Console.CursorVisible = false;
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may being in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            DisplayQuestions();
        }
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
    private string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int questionsRandomIndex = randomGenerator.Next(0, _questions.Count);
        return _questions[questionsRandomIndex];
    }
    private void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine();
    }
    private void DisplayQuestions()
    {
        Console.Write($"{GetRandomQuestion()}");
        ShowSpinner(15);
        Console.WriteLine();
    }
}
