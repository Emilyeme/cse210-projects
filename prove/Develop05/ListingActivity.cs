using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Run the listing activity
    public void Run()
    {
        DisplayStartingMessage();
        
        // Get a random prompt
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        
        ShowCountDown(5); // Give the user 5 seconds to think about the prompt

        Console.WriteLine("Start listing your thoughts. Type 'done' to finish.");
        int count = 0;
        
        // User inputs list items
        string input;
        while ((input = Console.ReadLine()) != "done")
        {
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        DisplayEndingMessage();
    }
}