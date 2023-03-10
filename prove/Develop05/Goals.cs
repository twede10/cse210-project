using System;
using static System.Console;

abstract class Goals
{
    //variables
    private string _GoalType;
    private string _GoalTitle;
    private string _GoalDiscription;
    private int _GoalPoints;
    private List<string> goals = new List<string>();

    //Getters
    public string GetGoalType()
    {
        return _GoalType;
    }
    public string GetGoalTitle()
    {
        return _GoalTitle;
    }
    public string GetGoalDescription()
    {
        return _GoalDiscription;
    }
    public int GetGoalPoints()
    {
        return _GoalPoints;
    }

    //Setters
    public void SetGoalType(string input)
    {
        _GoalType = input;
    }
    public void SetGoalTitle(string input)
    {
        _GoalTitle = input;
    }
    public void SetGoalDescription(string input)
    {
        _GoalDiscription = input;
    }
    public void SetGoalPoints(int input)
    {
        _GoalPoints = input;
    }

    //Functions
    public abstract void SaveGoal();

    public void SaveAllGoals()
    {

    }

    public void LoadGoals()
    {

    }

    public void RecordEvent()
    {

    }
}