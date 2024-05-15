using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        

        string userInput = "";

        while (userInput != "quit")
        {

            Console.WriteLine(reference.GetDisplayVerse());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.ReadLine();

            while (scripture.IsCompletelyHidden() == false)
            {

                scripture.HideRandomWords();

                Console.WriteLine(reference.GetDisplayVerse());
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden() == true)
                {
                    Console.WriteLine("hiddenExit");
                    Environment.Exit(0);
                }

                userInput = Console.ReadLine();
                userInput = userInput.ToLower();

                if (userInput == "quit")
                {
                    Console.WriteLine("quit");
                    break;
                }
                
            }

            
        }
        
        
        Console.ReadLine();
    }
}