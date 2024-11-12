using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 =new Job("Graphics Designer", "Imitari Solutions", 2020, 2021);
        Job job2 =new Job("Assistant Manager", "J&L Company",2022,2023);
        Job job3 =new Job("Software Developer", "Arali Developers",2023,2024);


        job1.DisplayJobInfo();
        job2.DisplayJobInfo();
        job3.DisplayJobInfo();


        Resume myResume = new Resume( "Name:Emily Emerson Cotilda N");

        myResume.AddJob(job1);
        myResume.AddJob(job2);
        myResume.AddJob(job3);

        myResume.Display();

    }
}