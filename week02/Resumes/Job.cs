#pragma warning disable CA1050 // Declare types in namespaces
public class Job
#pragma warning restore CA1050 // Declare types in namespaces
{
    // Declare attributes (member variables) //
    public string _company;
    public string _jobTitle;
    public double _startYear;
    public double _endYear;

    //Declare a constructor //
    public Job()
    {

    }

    //Created the DisplayDetails method for debugging purpose //
    //public void DisplayDetails()
    //{
    //    // Print to the terminal //
    //     Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");

    //}


}