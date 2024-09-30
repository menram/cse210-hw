public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Entry()
    {
    }

    // A method that displays the Entry details 
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }

}