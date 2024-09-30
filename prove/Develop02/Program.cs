using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        string fileName;

        string[] options = { "1", "2", "3", "4", "5" };
        string choice = "";
        Console.WriteLine("Welcome to the Journal Program!");
        while (choice != "5" || choice == "")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            if (!options.Contains(choice))
            {
                Console.WriteLine("Incorrect Menu Option. Please enter an option from 1 to 5.");
                choice = "";
            }
            else if (choice == "1")
            {
                Prompt prompt = new Prompt();
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                Console.Write("What is the file name? ");
                fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("What is the file name? ");
                fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
        }
    }
}