class Program
{/* created a library of scriputures*/
    static void Main(string[] args)
    {
         var scriptures = new List<Scripture>
        {
            new Scripture("John 3:16", "For God so loved the world that he gave his only begotten Son"),
            new Scripture("Psalm 23:1", "The Lord is my shepherd; I shall not want."),
            new Scripture("Romans 8:28", "And we know that all things work together for good to them that love God."),
            new Scripture("Philippians 4:13", "I can do all things through Christ which strengtheneth me."),
            new Scripture("Isaiah 40:31", "But they that wait upon the Lord shall renew their strength; they shall mount up with wings as eagles.")
        };

        
        var rand = new Random();
        var randomScripture = scriptures[rand.Next(scriptures.Count)];
        randomScripture.DisplayScripture();
       

            while (true)
            {
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                if (!randomScripture.HideRandomWord())
                {
                    Console.WriteLine("All words are hidden!");
                    break;
                }

                randomScripture.DisplayScripture();
            }

            Console.WriteLine("Goodbye!");
        }
    
    
}