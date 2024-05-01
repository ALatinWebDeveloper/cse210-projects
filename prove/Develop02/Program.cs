using System;
using System.IO;
using System.IO.Enumeration;

class Program
{

    /*
    Made it possible to save and load in and from an csv file
    The program reviews if the program name ends with .cvs
    A foreach loop starts separating each item with a coma and
    stores each item in different variable, then prints each item.
    */
    static void Main(string[] args)
    {
        string menu = @"
        Welcome to your Journal!
        You can do several things, like:
        1. Write a new entry.
        2. Display all your entries from today in to a file.
        3. Save today's entries.
        4. Load all your entries from a file.
        5. Quit.

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
            else
            {
                choice = 0;
                Console.WriteLine("You have chosed an invalid option. Please try again.");
            }
        } while(choice != 5);

        Console.WriteLine("out");
        
    }
}