using System;
using static System.Console;

class Rectangle : Shapes
{
    private double _length;
    private double _width;

    public void SetRectangle(string color, double length, double width)
    {
        SetColor(color);
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        double Area;
        Area = _length * _width;
        return Area;
    }
}