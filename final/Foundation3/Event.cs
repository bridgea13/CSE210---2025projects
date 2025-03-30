class Event
{
    protected string _title;
    private string _description;
    protected string _date;
    private string _time;
    private Address _address;
    protected string _eventType;

    public Event(string title, string description, string date, string time, string streetAddress, string city, string state, int zipCode)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address(streetAddress, city, state, zipCode);

    }
    public void StandardDetails()
    {
        Console.WriteLine("Title: " + _title+ "\nDescription: "+_description + "\nDate: " + _date + "\nTime of event: " + _time);
        _address.AdressString();
    }
    public virtual void FullDetails() { }

    public  void ShortDescrip()
    {
        
        Console.WriteLine("Event Type: "+_eventType+"\nTitle: "+_title+"\nDate: "+_date);
    }
}