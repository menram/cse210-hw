public class Prompt
{
    public List<string> _prompts = new List<string>();

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Prompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    // A method that returns a random Prompt from the list of prompts
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        return $"{_prompts[randomGenerator.Next(0, _prompts.Count)]}";
    }
}