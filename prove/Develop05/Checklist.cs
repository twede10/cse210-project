using System;
using System.Collections.Generic;
using static System.Console;

class Checklist : Goals
(
    private List<string> _items = new List<string>();

    // Constructor
    public ChecklistGoals(string goalTitle, string goalDescription, int goalPoints)
    {
        SetGoalType("Checklist");
        SetGoalTitle(goalTitle);
        SetGoalDescription(goalDescription);
        SetGoalPoints(goalPoints);
    }

    // Functions
    public void AddItem(string item)
    {
        _items.Add(item);
    }

    public void RemoveItem(string item)
    {
        _items.Remove(item);
    }

    public override void SaveGoal()
    {
        // Save goal to file
    }

    public void SaveAllChecklistGoals()
    {
        // Save all checklist goals to file
    }

    public void LoadChecklistGoals()
    {
        // Load checklist goals from file
    }

    public void RecordEvent()
    {
        // Record event for checklist goal
    }
)