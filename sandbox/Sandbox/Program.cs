using System;
using static System.Console;

class Program
{
    public void MainMenu()
    {
        while(true)
        {
            //create instance of UserInfo here. move from Logging In file.

            //Create List of info for all functions.

            //main menu.
            Clear();
            WriteLine("Main Menu");
            WriteLine("  1. Account Details");
            WriteLine("  2. Second Activity");
            WriteLine("  0. Quit");
            string userchoice = ReadLine();

            //Account Details option
            if(userchoice == "1")
            {
                AccountDetails accountdetails = new AccountDetails();
                accountdetails.AccountDetailsMenu();
            }
            //Second Activity Option
            else if (userchoice == "2")
            {
                WriteLine("You are now doing the second activity");
                Thread.Sleep(3000);
            }
            //Quit the program
            else if (userchoice == "0")
            {
                WriteLine("See you next time");
                break;
            }
            //Error message
            else
            {
                WriteLine("Sorry I don't understand that");
            }
        }
    }

    static void Main(string[] args)
    {
        LoggingInClass login = new LoggingInClass();
        login.FirstMenu();
    }

    //public List<string> LoggingIn(string LogInAccountNumber)
    //{
    //    string filePath = Path.Combine(Environment.CurrentDirectory, LogInAccountNumber);
    //    List<string> accountInfo = new List<string>();
    //    string [] lines = File.ReadAllLines(filePath);
    //    accountInfo.Add(lines[0].Split('|')[0]);
    //    accountInfo.Add(lines[0].Split('|')[1]);
    //    accountInfo.Add(lines[1].Split('|')[0]);
    //    accountInfo.Add(lines[1].Split('|')[1]);
    //    return accountInfo;
    //}
}