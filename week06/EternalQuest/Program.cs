using System;

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Select goal type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Enter your choice: ");
                    string goalType = Console.ReadLine();

                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (goalType == "1")
                    {
                        goalManager.CreateGoal(new SimpleGoal(name, description, points));
                    }
                    else if (goalType == "2")
                    {
                        goalManager.CreateGoal(new EternalGoal(name, description, points));
                    }
                    else if (goalType == "3")
                    {
                        Console.Write("Enter target count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        goalManager.CreateGoal(new ChecklistGoal(name, description, points, target, bonus));
                    }
                    break;
                
                case "2":
                    goalManager.ListGoalDetails();
                    goalManager.DisplayPlayerInfo();
                    break;
                
                case "3":
                    Console.Write("Enter filename to save (without extension): ");
                    string saveFile = Console.ReadLine();
                    string savePath = $"C:\\Users\\frodo\\OneDrive\\Documents\\BYU\\cse210-hw\\cse210-projects\\week06\\EternalQuest\\{saveFile}.txt";
                    goalManager.SaveGoals(savePath);
                    Console.WriteLine($"Goals saved to {savePath}");
                    break;
                
                case "4":
                    Console.Write("Enter filename to load (without extension): ");
                    string loadFile = Console.ReadLine();
                    string loadPath = $"C:\\Users\\frodo\\OneDrive\\Documents\\BYU\\cse210-hw\\cse210-projects\\week06\\EternalQuest\\{loadFile}.txt";
                    goalManager.LoadGoals(loadPath);
                    Console.WriteLine($"Goals loaded from {loadPath}");
                    break;
                
                case "5":
                    goalManager.ListGoalNames();
                    Console.Write("Enter goal index to record event: ");
                    int index = int.Parse(Console.ReadLine());
                    goalManager.RecordEvent(index);
                    break;
                
                case "6":
                    running = false;
                    break;
                
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
