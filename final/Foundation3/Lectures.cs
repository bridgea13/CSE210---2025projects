class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    
    public Lectures(string title, string description,string date, string time, string streetAddress, string city, string state, int zipCode, string speaker, int capacity) : base(title, description, date,time, streetAddress, city, state, zipCode)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }
    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine("Event Type: "+ _eventType+"\nSpeaker Name: "+ _speaker+"\nCapacity: "+ _capacity);

    }
    // public override void ShortDescrip()
    // {
    //     Console.WriteLine("Event Type: "+_eventType+"\nTitle: "+_title+"\nDate: "+_date);
    // }
    
}