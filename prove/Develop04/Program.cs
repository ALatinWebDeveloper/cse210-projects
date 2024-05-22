using System;

class Program
{
    static void Main(string[] args)
    {
        
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

            option = "2";
            int seconds;

            switch (option)
            {
                
                case "1":

                    Console.WriteLine("You have chosen the Breathing Activity");
                    Console.WriteLine("How long IN SECONDS would you like this sesion to last?");

                    seconds = int.Parse(Console.ReadLine());
                    
                    BreathingActivity breath = new BreathingActivity("Breathing Activity", "This activity will help you relax with a breating exercise. Clear your mind and focus on your breathing...", seconds);

                    breath.Run();

                    break;

                case "2":
                    Console.WriteLine("You have chosen the Reflection Activity");
                    Console.WriteLine("");
                    Console.WriteLine("How long IN SECONDS would you like this sesion to last?");

                    seconds = int.Parse(Console.ReadLine());

                    ReflectionActivity reflection = new ReflectionActivity("Reflection Activity", "This activity will make you reflect on those time when you have shown outstanding strength and resilence. Recognize your power and capability, use it in other aspects in your life", seconds);
                    
                    reflection.Run();
                    break;

                case "3":

                    Console.WriteLine("Starting the Listing Activity");
                    Console.WriteLine("");
                    Console.WriteLine("How long IN SECONDS would you like this sesion to last?");

                    seconds = int.Parse(Console.ReadLine());
                    
                    ListingActivity Listing = new ListingActivity("Listing Activity", "This activity will remember you of those thing in your life worth fighting for. List as many as you can, if it matters for you... then that is enough...", seconds);

                    Listing.Run();

                    break;

                case "4":
                    Console.WriteLine("Goo Bye");
                    break;

                default:
                Console.WriteLine("Please input a valid number");
                break;
            }
            
        } while (option != "4");
        
        
    }
}