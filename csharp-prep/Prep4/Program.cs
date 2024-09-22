using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers_list = new List<int>();
        int number = -1;
        string stringNumber = "";
        Console.WriteLine($"Enter a list of numbers, type 0 when finished. ");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            stringNumber = Console.ReadLine();
            number = int.Parse(stringNumber);
            if (number != 0)
            {
                numbers_list.Add(number);
            }
        }

        Console.WriteLine("");
        Console.WriteLine($"The sum is: {numbers_list.Sum()}");
        Console.WriteLine($"The average is: {(float)numbers_list.Sum() / numbers_list.Count}");
        numbers_list.Sort();
        Console.WriteLine($"The largest number is: {numbers_list.Max()}");
        foreach (int item in numbers_list)
        {
            if (item > 0)
            {
                Console.WriteLine($"The smallest positive number is: {item}");
                break;
            }
        }
        Console.WriteLine($"The sorted list is:");
        foreach (int item in numbers_list)
        {
            Console.WriteLine(item);
        }
    }
}