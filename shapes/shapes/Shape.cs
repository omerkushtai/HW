using System;

namespace shapes;

public abstract class Shape
{
    public string Color { get; set; }
    public Shape(string color)
    {
        Color = color;
    }
    abstract public double Area();
    abstract public double Perimeter();

}