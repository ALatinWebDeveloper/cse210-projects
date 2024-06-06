using System;

public class Running : Activity
{
    private double _distance; 

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
        _length = length;
        _date = date;
    }

    public override double CalcDistance()
    {   
        return _distance;
    }

    public override double CalcSpeed()
    {   
        return (_distance / _length) * 60;
    }

    public override double CalcPace()
    {
        return 60 / CalcSpeed();
    }

    public override void GetSummary()
    {
        Console.WriteLine($"-- {_date} Running ({_length} min)- Distance {_distance.ToString("0.0")}, Speed {CalcSpeed().ToString("0.0")} mph, Pace: {CalcPace().ToString("0.0")} min per mile");
    }
}