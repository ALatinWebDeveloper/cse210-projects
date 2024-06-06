using System;

public class Activity
{
    public string _date;
    public double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public virtual double CalcDistance()
    {
        return 0;
    }

    public virtual double CalcSpeed()
    {
        return 0;
    }

    public virtual double CalcPace()
    {
        return 0;
    }

    public virtual void GetSummary()
    {
        
    }
}