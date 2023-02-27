using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.SetSquare("red", 5);

        Rectangle rectangle = new Rectangle();
        rectangle.SetRectangle("purple", 3, 5);
        
        Circle circle = new Circle();
        circle.SetCircle("blue", 4);

        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shapes i in shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();

            WriteLine($"Color: {color}\nArea: {area}");
        }
    }
}