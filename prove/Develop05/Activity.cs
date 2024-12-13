using System;

public class Activity
{
    private string _name;
    private string _description;
    public int _duration;

    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

       public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
        Console.WriteLine("How long would you like to do this activity? (in seconds)");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3); 
    }

    
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed {_name}.");
        Console.WriteLine($"Duration: {_duration} seconds");
        ShowSpinner(3); 
    }

     
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("-");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time left: {i} seconds");
            System.Threading.Thread.Sleep(1000);
        }
    }
}