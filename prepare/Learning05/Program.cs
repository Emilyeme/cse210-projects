using System;

class Program
{
    static void Main(string[] args)
    {
      Assignment a1 =new Assignment("Emily Emerson", "Abstraction");
      Console.WriteLine(a1.GetSummary()); 

      MathAssignment a2 = new MathAssignment("Edrinah Nels", "Indexes", "10", "2-8");
      Console.WriteLine(a2.GetSummary());
      Console.WriteLine(a2.GetHomeworkList());

      WritingAssignment a3 = new WritingAssignment("Myhra Blessing", "Designs","Web and computer programming");
      Console.WriteLine(a3.GetSummary());
      Console.WriteLine(a3.GetWritingInformation());

    }
}