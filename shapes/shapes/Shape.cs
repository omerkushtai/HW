using System;

namespace shapes;

public class Shape
{
    public string Color { get; set; }
    public Shape(string color)
    {
        Color = color;
    }
    virtual public double Area()
    {
        return 0.0 ;
    }
    virtual public double Perimeter()
    {
        return 0.0;
    }

}