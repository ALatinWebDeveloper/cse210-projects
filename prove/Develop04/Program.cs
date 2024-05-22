using System;

class Program
{
    static void Main(string[] args)
    {
        int activitynbr = 0;
        
        string option = "";
        Activity actividad = new Activity();

        do
        {
            Console.Clear();
            Console.WriteLine(@"
            Please chose an activity by it's number:
            1. Breathing Activity.
            2. Reflection Activity.
            3. Listing Activity.
            4. Quit.
            ");

            option = Console.ReadLine();
            int seconds;

            switch (option)
            {
                
                case "1":

                    Console.WriteLine("You have chosen the Breathing Activity");
                    Console.WriteLine("How long IN SECONDS would you like this sesion to last?");

                    seconds = int.Parse(Console.ReadLine());
                    
                    BreathingActivity breath = new BreathingActivity("Breathing Activity", "This activity will help you relax with a breating exercise. Clear your mind and focus on your breathing...", seconds);

                    breath.Run();

                    activitynbr ++;

                    break;

                case "2":
                    Console.WriteLine("You have chosen the Reflection Activity");
                    Console.WriteLine("");
                    Console.WriteLine("How long IN SECONDS would you like this sesion to last?");

                    seconds = int.Parse(Console.ReadLine());

                    ReflectionActivity reflection = new ReflectionActivity("Reflection Activity", "This activity will make you reflect on those time when you have shown outstanding strength and resilence. Recognize your power and capability, use it in other aspects in your life", seconds);
                    
                    reflection.Run();

                    activitynbr ++;

                    break;

                case "3":

                    Console.WriteLine("Starting the Listing Activity");
                    Console.WriteLine("");
                    Console.WriteLine("How long IN SECONDS would you like this sesion to last?");

                    seconds = int.Parse(Console.ReadLine());
                    
                    ListingActivity Listing = new ListingActivity("Listing Activity", "This activity will remember you of those thing in your life worth fighting for. List as many as you can, if it matters for you... then that is enough...", seconds);

                    Listing.Run();

                    activitynbr ++;

                    break;

                case "4":
                    Console.WriteLine($"You have completed {activitynbr} activities.");
                    Console.WriteLine("Good Bye");
                    break;

                default:
                    Console.WriteLine("Please input a valid number");
                break;
            }

            if ((option == "1") && (option == "2" ) && (option == "3") && (option == "4"))
            {
                Console.WriteLine("Please input a valid number :c");
            }
            
        } while (option != "4");
        
        
    }
}