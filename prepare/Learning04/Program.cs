using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Assignment tarea = new Assignment("Juan", "programar");
        Console.WriteLine(tarea.GetSummary());
        Console.WriteLine();

        MathAssignment math = new MathAssignment("Section 9", "Problems 1-4", "Juan", "programar");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Sun Tzu", "No-Fiction", "Art of War");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
        Console.WriteLine();
    }
}