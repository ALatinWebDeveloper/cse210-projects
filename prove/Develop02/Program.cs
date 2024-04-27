using System;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        string menu = @"
        Welcome to your Journal!
        You can do several things, like:
        1. Write
        2. Display
        3. Save
        4. Load
        5. Quit

        What would you like to do?
        ";

        int choice = 0;

        Journail journail = new Journail();
        Entry newEntry = new Entry();

        do {
            
            Console.WriteLine(menu);
            string stringChoice = Console.ReadLine();
            choice = int.Parse(stringChoice);

            if (choice == 1){

                newEntry.Display();
                journail.AddEntry(newEntry);
            }

            else if (choice == 2){

                journail.DisplayAll();
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();

            }
            else if (choice == 3){

                Console.WriteLine("Please input the name of the file with its extention");
                string fileName = Console.ReadLine();
                journail.SaveToFile(fileName);

            }
            else if (choice == 4){
                
                Console.WriteLine("Please input the name of the file with its extention");
                string fileName = Console.ReadLine();
                journail.LoadFromFile(fileName);
                
            }
        } while(choice != 5);

        Console.WriteLine("out");
        
    }
}