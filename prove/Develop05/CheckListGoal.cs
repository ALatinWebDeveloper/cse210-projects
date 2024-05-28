using System;

public class CheckListGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int amountComplete, int target, int bonus) : base(name, description, points)
    {
        _amountComplete = amountComplete;
        _target = target;
        _bonus = bonus;
    }

    public int GetAmountComplete()
    {
        return _amountComplete;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override bool IsComplete()
    {
        bool state = false;
        if (_amountComplete >= _target)
        {
            state = true;
        }
        else{
            state = false;
        }
        return state;
    }

    public override void RecordEvent()
    {
        _amountComplete += 1;
        Console.WriteLine("a" + _amountComplete);
        Console.ReadKey();
    }
}