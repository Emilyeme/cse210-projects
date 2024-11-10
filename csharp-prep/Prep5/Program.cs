using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName= PromptUserName();
        int userNumber= PromptUserNumber();
        int squaredNumber=SuquareNumber(userNumber);
        DisplayResults(userName,squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to our Program.");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name ?");
        string name=Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favourite number: ");
        int number= int.Parse(Console.ReadLine());

        return number;
    }

    static int SuquareNumber(int number)
    {
        int square= number * number;
        return square;

    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name},the square of your number is {square}");
    }
}