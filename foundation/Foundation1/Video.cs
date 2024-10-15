public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    // A method that returns the number of comments
    public int ReturnNumberOfComments()
    {
        return _comments.Count();
    }
    public void AddVideoComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public string GetDisplayText()
    {
        string text;
        text = $"Video Title: {_title} | Author: {_author} | Length: {_length} secs\n";
        text += $"Comments [{ReturnNumberOfComments()}]\n";
        foreach (Comment c in _comments)
        {
            text += c.GetDisplayText();
        }
        return text;
    }
}