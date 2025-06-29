using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your grade percent: ");
        string number = Console.ReadLine();
        float score = float.Parse(number);

        string letter = "";

        if (score >= 70)
        {
            if (score >= 95)
            {
                letter = "A+";
            }
            else if (score >= 90)
            {
                letter = "A";
            }
            else if (score >= 80)
            {
                letter = "B";
            }
            else if (score >= 70)
            {
                letter = "C";
            }

            Console.WriteLine("Congratulations! You made it.");
        }
        else
        {
            if (score >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "E";
            }

            Console.WriteLine("Haven't come this far, with little more effort, You're going to make it. Keep trying.");
        }

        Console.WriteLine($"Grade: {letter}");

    }
}