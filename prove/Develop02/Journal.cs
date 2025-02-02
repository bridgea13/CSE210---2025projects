using System.Text.Json;

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

internal class Journal
{
    List <Entry> entries;
    String filePath;

    public Journal()
    {
        entries = new List<Entry>();
        filePath = "entries.json";
    }
    public void add_entry()
    {
        Entry entry = new Entry();
        entry.add_response();
        entries.Add(entry);
    }
    
    public void display_entry()
    {
        foreach (Entry passage in entries)
        {
            Console.WriteLine("");
            passage.output_entry();
        }
    }

    public void save_entry()
    {
        Console.WriteLine(entries.Count);
        
        string json = System.Text.Json.JsonSerializer.Serialize(entries, new JsonSerializerOptions {WriteIndented = true});
        File.WriteAllText(filePath, json);
        Console.WriteLine("List of entries are saved to file: " + filePath);
    }

    public void load_entry()
    {
        String jsonData = File.ReadAllText(filePath);
        entries = JsonConvert.DeserializeObject<List<Entry>>(jsonData);
        Console. WriteLine("Your journal is loading.");
    }
}