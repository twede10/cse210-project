using System;
using static System.Console;

class Circle : Shapes
{
    private double _radius;

    public void SetCircle(string color, double radius)
    {
        SetColor(color);
        _radius = radius;
    }

    public override double GetArea()
    {
        double Area;
        Area = _radius * _radius * Math.PI;
        return Area;
    }
}