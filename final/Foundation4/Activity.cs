class Activity
{
    private string _date;
    protected int _duration;
    protected string _title;
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;

    }
    public void OutputSummary()
    {
        string output = _date + _title + " (" + _duration + ")- Distance ";
        output += GetDistance();
        output += " Miles, Speed ";
        output += GetSpeed();
        output += "mph, Pace: ";
        output += Math.Round(GetPace(),2);
        output += " min per mile";
        Console.WriteLine(output);
    }

    
    private double GetPace(){
        return _duration / GetDistance();

    }
    private double GetSpeed(){
        return GetDistance() / _duration * 60;
    }
    protected virtual double GetDistance(){
        return 0;
    }



}