using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);

        int guess = 0;

        int count = 0; // initialize count to zero.


        while (guess != randomNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            count += 1; // Increment count by one every iteration.

            if (guess > randomNumber) //Compare guess to randomNumber.
            {
                Console.WriteLine("guess lower!");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("guess higher!");
            }
            else
            {
                Console.WriteLine("Your guess is correct.");
            }
        }
        Console.WriteLine($"You guessed {count} time(s).");

    }
}