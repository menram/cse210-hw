public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Job()
    {
    }

    // A method that displays the job details 
    // Example: Software Engineer (Microsoft) 2019-2022
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}