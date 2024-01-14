using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The magic number is a number between 1 to 100");
        Console.WriteLine("You have to guess it!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber = 0;
        do 
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);

            if (guessNumber == magicNumber)
            {
                Console.WriteLine("Congratulations! You have guessed the magic number.");
            }
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        } while (guessNumber != magicNumber);
        
    }
}