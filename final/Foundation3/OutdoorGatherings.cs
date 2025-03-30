class OutdoorGatherings : Event
{
    private string _weatherStatement;

    
    public OutdoorGatherings(string title, string description, string date,string time, string streetAddress, string city, string state, int zipCode, string weatherStatement) : base(title, description, date,time, streetAddress, city, state, zipCode)
    {
        _weatherStatement = weatherStatement;
        _eventType = "Outdoor Gathering";
    }
    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine("Event Type: "+ _eventType+"\nWeather Statement: "+ _weatherStatement);

    }
}