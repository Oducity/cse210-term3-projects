using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your grade percent: ");
        string number = Console.ReadLine();
        float score = float.Parse(number);

        if (score >= 90)
        {
            Console.WriteLine("A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("C");
        }
        else if (score >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("E");
        }
    }
}