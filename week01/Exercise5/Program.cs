using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        int favorite = PromptUserNumber();
        int number = favorite;
        int squareN = SquareNumber(number);
        DisplayResult(name, number, squareN);
        

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }
        static int SquareNumber(int number)
        {
            int result = number * number;
            return result;
        }
        static void DisplayResult(string userName, int numb, int square)
        {
            Console.WriteLine($"{userName} the square of your number ({numb}) is {square}");
        }
    }
}