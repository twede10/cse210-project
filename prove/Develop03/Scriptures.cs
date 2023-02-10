using System;

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, List<Word> words)
    {
        this.reference = reference;
        this.words = words;
    }

    public Reference Reference
    {
        get
        {
            return reference;
        }
    }

    public bool IsFullyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.Hidden)
            {
                return false;
            }
        }
        return true;
    }

    public void HideWords(int count)
    {
        Random rnd = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rnd.Next(0, words.Count);
            while (words[index].Hidden == true)
            {
                index = rnd.Next(0, words.Count);
            }
            words[index].Hidden = true;
        }
    }

    public int CountWords()
    {
        int totalWords = 0;
        foreach (Word word in words)
        {
            if (word.Hidden)
            {
                totalWords += 0;
            }
            else
            {
                totalWords += 1;
            }
        }
        return totalWords;
    }

    public void Display()
    {
        Console.WriteLine(Reference);
        foreach (Word word in words)
        {
            if (word.Hidden)
            {
                Console.Write("_ ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
    }
}