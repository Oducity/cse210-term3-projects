using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2027;

        job1.ShowCompanyName();
        job1.ShowJobTitle();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Technician";

        job2.ShowCompanyName();
        job2.ShowJobTitle();
    }

}