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

                // Get a new prompt and display it
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);

                // Get the user's response text
                string response = Console.ReadLine();

                // Get the current date and save it as a string.
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                // Create the entry object
                Entry theEntry = new Entry();
                theEntry._date = date;
                theEntry._prompt = prompt;
                theEntry._text = response;

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
                Console.Write("What is the name of the file.? ");
                string file = Console.ReadLine();

                theJournal.Load(file);

            }
            else if (choice == "4")
            {
                //Save
                Console.Write("What is the name of the file.? ");
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
        Console.WriteLine("1. Write.");
        Console.WriteLine("2. Display.");
        Console.WriteLine("3. Load.");
        Console.WriteLine("4. Save.");
        Console.WriteLine("5. Quit.");
    }
}