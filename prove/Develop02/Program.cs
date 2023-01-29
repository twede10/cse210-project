using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Prompts generator = new Prompts();

        Console.WriteLine("Welcome to the Journal Program");

    string choice = "";
    while (choice != "5")
        {
            DisplayMenu();
            Console.WriteLine();
            choice = Console.ReadLine();

            if (choice == "1")
            {
                //Write
                Console.WriteLine("Writing a new entry.");

                //get entry index
                Console.WriteLine("What entry number is this?");
                string entryNumber = Console.ReadLine();

                // Get a new prompt and display it
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);

                // Get the user's response text
                string response = Console.ReadLine();

                // Create a title for the entry
                Console.WriteLine("Add a title.");
                string title = Console.ReadLine();

                // Get the current date and save it as a string.
                string date = DateTime.Now.ToString("yyy-MM-dd");

                // Create the entry object
                Entry theEntry = new Entry();
                theEntry._date = date;
                theEntry._prompt = prompt;
                theEntry._text = response;
                theEntry._title = title;
                theEntry._index = entryNumber;

                // Add it to the journal
                theJournal.AddEntry(theEntry);
            }
            else if (choice == "2")
            {
                //Display
                Console.WriteLine("Displaying the journal.");
                theJournal.Display();

            }
            else if (choice == "3")
            {
                //Load
                Console.Write("What is the name of the file? ");
                string file = Console.ReadLine();

                theJournal.Load(file);
                Console.WriteLine($"journal entries loaded from {file}");

            }
            else if (choice == "4")
            {
                //Save
                Console.Write("What is the name of the file? ");
                string file = Console.ReadLine();

                theJournal.Save(file);
                Console.WriteLine($"journal entries saved to {file}");
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("Menu Options.");
        Console.WriteLine("1. Write a new entry.");
        Console.WriteLine("2. Display all your entries.");
        Console.WriteLine("3. Load entries from a file.");
        Console.WriteLine("4. Save entries to a file.");
        Console.WriteLine("5. Quit the program.");
    }
}