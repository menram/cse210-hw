using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }
    /*
RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
SaveGoals - Saves the list of goals to a file.
LoadGoals - Loads the list of goals from a file.    
    */
    public void Start()
    {
        string menuOption = "";
        while (menuOption != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuOption = Console.ReadLine();
            switch (menuOption)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please select a valid option");
                    break;
            }
        }
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    private void ListGoalNames()
    {
        int goalNumber = 0;
        string goalName;
        Console.WriteLine("The goals are:");
        foreach (Goal g in _goals)
        {
            goalNumber++;
            goalName = $"{goalNumber}. {g.GetName()}";
            Console.WriteLine(goalName);
        }
    }
    private void ListGoalDetails()
    {
        int goalNumber = 0;
        string goalDetail;
        Console.WriteLine("The goals are:");
        foreach (Goal g in _goals)
        {
            goalNumber++;
            goalDetail = $"{goalNumber}. {g.GetDetailsString()}";
            Console.WriteLine(goalDetail);
        }
    }
    private void CreateGoal()
    {
        string goalType = "";
        string goalName = "";
        string goalDescription = "";
        int goalPoints = 0;
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalType = Console.ReadLine();
        switch (goalType)
        {
            case "1":
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                try
                {
                    goalPoints = Int32.Parse(Console.ReadLine());
                    SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                    _goals.Add(simpleGoal);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid points value was entered.");
                }
                break;
            case "2":
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                try
                {
                    goalPoints = Int32.Parse(Console.ReadLine());
                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                    _goals.Add(eternalGoal);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid points value was entered.");
                }
                break;
            case "3":
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                try
                {
                    goalPoints = Int32.Parse(Console.ReadLine());
                    try
                    {
                        int goalTarget = 0;
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        goalTarget = Int32.Parse(Console.ReadLine());
                        try
                        {
                            int goalBonus = 0;
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            goalBonus = Int32.Parse(Console.ReadLine());
                            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
                            _goals.Add(checklistGoal);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Not a valid bonus value was entered.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Not a valid target value was entered.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid points value was entered.");
                }
                break;
            default:
                Console.WriteLine("Please select a valid option");
                break;
        }
    }
    private void RecordEvent()
    {
        ListGoalNames();
        int goalNumber = 0;
        string goalChoice;
        bool goodChoice = false;
        Console.Write("Which goal did you accomplish? ");
        goalChoice = Console.ReadLine();
        foreach (Goal g in _goals)
        {
            goalNumber++;
            if (goalChoice == goalNumber.ToString())
            {
                int pointsEarned = 0;
                goodChoice = true;
                pointsEarned = g.RecordEvent();
                _score += pointsEarned;
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points.");
                break;
            }
        }
        if (!goodChoice)
        {
            Console.WriteLine("Choice does not exist");
        }
    }
    private void SaveGoals()
    {
        string fileName;
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // First line for the Score
            outputFile.WriteLine(_score);
            // Subsequent lines for the goals
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    private void LoadGoals()
    {
        _goals = [];
        _score = 0;

        string fileName;
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        for (int i = 0; i < lines.Count(); i++)
        {
            if (i == 0)
            {
                _score = Convert.ToInt32(lines[i]);
            }
            else
            {
                string[] lineSections = lines[i].Split(":");
                string[] goalValues = lineSections[1].Split(",");
                if (lineSections[0] == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(goalValues[0], goalValues[1], Convert.ToInt32(goalValues[2]));
                    simpleGoal.SetComplete(Convert.ToBoolean(goalValues[3]));
                    _goals.Add(simpleGoal);
                }
                if (lineSections[0] == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(goalValues[0], goalValues[1], Convert.ToInt32(goalValues[2]));
                    _goals.Add(eternalGoal);
                }
                if (lineSections[0] == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalValues[0], goalValues[1], Convert.ToInt32(goalValues[2]), Convert.ToInt32(goalValues[4]), Convert.ToInt32(goalValues[3]));
                    checklistGoal.SetAmountCompleted(Convert.ToInt32(goalValues[5]));
                    _goals.Add(checklistGoal);
                }
            }
        }
    }
}