using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        int number = -1;//initialize number to negative one
        int sum = 0;//initializes sum to zero.
        int numberOfItems = 0;
        int maximumNumber = 0;
        List<int> numbers = new List<int>();
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            else
            {

                numberOfItems += 1;
                numbers.Add(number);
                //Console.WriteLine(numbers);
                foreach (int item in numbers)
                {
                    Console.WriteLine(item);
                }
                if (number > maximumNumber)
                    maximumNumber = number;
            }
        }
        foreach (int items in numbers)
        {
            sum += items;
        }
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {sum / numberOfItems}");
        Console.WriteLine($"Largest Number: {maximumNumber}");
    }
}