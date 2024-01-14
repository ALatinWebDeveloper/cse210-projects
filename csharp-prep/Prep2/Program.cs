using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradeString = Console.ReadLine();
        int gradeNumber = int.Parse(gradeString);

        string letter = "";

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >=80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "C";
        }
        else if (gradeNumber <= 50)
        {
            letter = "D";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course.");
        }
        else if (gradeNumber < 70)
        {
            Console.WriteLine("Unfortunately, you have failed the course. Do not worry! You can try again next year.");
        }
    }
}