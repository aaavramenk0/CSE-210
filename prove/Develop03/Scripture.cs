using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private string _reference;
    private string _text;
    private List<string> _hiddenWords = new List<string>();
 
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    public string GetReference()
    {
        return _reference;
    }

    public string GetText(bool showHiddenWords)
    {
        if (showHiddenWords)
        {
            string[] _words = _text.Split(' ');
            for (int i = 0; i < _words.Length; i++)
            {
                if (_hiddenWords.Contains(_words[i]))
                {
                    _words[i] = new string('_', _words[i].Length);
                }
            }
            return string.Join(" ", _words);
        }
        else
        {
            string[] _words = _text.Split(' ');
            return string.Join(" ", _words.Except(_hiddenWords));
        }
    }
    public bool HideRandomWord()
    {
        string[] _words = _text.Split(' ');
        var visibleWords = _words.Except(_hiddenWords).ToArray();

        if (visibleWords.Length == 0)
        {
            return false;
        }

        string _word = visibleWords[new Random().Next(visibleWords.Length)];
        _hiddenWords.Add(_word);
        return true;
    }
}