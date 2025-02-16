using System;
using System.IO;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _firstVerse;
    private string _lastVerse;

    public Reference(string book, string chapter, string firstVerse, string lastVerse = "")
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }
    public override string ToString()
    {
        return string.IsNullOrEmpty(_lastVerse) ? $"{_book} {_chapter}:{_firstVerse}" : $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
    } 
}