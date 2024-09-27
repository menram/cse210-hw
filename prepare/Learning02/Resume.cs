public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();


    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Resume()
    {
    }

    // A method that displays the resume
    // composed of the name and all the job details
    // Example: Software Engineer (Microsoft) 2019-2022
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job b in _jobs)
        {
            b.Display();
        }
    }

}