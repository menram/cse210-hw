using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string stringGrade = Console.ReadLine();
        int intGrade = int.Parse(stringGrade);
        string letter = "";

        if (intGrade >= 90)
        {
            letter = "A";
        }
        else if (intGrade >= 80)
        {
            letter = "B";
        }
        else if (intGrade >= 70)
        {
            letter = "C";
        }
        else if (intGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if ((intGrade < 93) && (intGrade >= 60))
        {
            if (intGrade % 10 >= 7)
            { letter = letter + "+"; }
            else if (intGrade % 10 < 3)
            { letter = letter + "-"; }
        }

        Console.WriteLine("");
        Console.WriteLine($"Your letter grade is: {letter}");
        if (intGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Try again.");
        }
    }
}