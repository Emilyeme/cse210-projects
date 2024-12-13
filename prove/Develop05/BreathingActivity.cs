public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    // Run the breathing activity
    public void Run()
    {
        DisplayStartingMessage();
        
        for (int i = 0; i < _duration / 2; i++) // Alternating breathe in and out for the duration
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3); // 3 seconds countdown
            Console.WriteLine("Breathe out...");
            ShowCountDown(3); // 3 seconds countdown
        }

        DisplayEndingMessage();
    }
}

