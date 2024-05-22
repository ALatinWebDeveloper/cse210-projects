using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void Run()
    {
        DisplayStartingMessage();
        showSpinner();
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < finishTime)
        {   
            
        Console.Write($"Breath in...");
        showCountDown();
        Console.WriteLine("");
        Console.WriteLine("");
            
        Console.Write($"Breath out...");
        showCountDown();
        Console.WriteLine("");
        Console.WriteLine("");

        }
        
        DisplayEndingMessage();
        showSpinner();
    }

}