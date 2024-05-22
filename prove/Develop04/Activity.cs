public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.Write("Get ready...");
        Console.WriteLine("");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have finished a sesion of {_duration} seconds of the {_name}");
    }
    public void showSpinner()
    {
        List<string> spinnerList = new List<string>();
        spinnerList.Add("|");
        spinnerList.Add("/");
        spinnerList.Add("-");
        spinnerList.Add("\\");
        spinnerList.Add("/");
        spinnerList.Add("-");
        spinnerList.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(5);

        int i = 0;
       
        Console.WriteLine(" ");

        while (DateTime.Now < finishTime)
        {
            string sprite = spinnerList[i];
            Console.Write(sprite);
            
            
            Thread.Sleep(300);
            Console.Write("\b \b"); // Erase the + character

            i++;

            if (i >= spinnerList.Count)
            {
                i = 0;
            }
        }
    }
    public void showCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}