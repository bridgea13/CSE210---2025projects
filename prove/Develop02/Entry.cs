internal class Entry
{
    public string response { get; set; }
    public string prompt { get; set; }
    public DateTime date { get; set; }
    Prompt question;
    public Entry()
    {
        date = DateTime.Now;
        question = new Prompt();
        prompt = question.get_prompt();
        response = "";
    }
    public void add_response()
    {
        Console.WriteLine(prompt + "" + "\n>");
        response = Console.ReadLine();
    }
    public void output_entry()
    {
        Console.WriteLine(date);
        Console.WriteLine(prompt);
        Console.WriteLine(response);
    }
}