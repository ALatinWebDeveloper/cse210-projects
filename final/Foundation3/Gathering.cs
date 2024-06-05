using System;

public class Gathering : Event
{
    public Gathering(string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        
    }

    public override void StandardDetails()
    {
        Console.WriteLine($"{GetTitle()}, {GetDescription()}, {GetDate()}, {GetTime()}, {GetAddress()}");
    }

    public override void FullDetails()
    {
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}");
        Console.WriteLine($"Location: {GetAddress()}");
        Console.WriteLine(typeof(Gathering));
        Console.WriteLine("");
    }

    public override void ShortDetails()
    {
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
    }
}