using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();  // Created class object and assign attributes values//
        Console.Write("Enter the first company you worked in: ");
        job1._company = Console.ReadLine();
        Console.Write("Enter your job title: ");
        job1._jobTitle = Console.ReadLine();
        Console.Write("Enter the year you started working here. ");
        job1._startYear = double.Parse(Console.ReadLine());
        Console.Write("Enter the year you stoped working here. ");
        job1._endYear = double.Parse(Console.ReadLine());
        job1.DisplayDetails();  // Called the DisplayDetails method //


        Job job2 = new Job();  // Created class object and assign attributes values//
        Console.Write("Enter the first company you worked in: ");
        job2._company = Console.ReadLine();
        Console.Write("Enter your job title: ");
        job2._jobTitle = Console.ReadLine();
        Console.Write("Enter the year you started working here. ");
        job2._startYear = double.Parse(Console.ReadLine());
        Console.Write("Enter the year you stoped working here. ");
        job2._endYear = double.Parse(Console.ReadLine());
        job2.DisplayDetails();  // Called the DisplayDetails method //

        Resume resume = new Resume(); // Create the Resume class Object and assign its member attributes. //
        resume._personalName = "Odumamen Aisiokuebor";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume(); // Call the DisplayResume method. //
    }

}