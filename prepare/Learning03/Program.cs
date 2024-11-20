using System;

class Program
{
    static void Main(string[] args)
    {
      Fraction d1 = new Fraction();
      Console.WriteLine(d1.GetFractionString());
      Console.WriteLine(d1.GetDecimalValue());

      Fraction d2 = new Fraction(5);
      Console.WriteLine(d2.GetFractionString());
      Console.WriteLine(d2.GetDecimalValue());

      Fraction d3 = new Fraction(3,4);
      Console.WriteLine(d3.GetFractionString());
      Console.WriteLine(d3.GetDecimalValue());


      Fraction d4 = new Fraction(1,3);
      Console.WriteLine(d4.GetFractionString());
      Console.WriteLine(d4.GetDecimalValue());
    }
}