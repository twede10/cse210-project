using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PrompUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }
        static int SquareNumber(int number)
        {
            int numberSquared = number * number;
            return numberSquared;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}.");
        }




        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PrompUserNumber();
        int favNumberSquared = SquareNumber(favNumber);
        DisplayResult(name, favNumberSquared);
    }
}