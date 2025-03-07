namespace soru2;

using System;

public abstract class Shape
{
    public abstract double Area();  

    public void Display() 
    {
        Console.WriteLine("This is a shape.");
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()  
    {
        return Math.PI * Radius * Radius;  
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area()  
    {
        return Width * Height; 
    }
}




