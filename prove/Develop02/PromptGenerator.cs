using System;
using System.Collections.Generic;

public class PromptGenerator {
    string _prompt;
    
    public string Prompt() {
        Random _randomPrompt = new Random();
        List<string> _userPrompts = new List<string>();
        _userPrompts.Add("  Who was the most interesting person I interacted with today?");
        _userPrompts.Add("  What was the best part of my day?");
        _userPrompts.Add("  How did I see the hand of the Lord in my life today?");
        _userPrompts.Add("  If I had one thing I could do over today, what would it be?");
        _userPrompts.Add("  What was the strongest emotion I felt today?");
        _userPrompts.Add("  What are your biggest fears, and how do they affect you?");
        _userPrompts.Add("  When faced with a difficult decision, how did you approach it?");
        _userPrompts.Add("  What challenges are you currently facing?");

        int _userPrompt = _randomPrompt.Next(1, _userPrompts.Count);
        _prompt = _userPrompts[_userPrompt];
        return _prompt;
    } 

    
}