using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("Don't worry, no entries in the journal.");
        }
        else
        {
            foreach (var entry in Entries)
            {
                Console.WriteLine(entry);
            }
        }
    }
    // method to save the journal entries to a CSV file
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {// write the header row to the CSV file
                writer.WriteLine("Date,Prompt,Response,Location,Mood");

                foreach (var entry in Entries)
                {
                    string response = EscapeCsv(entry.Response);
                    string prompt = EscapeCsv(entry.Prompt);
                    string location = EscapeCsv(entry.Location);
                    string mood = EscapeCsv(entry.Mood);

                    writer.WriteLine($"{entry.Date},{prompt},{response},{location},{mood}");
                }
            }
            Console.WriteLine($"Journal saved to {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }
    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                bool firstLine = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (firstLine)
                    {
                        firstLine = false; 
                        continue;
                    }

            
                    string[] parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        string date = parts[0];
                        string prompt = parts[1];
                        string response = parts[2];
                        string location = parts[3];
                        string mood = parts[4];

                        Entries.Add(new Entry(date, prompt, response, location, mood));
                    }
                }
            }
            Console.WriteLine($"Journal loaded from {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

    public string EscapeCsv(string value)
    {
        if (value.Contains("\""))
        {
            value = value.Replace("\"", "\"\"");
        }

        if (value.Contains(","))
        {
            value = $"\"{value}\"";
        }

        return value;
    }
}