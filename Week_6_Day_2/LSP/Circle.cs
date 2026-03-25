using System;
using System.Collections.Generic;
using System.Text;

// Circle substitutes Shape correctly
public class Circle : Shape
{
    public double Radius { get; set; }

    public override string ShapeName => "Circle";

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
