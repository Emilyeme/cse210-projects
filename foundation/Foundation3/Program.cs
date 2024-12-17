using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Nov 2022", 30, 3.0); 
        activities.Add(running);

        Cycling cycling = new Cycling("03 Nov 2022", 30, 12.0);
        activities.Add(cycling);

        Swimming swimming = new Swimming("03 Nov 2022", 30, 20);
        activities.Add(swimming);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}



