using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a Square instance, call the GetColor() and GetArea() methods and make sure they return the values you expect
        Square s11 = new Square("Red", 3);
        string color1 = s11.GetColor();
        double area1 = s11.GetArea();
        Console.WriteLine($"{color1}");
        Console.WriteLine($"{area1}");


        //Create a Rectangle instance, call the GetColor() and GetArea() methods and make sure they return the values you expect
        Rectangle r11 = new Rectangle("Blue", 4, 5);
        string color2 = r11.GetColor();
        double area2 = r11.GetArea();
        Console.WriteLine($"{color2}");
        Console.WriteLine($"{area2}");

        //Create a Cricle instance, call the GetColor() and GetArea() methods and make sure they return the values you expect
        Circle c11 = new Circle("Green", 6);
        string color3 = c11.GetColor();
        double area3 = c11.GetArea();
        Console.WriteLine($"{color3}");
        Console.WriteLine($"{area3}");

        // In your Main method, create a list to hold shapes (Hint: The data type should be List<Shape>).
        //Add a square, rectangle, and circle to this list.
        //Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.
        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }




    }
}