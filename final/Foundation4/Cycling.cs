class Cycling : Activity
{
    private int _speed;
    public Cycling(string date, int duration, int speed) : base(date, duration)
    {
        _speed = speed;
        _title = "Cycling";
    }
    protected override double GetDistance()
    {
        return _speed * _duration;
    }
}