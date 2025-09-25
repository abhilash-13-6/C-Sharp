using System;

namespace AreaandPerimeter
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    public class Circle : Shape
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

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public override double CalculateArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public override double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Console.WriteLine($"Circle Area: {circle.CalculateArea():F2}");
            Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter():F2}");

            Shape triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Triangle Area: {triangle.CalculateArea():F2}");
            Console.WriteLine($"Triangle Perimeter: {triangle.CalculatePerimeter():F2}");
        }
    }
}
