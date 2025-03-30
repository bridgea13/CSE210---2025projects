class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
        _title = "Swimming";
    }
    protected override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
}