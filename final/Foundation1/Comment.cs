using System;

public class Comment
{
    private string _comment { get; set;}
    private string _name { get; set;}

    public Comment(string name, string comment)
    {
        _comment = comment;
        _name = name;
    }

    public string GetComment()
    {
        return _comment;
    }

    public string GetName()
    {
        return _name;
    }
}