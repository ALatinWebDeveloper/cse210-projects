using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        string filename = "";
        GoalManager goalManager = new GoalManager();

        do
        {
            Console.Clear();
            Console.WriteLine(@"
            Menu options:
            1. Create New Goal.
            2. List Goals.
            3. Save Goal.
            4. Load Goal.
            5. Record Event.
            6. Quit.
            ");

            option = Console.ReadLine();

            switch (option)
            {
                
                case "1":
                    
                    goalManager.CreateGoal();


                    break;

                case "2":

                    goalManager.DisplayGoals();

                    break;

                case "3":

                    Console.WriteLine("Please input the name of the file.");
                    filename = Console.ReadLine();
                    goalManager.SaveGoals(filename);

                    break;
                case "4":

                    Console.WriteLine("Please input the name of the file.");
                    filename = Console.ReadLine();
                    goalManager.LoadGoals(filename);

                    break;

                case "5":

                    goalManager.RecordEvent();

                    break;

                case "6":
                    
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please input a valid number");
                break;
            }

            if ((option == "1") && (option == "2" ) && (option == "3") && (option == "4"))
            {
                Console.WriteLine("Please input a valid number :c");
            }
            
        } while (option != "6");
    }
}