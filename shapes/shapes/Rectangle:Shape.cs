using System;
using System.Drawing;

namespace shapes;

internal class Rectangle:Shape
{
    public Rectangle(String color, double width, double length) : base(color)
    {
        
    }
    private double length;
    private double width;
    public override double Area()
    {
        return length * width;
    }
    public override double Perimeter(){
        return 2 * (length + width);
    }
    public double Length
    {
        get { return length; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Length cannot be negative");
            length = value;
        }
    }
    public double Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Width cannot be negative");
            width = value;
        }
    }
}
