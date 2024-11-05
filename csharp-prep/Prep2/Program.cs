using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage:  ");
        string answer= Console.ReadLine();
        int percentage = int .Parse(answer);
        String letter="";

        if (percentage>=90)
        {
            letter="A";
        }
        else if( percentage>=80){
            letter="B";
        }

        else if(percentage>=70){
            letter="C";
        }
        else if( percentage>=60){
            letter="D";
        }
        else if (percentage<60)
        {
           letter="F"; 
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (percentage>=70){
            Console.WriteLine("Your have passed congs!!!!");
        }

        else{
            Console.WriteLine("Pull up your stockings better nest time.");
        }
        
        
            
    }
}
