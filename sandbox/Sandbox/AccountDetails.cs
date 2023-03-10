using System;
using static System.Console;

class AccountDetails
{
    public void AccountDetailsMenu()
    {
        while(true)
        {
            Clear();
            WriteLine("Account Details");
            WriteLine("  1. View account information");
            WriteLine("  2. Change account information");
            WriteLine("  0. Back to main menu");
            string userchoice = ReadLine();

            if (userchoice == "1")
            {
                ViewAccountInformation();
            }
            else if (userchoice == "2")
            {
                ChangeAccountInformation();
            }
            else if (userchoice == "0")
            {
                break;
            }
            else
            {
                WriteLine("Sorry I don't understand that");
            }
        }
    }

    private void ViewAccountInformation()
    {
        Clear();
        WriteLine("Here is your info");
        Thread.Sleep(3000);
    }

    private void ChangeAccountInformation()
    {
        Clear();
        WriteLine("Change your info here");
        Thread.Sleep(3000);
    }
}