using System;
using System.Collections.Generic;

class Program
{
    // EXCEED REQUIREMENTS
    // I add Date to file name while notes are loading into file
    // It can be useful in case we connect database and load a lot of notes on different dates
    //
    // Also it can be possible to save name of the user and create Journal for couples or groups where 
    // people will save their notes and in the file it will be shown: Date, Time, Name, Prompt, User answer
    // 
    // As an addition to previous It can be possible to add comments to the notes. It can be one more item
    // in intro message and load all previous notes and give oportunity to comment that
    //
    // Also it can be possible to give users oportunity to edit their notes.
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        List<string> _entries = new List<string>();
        int _loopBreaker = 0;
        while(_loopBreaker != 5) {
            int _userChoice = ShowIntroMessage();
            
            switch (_userChoice)
            {
                case 1:
                    Entry _entry = new Entry();
                    _entries = _entry.Display(_entries);
                    Console.WriteLine("");
                    break;
                case 2:
                    Journal _displayJournal = new Journal();
                    _displayJournal.Display(_entries);
                    break;
                case 3 :
                    Journal _loadFromFile = new Journal();
                    _loadFromFile.LoadFromFile(_entries);
                    break;
                case 4: 
                    Journal _saveToFile = new Journal();
                    _saveToFile.SaveToFile(_entries);
                    break;

                case 5:
                    _loopBreaker = 5;
                    break;
            }
        }
    
        static int ShowIntroMessage() {
            Console.WriteLine("Please select one from the following choices:");
            Console.WriteLine("1. Write a note");
            Console.WriteLine("2. Display all notes");
            Console.WriteLine("3. Load a file with your notes");
            Console.WriteLine("4. Save all notes to a file");
            Console.WriteLine("5. Quit the program");
            Console.Write("What would you like to do? ");
            int _userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return _userChoice;
        } 
        
    }
}