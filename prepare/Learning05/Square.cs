using System;
using static System.Console;

class Square : Shapes
{
    private double _side;

    public void SetSquare(string color, double side)
    {
        SetColor(color);
        _side = side;
    }

    public override double GetArea()
    {
        double Area = 0.00;
        Area = _side * _side;
        return Area;
    }
}