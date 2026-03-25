using System;
using System.Collections.Generic;
using System.Text;

class Program3
{
    static void PrintArea(Shape shape)
    {
        // Any Shape subtype can be used here - LSP in action
        Console.WriteLine($"{shape.ShapeName} Area = {shape.CalculateArea():F2}");
    }

    static void Main()
    {
        Shape rect = new Rectangle(5, 10);
        Shape circle = new Circle(7);

        PrintArea(rect);
        PrintArea(circle);
    }
}