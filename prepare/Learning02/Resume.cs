using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs;

    public Resume(string name)
    {
     _name = name;
     _jobs = new List<Job>();
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine(_name);
        foreach (var job in _jobs)
        {
            job.DisplayJobInfo();
        }
    }
}
