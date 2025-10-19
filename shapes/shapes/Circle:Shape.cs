using System;

namespace shapes;

internal class Circle:Shape
{
public Circle(String color, double radius) : base(color)
    {
       this.radius = radius; 
    }
    private double radius;
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
    public override double Perimeter(){
        return 2 * Math.PI * radius;
    }
    public double Radius
    {
        get { return radius; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Radius cannot be negative");
            radius = value;
        }
    }
}
