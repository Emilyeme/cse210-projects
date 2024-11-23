using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = new List<Word>();

        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {

        Console.Clear();
        Console.WriteLine(_reference.GetReference());
        

        foreach (var word in _words)
        {
            Console.Write(word.GetText() + " ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWord()
    {
        var hiddenWords = _words.Where(w => w.IsHidden()).ToList();
        var nonHiddenWords = _words.Except(hiddenWords).ToList();

        if (nonHiddenWords.Count == 0)
            return false;

        var rand = new Random();
        var randomIndex = rand.Next(nonHiddenWords.Count);
        nonHiddenWords[randomIndex].Hide();
        return true;
    }

    public bool IsFullyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
    
}