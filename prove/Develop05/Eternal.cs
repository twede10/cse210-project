using System;
using static System.Console;

class Eternal : Goals
{
    private DateTime _StartDate;
    private DateTime _EndDate;

    public Eternal(string title, string description, int points, DateTime startDate, DateTime endDate)
    {
        SetGoalTitle(title);
        SetGoalDescription(description);
        SetGoalPoints(points);

        _StartDate = startDate;
        _EndDate = endDate;
    }

    public override void SaveGoal()
    {
        
    }
}