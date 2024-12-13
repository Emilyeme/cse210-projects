using System;

class Program
{

    // Log activity counts
    static int breathingCount = 0;
    static int listingCount = 0;
    static int reflectingCount = 0;
 
    static void Main(string[] args)
    {
      while (true)
        {
           
            Console.Clear();
            Console.WriteLine("Welcome to the Activity Program!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Exit");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                    breathingActivity.Run();
                    breathingCount++;
                    break;

                case "2":
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                    listingActivity.Run();
                    listingCount++; 
                    break;

                case "3":
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 0);
                    reflectingActivity.Run();
                    reflectingCount++; 
                    break;

                case "4":
                    // Display the log of activities performed
                    Console.WriteLine("\nActivity Log:");
                    Console.WriteLine($"Breathing Activity: {breathingCount} times");
                    Console.WriteLine($"Listing Activity: {listingCount} times");
                    Console.WriteLine($"Reflecting Activity: {reflectingCount} times");
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }  
    }
}