using System;

public class Video
{
    private string _title { get; set;}
    private string _author { get; set;}
    private int _length { get; set;}
    private List<Comment> _comments{ get; set;}

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public string DisplayTitle()
    {
        return _title;
    }

    public string DisplayAuthor()
    {
        return _author;
    }

    public int DisplayLength()
    {
        return _length;
    }

    public int NbrComments()
    {
        return _comments.Count;
    }

    public void DisplayComment()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()} commented: {comment.GetComment()}");
        }
    }


}