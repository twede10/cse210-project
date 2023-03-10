using System;
using static System.Console;

class LoggingInClass
{
    public void FirstMenu()
    {
        while(true)
        {
            Clear();
            //see if user is returning or brand new.
            WriteLine("1. Returning user");
            WriteLine("2. New User");
            string returningUserOrNewUser = ReadLine();

            if (returningUserOrNewUser == "1")
            {
                //Have the user Log in to their account.
                LogIn();
                break;
            }
            else if (returningUserOrNewUser == "2")
            {
                //Have the user create an account.
                CreateAccount();
                break;
            }
            else
            {
                WriteLine("Sorry I Don't understand that.");
                Thread.Sleep(3000);
            }
        }
        Program program = new Program();
        program.MainMenu();
    }

    public void CreateAccount()
    {
        Clear();
        Write("What do you want your account number to be(ex: 1234): ");
        string CreateAccountNumber = ReadLine();
        Write("What is the password to your account: ");
        string CreateAccountPassword = ReadLine();
        Write("What is your first name: ");
        string usernameFirst = ReadLine();
        Write("What is your last name: ");
        string usernameLast = ReadLine();

        using (StreamWriter sw = new StreamWriter(CreateAccountNumber))
        {
            string line1 = $"{CreateAccountNumber}|{CreateAccountPassword}|{usernameFirst}|{usernameLast}";
            sw.WriteLine(line1);
        }
        WriteLine("Account successfully created.");
        Thread.Sleep(3000);
    }

    public List<string> LoggingIn(string LogInAccountNumber)
    {
        string filePath = Path.Combine(Environment.CurrentDirectory, LogInAccountNumber);
        List<string> accountInfo = new List<string>();
        string [] lines = File.ReadAllLines(filePath);
        accountInfo.Add(lines[0].Split('|')[0]);
        accountInfo.Add(lines[0].Split('|')[1]);
        accountInfo.Add(lines[1].Split('|')[0]);
        accountInfo.Add(lines[1].Split('|')[0]);
        return accountInfo;
    }    

    public void LogIn()
    {
        while(true)
        {
            Clear();
            //ask the user for their username and password.
            Write("Account Number: ");
            string LogInAccountNumber = ReadLine();
            Write("Password: ");
            string LogInAccountPassword = ReadLine();

            //Check to see if it matches any files.
            if (CheckAccount(LogInAccountNumber, LogInAccountPassword, Environment.CurrentDirectory))
            {
                WriteLine("Logging in...");

                List<string> AccountInfo = LoggingIn(LogInAccountNumber);
                UserInfo userinfo = new UserInfo();
                userinfo.SetFirstName(AccountInfo[2]);
                userinfo.SetLastName(AccountInfo[3]);

                string firstName = userinfo.GetFirstName();
                string lastName = userinfo.GetLastName();
                WriteLine("Login successful.");
                Thread.Sleep(1000);
                WriteLine($"Welcome back {firstName} {lastName}");
                Thread.Sleep(3000);
                break;
            }
            else{
                WriteLine("Invalid Account Number or Password.");
                Thread.Sleep(3000);
            }
        }
    }

    static bool CheckAccount(string username, string password, string directoryPath)
    {
        foreach (string filePath in Directory.GetFiles(directoryPath))
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0 && lines[0] == $"{username}|{password}")
            {
                return true;
            }
        }
    return false;
    }
}