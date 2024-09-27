using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1997;
        job1._endYear = 1998;

        Job job2 = new Job();
        job2._jobTitle = "Janitor";
        job2._company = "Apple";
        job2._startYear = 1999;
        job2._endYear = 2000;

        // job1.Display();
        // job2.Display();

        Resume resume = new Resume();
        resume._name = "John Doe";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Console.WriteLine(resume._jobs[0]._jobTitle);
        resume.Display();
    }
}