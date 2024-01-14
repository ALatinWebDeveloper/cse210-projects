using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string number = Console.ReadLine();
        int favoriteNumber = int.Parse(number);
        return favoriteNumber;
    }
    static int SquareNumber(int favoriteNumber)
    {
        favoriteNumber = favoriteNumber * favoriteNumber;
        return favoriteNumber;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"The user's name is {name} and the square of your number is {number}");
    }
}