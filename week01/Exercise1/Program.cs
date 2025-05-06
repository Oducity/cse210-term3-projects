using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        // Asked for the user's first name.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        // Asked for user's last name.
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        // Print user's last name, full name to the terminal.
        Console.WriteLine($"{lastName}, {firstName} {lastName}");
    }
}