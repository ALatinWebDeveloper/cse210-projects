using System;

public class Goal
{
    private string _ShortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _ShortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _ShortName;
    }

    public string GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {
        
    }

    public virtual bool IsComplete()
    {
        Console.WriteLine("base");
        return true;
    }

    public string GetDetailsString()
    {
        return _description;
    }

    public virtual string GetStringRepresentation()
    {
        return _points;
    }
}