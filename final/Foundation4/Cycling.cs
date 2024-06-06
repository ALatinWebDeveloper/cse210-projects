using System;

public class Cycling : Activity
{
    public double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
        _date = date;
        _length = length;
    }

    public override double CalcDistance()
    {
        return _length / CalcPace();
    }

    public override double CalcSpeed()
    {
        return _speed;
    }

    public override double CalcPace()
    {
        return 60 / CalcSpeed();
    }

    public override void GetSummary()
    {
        Console.WriteLine($"-- {_date} Running ({_length} min)- Distance {CalcDistance().ToString("0.0")}, Speed {CalcSpeed().ToString("0.0")} mph, Pace: {CalcPace().ToString("0.0")} min per mile");
    }
}