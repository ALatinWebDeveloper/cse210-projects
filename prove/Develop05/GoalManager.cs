using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        
    }

    public List<Goal> getGoal()
    {
        
        return _goals;
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void DisplayGoals()
    {       
        
        foreach (var goal in getGoal())
        {   
            bool goalState = goal.IsComplete();

            if (goalState != true)
            {
                if (goal is SimpleGoal SimpleGoal)
                {
                    Console.WriteLine($"Simple Goal: {SimpleGoal.GetName()} ({SimpleGoal.GetDetailsString()})");
                }
                else if(goal is EternalGoal eternalGoal)
                {   
                    Console.WriteLine($"{eternalGoal.GetType()}");
                    Console.WriteLine($"Eternal Goal: {eternalGoal.GetName()} ({eternalGoal.GetDetailsString()})");
                }
                else if(goal is CheckListGoal checkListGoal)
                {
                    Console.WriteLine($"Checklist Goal: {checkListGoal.GetName()} ({checkListGoal.GetDetailsString()}) {checkListGoal.GetAmountComplete()}/{checkListGoal.GetTarget()}");
                }
                else
                {
                    Console.WriteLine("Unknown goal type");
                }
            }
            else if(_goals.Count <= 0)
            {
                Console.WriteLine("There are no goals registered.");
                Console.ReadKey();
            }
        }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        
    }

    public void ListGoalDetails()
    {
        foreach (Goal item in _goals)
        {
            string goalDesc = item.GetDetailsString();
            Console.Write($"({goalDesc})");
        }
    }

    public void CreateGoal()
    {
        string GoalType = "";
        do
        {
            Console.WriteLine(@"
        What kind of goal would you like to add?
        1. Simple Goal
        2. Checklist Goal
        3. Eternal Goal
        ");
        GoalType = Console.ReadLine();
        } while ((GoalType != "1") && (GoalType != "2") && (GoalType != "3"));

        Console.WriteLine("What is the name of your goal?");
        string GoalName = Console.ReadLine();

        Console.WriteLine("Give me a short description of your goal");
        string Goaldescription = Console.ReadLine();

        Console.WriteLine("How many points is this goal?");
        string GoalPoints = Console.ReadLine();

        if ((GoalType == "1"))
        {
            
            _goals.Add(new SimpleGoal(GoalName, Goaldescription, GoalPoints));

        }
        else if ((GoalType == "2"))
        {

            Console.WriteLine("How many times this goal must be completed?");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for completing it?");
            int bonus = int.Parse(Console.ReadLine());

            int amountComplete = 0;

            _goals.Add(new CheckListGoal(GoalName, Goaldescription, GoalPoints, amountComplete, target, bonus));
        }
        else if ((GoalType == "3"))
        {
            
            _goals.Add(new EternalGoal(GoalName, Goaldescription, GoalPoints));
        }
        
    }

    public void RecordEvent()
    {
        DisplayGoals();

        Console.WriteLine(@"Which goal have you completed?");
        int goalIndex = int.Parse(Console.ReadLine());
        goalIndex -= 1;

        var goalToComplete = _goals[goalIndex];

        if(goalToComplete is SimpleGoal simpleGoal)
        {
            simpleGoal.RecordEvent();
            int pointsEarned = int.Parse(_goals[goalIndex].GetPoints());
            Console.WriteLine($"Congratulations, you have earned {pointsEarned} points");
            _score += pointsEarned;
            Console.WriteLine($"You have {_score} points");

            _goals.Remove(_goals[goalIndex]);
            Console.ReadKey();
            Console.WriteLine("Press any key to continue.");
        }
        else if (goalToComplete is EternalGoal eternalGoal)
        {
            eternalGoal.RecordEvent();
            int pointsEarned = int.Parse(_goals[goalIndex].GetPoints());
            Console.WriteLine($"Congratulations, you have earned {pointsEarned} points");
            _score += pointsEarned;
            Console.WriteLine($"You have {_score} points");

            _goals.Remove(_goals[goalIndex]);
            Console.ReadKey();
            Console.WriteLine("Press any key to continue.");
        }
        else if (goalToComplete is CheckListGoal checkListGoal)
        {
            bool goalState = checkListGoal.IsComplete();

            if (goalState == true)
            {
                int pointsEarned = int.Parse(_goals[goalIndex].GetPoints());
                int bonusEarned = checkListGoal.GetBonus();

                Console.WriteLine($"Congratulations you have earned {pointsEarned} points");
                Console.WriteLine($"Congratulations you have earned a bonus of {bonusEarned} points for completing the task");
                _score += pointsEarned + bonusEarned;
                Console.WriteLine($"You have {_score} points");

                _goals.Remove(_goals[goalIndex]);
                Console.ReadKey();
                Console.WriteLine("Press any key to continue.");
            }
            else
            {
                checkListGoal.RecordEvent();
                int pointsEarned = int.Parse(_goals[goalIndex].GetPoints());
                Console.WriteLine($"Congratulations you have earned {pointsEarned} points");
                _score += pointsEarned;
                Console.WriteLine($"You have {_score} points");

                Console.ReadKey();
                Console.WriteLine("Press any key to continue.");
            }
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {   
            if (filename.EndsWith(".csv"))
            {
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine($"Simple Goal: {goal.GetName()} {goal.GetDetailsString()}");
                }
            }
            else
            {
                foreach (Goal goal in _goals)
                {
                    if (goal != null)
                    {
                        if (goal is SimpleGoal SimpleGoal)
                        {
                            outputFile.WriteLine($"Simple Goal: {goal.GetName()} {goal.GetDetailsString()} {goal.GetPoints()}");
                        }
                        else if(goal is EternalGoal eternalGoal)
                        {
                            outputFile.WriteLine($"Eternal Goal: {eternalGoal.GetName()} {eternalGoal.GetDetailsString()}");
                        }
                        else if(goal is CheckListGoal checkListGoal)
                        {
                            outputFile.WriteLine($"Checklist Goal: {checkListGoal.GetName()} {checkListGoal.GetDetailsString()} {checkListGoal.GetAmountComplete()} {checkListGoal.GetTarget()} {checkListGoal.GetBonus()}");
                        }
                    }

                }
            }
        }
    }

    public void LoadGoals(string filename)
    {
        int i = 1;
        if (filename.EndsWith(".csv"))
        {
            string[] goalItem = System.IO.File.ReadAllLines(filename);
            foreach (string item in goalItem)
            {
                i += 1;
                string[] goalSection = item.Split(",");
                string goalName = goalSection[0];
                string goalDesc = goalSection[1];
                Console.WriteLine($"{i}. [] {goalName} {goalDesc}");
                Console.Write($"Prompt: {goalDesc}");
                Console.WriteLine($"---------------------------------------");
                Console.WriteLine($"Input any key to continue");
            }
        }
        else{

            using (StreamReader reader = new StreamReader(filename))
            {
                String goalItem = reader.ReadToEnd();
                Console.Write(goalItem);
                Console.WriteLine($"---------------------------------------");
                Console.WriteLine($"Input any key to continue");
                Console.ReadKey();
            }

        }
    }
}