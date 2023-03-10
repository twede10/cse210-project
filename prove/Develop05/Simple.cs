using System;
using static System.Console;

class Simple : Goals
{
    public Simple(string goalTitle, string goalDescription, int goalPoints)
    {
        SetGoalType("Simple");
        SetGoalTitle(goalTitle);
        SetGoalDescription(goalDescription);
        SetGoalPoints(goalPoints);
    }

    public override void SaveGoal()
    {
        
    }
}