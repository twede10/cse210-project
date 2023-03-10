using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        int TotalPoints = 0;
        WriteLine("Welcome to the Eternal Quest Program.");

        while(true)
        {
            Clear();
            WriteLine("-------------------------");
            WriteLine("       Menu Options");
            WriteLine(TotalPoints);
            WriteLine("-------------------------");
            WriteLine("  1. Create New Goal.");
            WriteLine("  2. List Goals");
            WriteLine("  3. Save Goals");
            WriteLine("  4. Load Goals");
            WriteLine("  5. Record Event");
            WriteLine("  0. Quit");
            WriteLine("-------------------------");
            Write("Select a choice form the menu: ");
            string UserChoice = ReadLine();

            if (UserChoice == "1")
            {
                Clear();
                WriteLine("-------------------------");
                WriteLine(" The types of Goals are:");
                WriteLine("-------------------------");
                WriteLine("  1. Simple Goal.");
                WriteLine("  2. Eternal Goal.");
                WriteLine("  3. Checklist Goal.");
                WriteLine("  0. Back.");
                WriteLine("-------------------------");
                Write("Which type of goal would you like to create: ");
                string GoalType = ReadLine();

                if (GoalType == "1")
                {
                    WriteLine("Creating a Simple goal.");
                    Thread.Sleep(3000);
                }
                if (GoalType == "2")
                {
                    WriteLine("Creating an Eternal goal.");
                    Thread.Sleep(3000);
                }
                if (GoalType == "3")
                {
                    WriteLine("Creating a Checklist goal.");
                    Thread.Sleep(3000);
                }
                if (GoalType == "0")
                {

                }
            }
            else if (UserChoice == "2")
            {
                WriteLine("Listing Goals.");
                Thread.Sleep(3000);
            }
            else if (UserChoice == "3")
            {
                WriteLine("Saving Goals to a file.");
                Thread.Sleep(3000);
            }
            else if (UserChoice == "4")
            {
                WriteLine("Loading Goals from a file.");
                Thread.Sleep(3000);
            }
            else if (UserChoice == "5")
            {
                WriteLine("Recording an event.");
                Thread.Sleep(3000);
            }
            else if (UserChoice == "0")
            {
                break;
            }
            else
            {
                WriteLine("Sorry I don't understand that. Please try again.");
                Thread.Sleep(3000);
            }
        }
    }
}