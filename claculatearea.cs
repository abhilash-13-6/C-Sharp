using System;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Shape circle = new Circle(radius);
        Console.WriteLine("Area: " + circle.CalculateArea());
        Console.ReadLine();
    }
}
