using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> AccountData = new List<string>();
        List<string> NewData = new List<string>();

        Login login = new Login();
        NewData = login.LoginMenu(AccountData);
        MainMenuclass menu = new MainMenuclass();
        NewData = menu.MainMenu(AccountData);
        
    }
}