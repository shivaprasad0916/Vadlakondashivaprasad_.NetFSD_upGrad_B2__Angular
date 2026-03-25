using System;
using System.Collections.Generic;
using System.Text;

// Rectangle substitutes Shape correctly
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override string ShapeName => "Rectangle";

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}
