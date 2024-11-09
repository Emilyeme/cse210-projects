using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random random = new Random();
        int magicNumber = random.Next(1, 101);  

        
        while (true)
        {
            
            Console.Write("What is your guess? ");
            int guess;
            
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    break;  
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}

    
