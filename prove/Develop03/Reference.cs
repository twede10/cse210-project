using System;

class Reference
{
    private string book;
    private int chapter;
    private string startVerse;
    private string endverse;
    public Reference(string book, int chapter, string verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = verse;
        this.endverse = verse;
    }

    public Reference(string book, int chapter, string startVerse, string endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endverse = endVerse;
    }

    public string Book
    {
        get
        {
            return book;
        }
    }

    public int Chapter
    {
        get
        {
            return chapter;
        }
    }

    public string StartVerse
    {
        get
        {
            return startVerse;
        }
    }
    public string EndVerse
    {
        get
        {
            return endverse;
        }
    }

    public override string ToString()
    {
        if (startVerse == endverse)
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
        else
        {
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }
}