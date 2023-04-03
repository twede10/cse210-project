using System;
using static System.Console;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            WriteLine("This program will restart when you press enter. press 0 to quit");
            string UserInput = ReadLine();

            if (UserInput == "0")
            {
                break;
            }
            else if (UserInput == "")
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "C:\\Users\\Connor Twede\\OneDrive\\Desktop\\BYUI\\Procraming with Classes CSE210\\Github repository\\cse210-project\\sandbox\\Sandbox\\Program.cs";

                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();
                break;
            }
        }
    }
}