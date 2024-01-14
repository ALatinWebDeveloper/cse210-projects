using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        int number = 0;
        int total = 0;
        int larger = 0;
        List<int> numbers = new List<int>();
        do {
            Console.WriteLine("Input a number, I will stop asking when you input a '0'");
            string element = Console.ReadLine();
            number = int.Parse(element);


            if (number != 0)
            {
                numbers.Add(number);
            }

            if (larger < number)
            {
                larger = number;
            }

        } while (number != 0);
        
        foreach (int item in numbers)
        {
            total = item + total;
        }

        int size = numbers.Count;
        int average = total / size;
        
        Console.WriteLine($"The total is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The larger number is {larger}");
    }
}