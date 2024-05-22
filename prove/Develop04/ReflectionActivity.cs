using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectionActivity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("");
        showCountDown();
        Console.WriteLine("");
        Console.WriteLine("START");
        Console.WriteLine("");

        getRandomPrompt();

        Console.WriteLine("Press ENTER to continue.");
        Console.ReadLine();
        Console.WriteLine("");
        
        Console.WriteLine("Anser the following questions related to this experience");
        Console.WriteLine("You will start in: ");
        showCountDown();
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < finishTime)
        {

            getRandomQuestion();
            showSpinner();

        }

        DisplayEndingMessage();
        showSpinner();
        Console.WriteLine("");
    }

    public void getRandomPrompt()
    {
        Random random= new Random();
        int promptNmbr = random.Next(1, _prompts.Count);

        string prompt = _prompts[promptNmbr];

        Console.WriteLine(prompt);
    }

    public void getRandomQuestion()
    {
        Random random= new Random();
        int questionNmbr = random.Next(1, _questions.Count);

        string question = _questions[questionNmbr];

        Console.WriteLine(question);
    }
}