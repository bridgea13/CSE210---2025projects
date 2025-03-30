class Receptions : Event 
{
    private string _registerEmail;
    public Receptions(string title, string description,string date, string time, string streetAddress, string city, string state, int zipCode, string registerEmail) : base(title, description, date,time, streetAddress, city, state, zipCode)
    {
        _registerEmail = registerEmail;
        _eventType = "Reception";
    }
    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine("Event Type: "+ _eventType+"\nRegistration Email: "+ _registerEmail);

    }
    // public override void ShortDescrip()
    // {
    //     Console.WriteLine("Event Type: "+_eventType+"\nTitle: "+_title+"\nDate: "+_date);
    // }
}