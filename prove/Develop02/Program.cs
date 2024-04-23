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
        3. Load
        4. Save
        5. Quit

        What would you like to do?
        ";

        int choice;

        do {
            Console.WriteLine(menu);
            string choiceString = Console.ReadLine();
            choice = int.Parse(choiceString);
            Journail journail = new Journail();
            Entry newEntry = new Entry();

            if (choice == 1){

                journail.AddEntry(newEntry);
            }

            else if (choice == 2){
                
                journail.DisplayAll();

            }
            else if (choice == 3){

                Console.WriteLine("Load");

            }
            else if (choice == 4){

                Console.WriteLine("Input the name of the save file");
                string fileName = Console.ReadLine();
                journail.SaveToFile(fileName);

            }
        } while(choice != 5);
        
    }
}