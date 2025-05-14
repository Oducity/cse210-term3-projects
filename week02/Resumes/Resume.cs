// Create Resume class //
using System.Reflection.Metadata.Ecma335;

public class Resume
{
    // Create member attributes. //
    public string _personalName;
    public List<Job> _jobs = new List<Job>();

    public Resume() // Create the Resume class constructor. //
    {

    }
    // Create the DisplayResume method. //
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personalName}");
        Console.WriteLine("Jobs are:");
        // Use foreach loop to iterate through the _jobs and called the DisplayDetails method. //
        foreach (Job job in _jobs)
        {
            job.DisplayDetails();
        }
    }

}