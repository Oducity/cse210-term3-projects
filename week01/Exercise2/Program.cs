using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your grade percent: ");
        string number = Console.ReadLine();
        float score = float.Parse(number);
        if (score >= 70)
        {
            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            Console.WriteLine("Congratulations! You made it.");
        }
        else
        {
            if (score >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: E");
            }
            Console.WriteLine("Haven't come this far, with little more effort, You're going to make it. Keep trying.");
        }

    }
}