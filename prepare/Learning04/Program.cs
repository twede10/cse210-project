using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("GoodGameGuppyJr");
        assignment1.SetTopic("Coding");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment();
        math1.SetStudentName("GoodGameGuppyJr");
        math1.SetTopic("Math");
        math1.SetTextbookSection("4.2");
        math1.SetProblems("2-26 even");
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment();
        writing1.SetStudentName("GoodGameGuppyJr");
        writing1.SetTopic("English");
        writing1.SetTitle("Coding");
        Console.WriteLine(writing1.GetWritingInformation());
    }
}