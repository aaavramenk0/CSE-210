using System;
using System.Collections.Generic;
public class Scripture
{
    private string _verseText = "For where two or three are gathered together in my name, there am I in the midst of them.";
    private string _verseNumber = "Matthew 18:20";

    Random random = new Random();
    

    public void HideWords() {
        int randomNumber = random.Next(_verseText.Split(' ').Count());
        _verseText.Split(' ')[randomNumber] = "___";
    }

    public void GetRenderedText() {
        string[] words = _verseText.Split(' ');
        Console.WriteLine(_verseNumber);
        foreach(var word in words) {
            _verseText += $"{word} ";
        }   
        Console.WriteLine(_verseText);
        int randomNumber = random.Next(words.Count());     
    }

    public void IsCompletelyHidden() {

    }
}