using System;

public abstract class Figure
{
    public abstract double CalculateArea();
}

public class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Square : Figure
{
    public double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public override double CalculateArea()
    {
        return Math.Pow(SideLength, 2);
    }
}

public class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

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

public class Program
{
    static void Main(string[] args)
    {
        var figures = new Figure[]
        {
            new Circle(5.0),
            new Square(4.0),
            new Rectangle(3.0, 6.0)
        };

        foreach (var figure in figures)
        {
            Console.WriteLine($"Area of the {figure.GetType().Name} is: {figure.CalculateArea()}");
        }
    }
}