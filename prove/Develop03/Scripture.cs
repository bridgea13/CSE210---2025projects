using System;
using System.IO;

public class Scripture{
        
    private Reference Reference { get; }
    private List<Word> Words { get; }
    private Random random = new Random();

    public Scripture(Reference reference, string passage)
    {
        Reference = reference;
        Words = passage.Split(' ').Select(word => new Word(word)).ToList();
    }
    
    public string GetDisplayText()
    {
        return $"Reference\n{string.Join(" ", Words)}";
    }

    public string GetOriginalText()
    {
        return $"{Reference}: {string.Join(" ", Words.Select(w => w.Text))}";
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public bool AllWordsAreHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}