using System;
using System.Windows.Forms;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Press Enter to restart, or 0 to exit.");
            var input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("Exiting program.");
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Restarting...");
                Application.Restart();
                break;
            }
        }
    }
}