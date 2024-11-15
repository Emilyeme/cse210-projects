using System;

class Program
{
    static void Main(string[] args)
    {
      Journal journal = new Journal();

      string[] prompts ={
        "Who was the most intresting person I interacted with toaday?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
      }; 

      while (true)
      {
        Console.Clear();
        Console.WriteLine("Journal Program Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option: ");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Random random = new Random();
                    string prompt = prompts[random.Next(prompts.Length)];
                    Console.WriteLine(prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    journal.AddEntry(new Entry(date, prompt, response));
                    break;
            case "2" :
                 journal.DisplayEntries();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
            case "3":
                Console.Write("Enter the filename to save the journal: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

            case "4" :
                Console.Write("Enter the filename to load the journal from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
            case "5" :
                return;

            default:
                Console.WriteLine("Invalid choice, try again.");
                break;
        }
      }
    }
}