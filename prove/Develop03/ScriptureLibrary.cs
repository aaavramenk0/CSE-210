using System;
using System.Collections.Generic;

class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();
    
    private int _currentScriptureIndex = -1;
    private Random randomNumber = new Random();
   
    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }
    
    public Scripture GetCurrentScripture()
    {
        if (_currentScriptureIndex == -1)
        {
            Console.Write("No scripture is currently selected.");
        }
        
        return _scriptures[_currentScriptureIndex];
    }
    
    public int GetTotalScriptures()
    {
        return _scriptures.Count;
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            Console.Write("There are no scriptures in library.");
        }
        
        int index = randomNumber.Next(_scriptures.Count);
        return _scriptures[index];
    }
    
    internal void RemoveScripture(Scripture scripture)
    {
        _scriptures.Remove(scripture);
    }
}