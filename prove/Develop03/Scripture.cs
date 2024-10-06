public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string t in text.Split())
        {
            _words.Add(new Word(t));
        }
    }

    // A method that returns a random Scripture from the list of Scriptures
    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int wordsRandomIndex = randomGenerator.Next(0, _words.Count);
            while (_words[wordsRandomIndex].IsHidden())
            {
                wordsRandomIndex = randomGenerator.Next(0, _words.Count);
            }
            _words[wordsRandomIndex].Hide();
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    public string GetDisplayText()
    {
        string text;
        text = _reference.GetDisplayText() + " ";
        foreach (Word w in _words)
        {
            text += w.GetDisplayText() + " ";
        }
        text = text.TrimEnd();
        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                isCompletelyHidden = false;
                break;
            }
        }
        return isCompletelyHidden;
    }
}