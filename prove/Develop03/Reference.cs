public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // =================================================
    // accessors and mutators not needed for this class
    // =================================================
    // public string GetBook()
    // {
    //     return _book;
    // }

    // public void SetBook(string book)
    // {
    //     _book = book;
    // }

    // public int GetChapter()
    // {
    //     return _chapter;
    // }

    // public void SetChapter(int chapter)
    // {
    //     _chapter = chapter;
    // }

    // public int GetVerse()
    // {
    //     return _verse;
    // }

    // public void SetVerse(int verse)
    // {
    //     _verse = verse;
    // }

    // public int GetEndVerse()
    // {
    //     return _endVerse;
    // }

    // public void SetEndVerse(int endVerse)
    // {
    //     _endVerse = endVerse;
    // }

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // A method that displays the Reference details 
    public string GetDisplayText()
    {
        string reference = $"{_book} {_chapter}:{_verse}";
        if (_endVerse > 0)
        {
            reference += $"-{_endVerse}";
        }
        return reference;
    }

}