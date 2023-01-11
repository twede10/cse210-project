using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        //User Adds numbers.
        int Continue = 0;
        while (Continue != 1)
        {
            Console.Write("Enter number: ");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);
            if (number == 0)
            {
                Continue = 1;
            }
            else
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        float average = 0;
        int largest = 0;

        //Calculating the sum.
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Calculating the average.
        average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average,0:0.00000}");

        //Calculating the largest number.
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
            else
            {

            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}