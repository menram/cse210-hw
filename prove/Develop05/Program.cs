// Exceeding Requirements
// Added another class, a getter, and a menu option to show how many times activities were performed.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        CountActivity countActivity = new CountActivity();
        string menuOption = "";
        while (menuOption != "5")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Display Count of Activities");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            menuOption = Console.ReadLine();
            switch (menuOption)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    countActivity.AddActivity(breathingActivity.GetActivityName());
                    break;
                case "2":
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    countActivity.AddActivity(reflectingActivity.GetActivityName());
                    break;
                case "3":
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    countActivity.AddActivity(listingActivity.GetActivityName());
                    break;
                case "4":
                    Console.Clear();
                    countActivity.DisplayActivityCount();
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please select a valid option");
                    break;
            }
        }
    }
}