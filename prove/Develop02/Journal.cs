using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries {get; set;} = new List<Entry>();

    public void AddEntry(Entry entry){
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (Entries.Count ==0){
            Console.WriteLine("Don't worry entries in the journal.");
        }
        else{
            foreach(var entry in Entries){
                Console.WriteLine(entry);
            }
        }
    }


    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename)){
            foreach(var entry in Entries){
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }

        Console.WriteLine($"Journal saved to {filename}.");
    }
    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3){
                        Entries.Add(new Entry(parts[0], parts[1], parts[2]));
                    }
                }
            }
            Console.WriteLine($"Journal loaded from {filename}.");
        }
        catch ( Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}