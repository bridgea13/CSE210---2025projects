class Prompt
{
string prompt;
public Prompt()
    {
        Random rnd = new Random ();

        List<string> items = new List<string>
            {
                "What was your peach of the day?",
                "What was your pit of the day?",
                "Do you have any regrets of the day?",
                "Is there something about your day that you wished would happen every day?",
                "What are you most grateful for today?"
            };
        Console.Clear();
        int num = rnd.Next(items.Count);
        prompt = items[num];
    }
public string get_prompt()
{
    return prompt;
}
}