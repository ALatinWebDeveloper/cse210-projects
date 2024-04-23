using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradeString = Console.ReadLine();
        int gradeNumber = int.Parse(gradeString);

        string grade = "";

        if (gradeNumber >= 90)
        {
            grade = "A";
        }
        else if (gradeNumber >=80)
        {   
            grade = "B";
        }
        else if (gradeNumber >= 70)
        {
            grade = "C";
        }
        else if (gradeNumber >= 60)
        {
            grade = "C";
        }
        else if (gradeNumber <= 50)
        {
            grade = "D";
        }

        Console.WriteLine($"Your grade is {grade}");

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