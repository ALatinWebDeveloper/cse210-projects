using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _answers;

    public ListingActivity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _answers = new List<string>
        {};
    }

    public void getRandomPrompt()
    {
        Random random= new Random();
        int promptNmbr = random.Next(1, _prompts.Count);

        string prompt = _prompts[promptNmbr];

        Console.WriteLine(prompt);
    }

    public List<string> GetListFromUser()
    {
        string answer = "";
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            getRandomPrompt();
            answer = Console.ReadLine();
            _answers.Add(answer);
        }
        
        Console.WriteLine($"You have inputed {_answers.Count} answers");

        return _answers;
    }

    public void Run()
    {
        DisplayStartingMessage();

        showCountDown();
        Console.WriteLine("START");

        _count = GetListFromUser().Count;

        DisplayEndingMessage();
        showSpinner();
    }
}