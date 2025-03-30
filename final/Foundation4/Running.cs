class Running : Activity
{
    private double _distance;
    public Running(string date, int duration, int distance) : base(date, duration)
    {
        _distance = distance;
        _title = "Running";
    }
    protected override double GetDistance()
    {
        return _distance;
    }
}