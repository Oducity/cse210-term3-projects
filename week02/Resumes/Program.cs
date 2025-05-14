using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();  // Created class object and assign attributes values//
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;
        job1.DisplayDetails();  // Called the DisplayDetails method //


        Job job2 = new Job();  // Created class object and assign attributes values//
        job2._company = "Apple";
        job2._jobTitle = job1._jobTitle;
        job2._startYear = job1._endYear;
        job2._endYear = 2025;
        job2.DisplayDetails();  // Called the DisplayDetails method //

        Resume resume = new Resume(); // Create the Resume class Object and assign its member attributes. //
        resume._personalName = "Odumamen Aisiokuebor";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume(); // Call the DisplayResume method. //
    }

}