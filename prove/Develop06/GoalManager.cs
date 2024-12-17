using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

  
    public void Start()
    {
        // Placeholder for initialization logic
    }

   
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

       public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
            writer.WriteLine($"Score:{_score}");
        }
    }

    
    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Score:"))
                    {
                        _score = int.Parse(line.Substring(6)); 
                    }
                    else
                    {
                        string[] goalData = line.Split(':');
                        string goalName = goalData[0];
                        string goalDescription = goalData[1];
                        int goalPoints = int.Parse(goalData[2]);

                        _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
                    }
                }
            }
        }
    }

   
   public void CreateGoal()
{
    Console.WriteLine("Enter the name of the goal:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter the description of the goal:");
    string description = Console.ReadLine();
    Console.WriteLine("Enter the points for this goal:");
    int points = int.Parse(Console.ReadLine());

    Console.WriteLine("What type of goal is this?");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.WriteLine("4. Progressive Goal");
    Console.WriteLine("5. Negative Goal");

    string goalType = Console.ReadLine();
    Goal newGoal = null;

    if (goalType == "1")
    {
        newGoal = new SimpleGoal(name, description, points);
    }
    else if (goalType == "2")
    {
        newGoal = new EternalGoal(name, description, points);
    }
    else if (goalType == "3")
    {
        Console.WriteLine("Enter the target number of completions:");
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the bonus points for completing the goal:");
        int bonus = int.Parse(Console.ReadLine());
        newGoal = new ChecklistGoal(name, description, points, target, bonus);
    }
    else if (goalType == "4")
    {
        Console.WriteLine("Enter the target for this progressive goal:");
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a description of the progress being made:");
        string progressDescription = Console.ReadLine();
        newGoal = new ProgressiveGoal(name, description, points, target, progressDescription);
    }
    else if (goalType == "5")
    {
        Console.WriteLine("Enter the penalty amount for this negative goal:");
        int penaltyAmount = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the reason for the penalty:");
        string reasonForPenalty = Console.ReadLine();
        newGoal = new NegativeGoal(name, description, points, penaltyAmount, reasonForPenalty);
    }

    _goals.Add(newGoal);
}


public void RecordEvent(string goalName)
{
    Goal goal = _goals.Find(g => g.GetStringRepresentation() == goalName);
    if (goal != null)
    {
    goal.RecordEvent();
    if (goal.IsComplete())
    {
        _score += goal.GetPoints(); 
        Console.WriteLine($"Goal '{goalName}' is now complete!");
    }
    else
    {
        Console.WriteLine($"Progress recorded for '{goalName}'.");
    }
    }
    else
    {
        Console.WriteLine("Goal not found.");
    }
    }
}
