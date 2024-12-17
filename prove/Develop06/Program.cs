using System;
// added two more goal progressivegoal to track increas in progress and
//and negative goals which penalizes bad habits
public class Program
{
    public static void Main()
    {
        GoalManager goalManager = new GoalManager();

        goalManager.LoadGoals();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nGoal Tracker");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Player Info");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Select an option:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoalNames();
                    break;
                case "3":
                    Console.WriteLine("Enter goal name to record event:");
                    string goalName = Console.ReadLine();
                    goalManager.RecordEvent(goalName);
                    break;
                case "4":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "5":
                    goalManager.SaveGoals();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
