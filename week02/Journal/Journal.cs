using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;

public class Journal{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }

    public void DisplayAll(){

        if (_entries.Count == 0){
            Console.WriteLine("No entries");
            return;
        }

        Console.WriteLine("Journal Entries: ");
        foreach (Entry entry in _entries){
            entry.Display();
        }

    }

    public void SaveToFile(string file){
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine("---");
                    writer.WriteLine(entry._date);
                    writer.WriteLine(entry._promptText);
                    writer.WriteLine(entry._entryText);
                }
            }
            Console.WriteLine("Journal saved");
        }
        catch (Exception exept)
        {
            
            Console.WriteLine($"Error saving journal: {exept.Message}");
        }
    }

    public void LoadFromFile(string file){
        try{
            using (StreamReader reader = new StreamReader(file)){
                _entries.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "---"){
                        string date = reader.ReadLine();
                        string promptText = reader.ReadLine();
                        string entryText = reader.ReadLine();

                        Entry entry = new Entry{
                            _date = date,
                            _promptText = promptText,
                            _entryText = entryText
                        };
                        _entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Journal Loaded");
        }
        catch(Exception exept){
            Console.WriteLine($"Error Loading: {exept.Message}");
        }
    }
}