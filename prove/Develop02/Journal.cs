using System;
using System.Collections.Generic;
using System.IO; 

public class Journal {
    List<string> _entries = new List<string>();
    
    public List<string> AddEntry(DateTime _entryDate, string _prompt, string _userEntry) {
        
        string _entryDateText = _entryDate.ToShortDateString(); // convert DateTime to the string
        // Add Date, Prompt and UserEntry to the list
        _entries.Add(_entryDateText); // _entries[0]
        _entries.Add(_prompt); // _entries[1]
        _entries.Add(_userEntry); // _entries[2]

        return _entries;
    }

    public void Display(List<string> _entries) {

        for (int i = 0; i < _entries.Count; i+=3)
        {
            Console.WriteLine($"Date: {_entries[i]} - Prompt: {_entries[i+1]}");
            Console.WriteLine(_entries[i+2]);
            Console.WriteLine("");
        }
    }
    public void LoadFromFile(List<string> _entries) {
        DateTime currentDate = DateTime.Now;
        string currentDateText = currentDate.ToShortDateString();
        string fileName = $"{currentDateText} Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        Console.WriteLine("");
    }
    
    public void SaveToFile(List<string> _entries) {
        DateTime currentDate = DateTime.Now;
        string currentDateText = currentDate.ToShortDateString();
        string fileName = $"{currentDateText} Journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            for (int i = 0; i < _entries.Count; i+=3)
            {
                outputFile.WriteLine($"Date: {_entries[i]} - Prompt: {_entries[i+1]}");
                outputFile.WriteLine(_entries[i+2]);
                outputFile.WriteLine("");
            }
        }
        Console.WriteLine("");
    }
}