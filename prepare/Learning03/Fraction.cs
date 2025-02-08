using System;

public class Frac
{
    private int _top;
    private int _bottom;

    public Frac()
    {
        _top = 1;
        _bottom = 1;
    }
    public Frac(int Whole)
    {
        _top = Whole;
        _bottom = 1;
    }
    public Frac(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}