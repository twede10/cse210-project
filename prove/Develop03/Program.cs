using System;

class Program
{
    static void Main(string[] args)
    {
        //get the book
        Console.WriteLine("Enter the book reference of the scripture you want to store (e.g. John or Proverbs):");
        string bookreferenceInput = Console.ReadLine();

        //get the chapter
        Console.WriteLine("Enter the chapter reference of the scripture you want to store (e.g. 3 or 5):");
        string referenceInput = Console.ReadLine();
        int chapterreferenceInput = int.Parse(referenceInput);

        //get the verse(s)
        Console.WriteLine("Enter the verse reference of the scripture you want to store (e.g. 5 or 5-6):");
        string versereferenceInput = Console.ReadLine();

        //get the text
        Console.WriteLine("Enter the text of the scripture:");
        string textInput = Console.ReadLine();

        //set the reference
        List<Word> words = textInput.Split(' ').Select(x => new Word(x)).ToList();
        
        //connenct the different files
        Reference reference = new Reference(bookreferenceInput, chapterreferenceInput, versereferenceInput);
        Scripture scripture = new Scripture(reference, words);

        //start the file and check if all words are hidden
        do
        {
            //reset the screen
            Console.Clear();
            scripture.Display();

            Console.WriteLine("Press enter to hide another word or type 'quit' to stop:");
            string userInput = Console.ReadLine();

            //count the words left
            int wordsLeft = scripture.CountWords();
            //Hide the correct amount of words
            if (wordsLeft >= 3)
            {
                scripture.HideWords(3);
            }
            else
            {
                scripture.HideWords(1);
            }

            //see if the user is done
            if (userInput.ToLower() == "quit")
            {
                break;
            }
        } while (!scripture.IsFullyHidden());
        
        Console.Clear();
        scripture.Display();
        Console.WriteLine("");

        Console.WriteLine("See you next time!");
    }
}