public class Comment
{
    private string _name = "";
    private string _text = "";

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // A method that displays the Comment details 
    public string GetDisplayText()
    {
        string comment = $"{_name}: {_text}\n";
        return comment;
    }

}