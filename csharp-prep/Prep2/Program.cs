using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade%: ");
        string gradeString = Console.ReadLine();

        int gradePercent = int.Parse(gradeString);
        string gradeLetter;
        if (gradePercent == 90 || gradePercent > 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercent == 80 || gradePercent > 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercent == 70 || gradePercent > 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercent == 60 || gradePercent > 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        string note;
        if (gradePercent == 70 || gradePercent >70)
        {
            note = "Congradulations on passing the class!";
        }
        else
        {
            note = "Good luck next time around.";
        }

        Console.WriteLine($"Your grade: {gradeLetter}, Note: {note}");
    }
}