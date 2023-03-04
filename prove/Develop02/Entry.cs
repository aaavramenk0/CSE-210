using System;
public class Entry {
    string _userEntry;
    public List<string> Display(List<string> _entryList) {
        PromptGenerator _prompt = new PromptGenerator();
        string _entryPrompt = _prompt.Prompt();
        Console.WriteLine(_entryPrompt);
        _userEntry = Console.ReadLine();
        _entryList.Add(_userEntry);

        Journal _addEntry = new Journal();
        DateTime _entryDate = DateTime.Now;
        List<String> _entries = _addEntry.AddEntry(_entryDate, _entryPrompt, _userEntry);

        return _entries;
    }
}