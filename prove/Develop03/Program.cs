using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is the name of the book you are referencing?");
        string book = Console.ReadLine();
        Console.WriteLine("Which chapter?");
        string chapter = Console.ReadLine();
        Console.WriteLine("What is the number of the first verse you are referencing?");
        string firstVerse = Console.ReadLine();
        Console.WriteLine("What is the number of the last verse you are referencing?");
        string lastVerse = Console.ReadLine();

        var reference = new Reference(book, chapter, firstVerse, string.IsNullOrEmpty(lastVerse) ? "" : lastVerse);

        Console.WriteLine("Type out the passage you would like to reference:");
        string passage = Console.ReadLine();

        var scripture = new Scripture(reference, passage);

        SaveScripture(scripture);

        while (!scripture.AllWordsAreHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit");
            string input = Console.ReadLine();

            if (input?.ToLower() == "Quit")
                break;

            scripture.HideRandomWords(2);

            if (scripture.AllWordsAreHidden())
            {
                Console.Clear();
                scripture.GetDisplayText();
                Console.WriteLine("\nEvery Word has been hidden, so the program will end.");
            }
        }
    }
    
    static void SaveScripture( Scripture scripture)
    {
        string filePath = "memorized_scriptures.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(scripture.GetOriginalText());
            writer.WriteLine();
        }
    }
}