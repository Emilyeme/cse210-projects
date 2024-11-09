using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers= new List<int>();

        while (true)
        {
          Console.Write("Enter a list of numbers, type 0 to finish:");
          int userInput = int.Parse(Console.ReadLine()); 

          if (userInput==0)
          {
            break;
          }
          numbers.Add(userInput); 
        }

         int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = (numbers.Count > 0) ? (double)sum / numbers.Count : 0;
         int max = (numbers.Count > 0) ? numbers[0] : 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average:F2}");  
        Console.WriteLine($"Maximum: {max}");
        
        
        
    }
}