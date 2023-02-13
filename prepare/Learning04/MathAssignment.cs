using System;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public string GetTextbookSection()
    {
        return _textbookSection;
    }

    public void SetTextbookSection(string section)
    {
        _textbookSection = section;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problem)
    {
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}. Section {_textbookSection} Problems {_problems}.";
    }
}