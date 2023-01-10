using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        int Continue = 0;
        while (Continue != 1)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            int guessAmount = 0;
            int Correct = 0;
            while (Correct != 1)
            {
                Console.Write("Enter your guess: ");
                string guessInput = Console.ReadLine();
                int guess = int.Parse(guessInput);
                guessAmount += 1;


                if (guess > number)
                {
                    Console.WriteLine("The Number is LESS than your Guess.");
                }
                else if (guess == number)
                {
                    Console.WriteLine("That is the Correct Number!");
                    Console.WriteLine($"It took you {guessAmount} guesses.");
                    Correct = 1;
                }
                else if (guess < number)
                {
                    Console.WriteLine("The Number is Greater than your Guess.");
                }
            }
            Console.Write("Would you like to play again? Please type in all lower case. ");
            
            int deciding = 0;
            while (deciding != 1)
            {
                string ContinueInput = Console.ReadLine();
                
                if (ContinueInput == "yes")
                {
                    Continue = 0;
                    deciding = 1;
                }
                else if (ContinueInput == "no")
                {
                    Continue = 1;
                    deciding = 1;
                }
                else
                {
                    Console.WriteLine("Sorry, I don't understand. Make sure to write in all lower case. ex(yes/no)");
                    deciding = 0;
                }
            }
        }
        
    }
}