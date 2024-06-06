using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("10/06/24", 30, 3);
        Cycling cicling = new Cycling("10/06/24", 60, 25);
        Swimming swimming = new Swimming("10/06/24", 20, 20);

        List<Activity> activities = new List<Activity>();

        activities.Add(running);
        activities.Add(cicling);
        activities.Add(swimming);

        Console.Clear();

        foreach (var activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine("");
        }
    }
}