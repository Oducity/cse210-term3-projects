#pragma warning disable CA1050 // Declare types in namespaces
public class Job
#pragma warning restore CA1050 // Declare types in namespaces
{
    public string _company;
    public string _jobTitle;
    public double _startYear;
    public double _endYear;

    public Job()
    {

    }

    public void DisplayDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}