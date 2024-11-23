using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string reference)
    {
        try
        {
            Console.WriteLine($"Parsing reference: {reference}"); 

            var parts = reference.Split(new[] { ' ' }, 2);
            if (parts.Length < 2)
            {
                throw new ArgumentException("Invalid reference format. Ensure the format is 'Book Chapter:Verse' or 'Book Chapter:StartVerse-EndVerse'.");
            }

            _book = parts[0]; 
            var bookChapterParts = parts[1].Split(':');
            if (bookChapterParts.Length < 2 || string.IsNullOrEmpty(bookChapterParts[0]) || string.IsNullOrEmpty(bookChapterParts[1]))
            {
                throw new ArgumentException("Invalid chapter format. Ensure the reference includes both the book and chapter (e.g., 'John 3:16').");
            }

            if (!int.TryParse(bookChapterParts[0], out _chapter))
            {
                throw new ArgumentException($"Invalid chapter number format: {bookChapterParts[0]}");
            }

            var verseParts = bookChapterParts[1].Split('-'); 
            if (!int.TryParse(verseParts[0], out _startVerse))
            {
                throw new ArgumentException($"Invalid verse format: {verseParts[0]}");
            }
            _endVerse = verseParts.Length > 1 ? int.Parse(verseParts[1]) : _startVerse;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error parsing reference: " + ex.Message);
            throw;  
        }
    }

    
    public string GetReference()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}