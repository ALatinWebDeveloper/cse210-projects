using System;

public class Swimming : Activity
{
    public int _laps;

    public Swimming(string date, double length, int laps) : base(date, length)
    {
        _laps = laps;
        _date = date;
        _length = length;
    }

    public override double CalcDistance()
    {
        return _laps * 50 / 1000 * 62;
    }

    public override double CalcSpeed()
    {
        return (CalcDistance() / _length) * 60;
    }

    public override double CalcPace()
    {
        return _length / CalcDistance();
    }

    public override void GetSummary()
    {
        Console.WriteLine($"-- {_date} Running ({_length} min)- Distance {CalcDistance().ToString("0.0")}, Speed {CalcSpeed().ToString("0.0")} mph, Pace: {CalcPace().ToString("0.0")} min per mile");
    }
}