public class Word
{
    private string _text;
    private bool _isHidden;
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // A method that displays the Word details 
    public string GetDisplayText()
    {
        string word = $"{_text}";
        if (_isHidden)
        {
            word = new string('_', _text.Length);
        }
        return word;
    }

}