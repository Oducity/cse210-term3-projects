using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Journal Project.");
        string _add = "";
        int menu = 0;
        while (menu != 5)
        {
            Console.WriteLine("Enter a MENU number and hit Enter button:");
            Console.WriteLine("To Write: press 1");
            Console.WriteLine("To Display: press 2");
            Console.WriteLine("To Save: press 3");
            Console.WriteLine("To Load: press 4");
            Console.WriteLine("To Quit: press 5");
            Console.Write("What do you want to do? ");
            menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {

                Entry entry1 = new Entry();
                Console.WriteLine(entry1._promptText = "What was your best experience today?");
                entry1._entryText = Console.ReadLine();
                DateTime currentDateTime1 = DateTime.Now;
                entry1._date = currentDateTime1.ToShortDateString();

                Entry entry2 = new Entry();
                Console.WriteLine(entry2._promptText = "What one thing did you learn best today?");
                entry2._entryText = Console.ReadLine();
                DateTime currentDateTime2 = DateTime.Now;
                entry2._date = currentDateTime2.ToShortDateString();

                Entry entry3 = new Entry();
                Console.WriteLine(entry3._promptText = "How best were you to your family today?");
                entry3._entryText = Console.ReadLine();
                DateTime currentDateTime3 = DateTime.Now;
                entry3._date = currentDateTime3.ToShortDateString();

                Entry entry4 = new Entry();
                Console.WriteLine(entry4._promptText = "What do you love about your bet?");
                entry4._entryText = Console.ReadLine();
                DateTime currentDateTime4 = DateTime.Now;
                entry4._date = currentDateTime4.ToShortDateString();

                Entry entry5 = new Entry();
                Console.WriteLine(entry5._promptText = "What was your favorite task achieved today?");
                entry5._entryText = Console.ReadLine();
                DateTime currentDateTime5 = DateTime.Now;
                entry5._date = currentDateTime5.ToShortDateString();

                // Entry entry6 = new Entry();
                //Console.WriteLine(entry6._promptText = "");
                //entry6._entryText = Console.ReadLine();
                //DateTime currentDateTime6 = DateTime.Now;
                //entry6._date = currentDateTime6.ToShortDateString();

                //Entry entry7 = new Entry();
                //Console.WriteLine(entry7._promptText = "");
                //entry7._entryText = Console.ReadLine();
                //DateTime currentDateTime7 = DateTime.Now;
                //entry7._date = currentDateTime7.ToShortDateString();

                //Entry entry8 = new Entry();
                //Console.WriteLine(entry8._promptText = "");
                //entry8._entryText = Console.ReadLine();
                //DateTime currentDateTime8 = DateTime.Now;
                //entry8._date = currentDateTime8.ToShortDateString();
                
                //Entry entry9 = new Entry();
                //Console.WriteLine(entry9._promptText = "");
                //entry9._entryText = Console.ReadLine();
                //DateTime currentDateTime9 = DateTime.Now;
                //entry9._date = currentDateTime9.ToShortDateString();

                //Entry entry10 = new Entry();
                //Console.WriteLine(entry10._promptText = "");
                //entry10._entryText = Console.ReadLine();
                //DateTime currentDateTime10 = DateTime.Now;
                //entry10._date = currentDateTime10.ToShortDateString();
            }

            else if (menu == 2)
            {
                Journal _journal = new Journal();
                _journal.DisplayAll();
            }

            else if (menu == 3)
            {
                Journal _saveJournal = new Journal();

                //using System.IO
                string filename = "myFile.txt";
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(_saveJournal);
                }


            }

            else if (menu == 4)
            {
                Journal _readFile = new Journal();
                
            }

            else if (menu == 5)
            {
                break;
            }

        }
        Journal journal = new Journal();

        

    }
}