using System;
using static System.Console;

class Login
{
    string AccountNumber;
    List<string> NewData = new List<string>();
    public List<string> LoginMenu(List<string> AccountData)
    {
        Clear();

        WriteLine("Welcome to my program! Please Login to your account or create a new one.");
        while(true)
        {
            WriteLine(" 1. Create Account");
            WriteLine(" 2. Login to Account");
            string UserChoice = ReadLine();

            LoggingIn loggingin = new LoggingIn();
            if (UserChoice == "1")
            {
                //Have the user create an account.
                loggingin.CreateAccount();
                break;
            }
            else if (UserChoice == "2")
            {
                //Have the user Log in to their account.
                loggingin.loginToAccount();
                break;
            }
            else
            {
                //Have the user re enter their choice.
                WriteLine("Sorry I don't Understand that. Please try again.");
            }
        }

        return NewData;
    }
}