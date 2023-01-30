using System;

public class Fraction
{
    private string _top;
    private string _bottom;
    public Fraction()
    {
        _top = "1";
        _bottom = "1";
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber.ToString();
        _bottom = "1";
    }
    public Fraction(int top, int bottom)
    {
        _top = top.ToString();
        _bottom = bottom.ToString();
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        double top = int.Parse(_top);
        double bottom = int.Parse(_bottom);
        double _value = top/bottom;
        return _value;
    }
}