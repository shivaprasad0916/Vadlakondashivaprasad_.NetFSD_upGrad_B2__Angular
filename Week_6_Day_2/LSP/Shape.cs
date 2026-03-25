using System;
using System.Collections.Generic;
using System.Text;

// Base class
public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract string ShapeName { get; }
}
