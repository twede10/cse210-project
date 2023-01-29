public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Entry: {entry._text}");
            Console.WriteLine();
        }
    }

    public void Save(string file)
    {
        // save all the entries out to the file.
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string line = $"{entry._index}|{entry._date}|{entry._title}|{entry._prompt}|{entry._text}";
                sw.WriteLine(line);
            }
        
        }
    }

    public void Load(string file)
    {
        // Load all the entries from the file.
        try{
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");
                    Entry entry = new Entry();
                    entry._index = parts[0];
                    entry._date = parts[1];
                    entry._title = parts[2];
                    entry._prompt = parts[3];
                    entry._entry = parts[4];
                    entries.Add(entry);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }

    public void AddEntry(Entry entry)
    {
        // Adds this entry to the list.
        _entries.Add(entry);
    }
}