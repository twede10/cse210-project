using static System.Console;

class Library
{
    List<string> items = new List<string>();
    private string AccountNumber;
    private string userFirstName;
    private string userLastName;
    private string LibraryPassword;

    public List<string> StartLibrary(List<string> AccountData)
    {
        List<string> NewData = new List<string>();
        AccountNumber = AccountData[0];
        userFirstName = AccountData[2];
        userLastName = AccountData[3];
        string filename = AccountNumber;
        
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            if (lines.Length >= 3)
            {
                LibraryPassword = lines[2];
            }
            else
            {
                Random rnd = new Random();
                int password = rnd.Next(1000, 10000);
                LibraryPassword = password.ToString();
                using (StreamWriter sw = File.AppendText(filename))
                {
                    sw.WriteLine(LibraryPassword);
                }
            }
        }
        NewData.Add(AccountNumber);
        NewData.Add(AccountData[1]);
        NewData.Add(userFirstName);
        NewData.Add(userLastName);
        NewData.Add(LibraryPassword);

        return NewData;
    }
    public List<string> libraryMenu(List<string> AccountData)
    {
        string AccountNumber = AccountData[0];
        string LibraryPassword = AccountData[4];
        string filename = $"{AccountNumber}{LibraryPassword}0001";
        LoadFromFile(filename);
        List<string> NewData = new List<string>();


        while(true)
        {
            SaveToFile(filename);
            Clear();
            string userChoice = "";
            WriteLine("Library Menu");
            WriteLine("-----------------");
            WriteLine("  1. Add Item.");
            WriteLine("  2. Remove Item.");
            WriteLine("  3. Display Items.");
            WriteLine("  0. Quit.");
            WriteLine("-----------------");
            userChoice = ReadLine();

            if(userChoice == "1")
            {
                //Add Item To list.
                string Item = Additem();
                items.Add(Item);
            }
            else if (userChoice == "2")
            {
                //Remove Item From list.
            }
            else if (userChoice == "3")
            {
                Clear();
                int index = 1;
                foreach(string item in items)
                {
                    string[] parts = item.Split("|");
                    string type = parts[0];
                    string title = parts[1];
                    string author = parts[2];
                    string other = parts[3];
                    if (type == "DVD")
                    {
                        WriteLine($"[{index}] Type: {type}, Title: {title}, Author: {author}, Length: {other}");
                    }
                    else if (type == "Book")
                    {
                        WriteLine($"[{index}] Type: {type}, Title: {title}, Author: {author}, Number of Pages: {other}");
                    }
                    else if (type == "Magazine")
                    {
                        WriteLine($"[{index}] Type: {type}, Title: {title}, Author: {author}, Issue Number: {other}");
                    }
                    index += 1;
                }
                WriteLine("Press enter when done.");
                ReadLine();
            }
            else if (userChoice == "0")
            {
                break;
            }
            else
            {
                WriteLine("Sorry I don't understand that input. Please try again.");
            }
        }
        
        NewData.Add(AccountNumber);
        NewData.Add(AccountData[1]);
        NewData.Add(userFirstName);
        NewData.Add(userLastName);
        NewData.Add(LibraryPassword);
        return NewData;
    }
    private string Additem()
    {
        string Item;
        string userChoice;
        while(true)
        {
            Clear();
            WriteLine("What type of item is this:");
            WriteLine("  1. DVD.");
            WriteLine("  2. Book.");
            WriteLine("  3. Magazine.");
            userChoice = ReadLine();

            if (userChoice == "1")
            {
                string Type = "DVD";
                WriteLine("What is the Title of the DVD?");
                string Title = ReadLine();
                WriteLine("Who is the Author of the Movie?");
                string Author = ReadLine();
                WriteLine("How long is the move in minutes?");
                string Time = ReadLine();
                Item = $"{Type}|{Title}|{Author}|{Time}";
                return Item;
            }
            else if (userChoice == "2")
            {
                string Type = "Book";
                WriteLine("What is the Title of the Book?");
                string Title = ReadLine();
                WriteLine("Who is the Author of the Book?");
                string Author = ReadLine();
                WriteLine("How many pages are there in the Book?");
                string PageCount = ReadLine();
                Item = $"{Type}|{Title}|{Author}|{PageCount}";
                return Item;
            }
            else if (userChoice == "3")
            {
                string Type = "Magazine";
                WriteLine("What is the Title of the Magazine?");
                string Title = ReadLine();
                WriteLine("Who is the Author of the Magazine?");
                string Author = ReadLine();
                WriteLine("What is the issue number of the Magazine?");
                string issueNumber = ReadLine();
                Item = $"{Type}|{Title}|{Author}|{issueNumber}";
                return Item;
            }
        }
    }
    private void RemoveItem()
    {

    }
    private void SaveToFile(string fileName)
    {

    }
    private void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            File.Create(fileName);
        }

        foreach (string item in items)
        {
            if (IsDVD(item))
            {
                //Process DVD item
            }
            else if (IsBook(item))
            {
                //Process book Item
            }
            else if (IsMagazine(item))
            {
                //Process Magazine Item
            }
        }
    }

    private bool IsDVD(string item)
    {
        return false;
    }
    private bool IsBook(string item)
    {
        return false;
    }
    private bool IsMagazine(string item)
    {
        return false;
    }
}