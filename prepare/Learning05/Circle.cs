using System;
public class Circle : Shape
{
    private double _radius;


    // Create a constructor that accepts the color and the radius, and then call the base constructor with the color.
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;

    }

    // Override the GetArea() method from the base class and fill in the body of this function to return the area.
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}