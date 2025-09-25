using System;

namespace polymorphism
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }

        public virtual void Erase()
        {
            Console.WriteLine("Erasing a shape.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }

        public override void Erase()
        {
            Console.WriteLine("Erasing a circle.");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle.");
        }

        public override void Erase()
        {
            Console.WriteLine("Erasing a triangle.");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }

        public override void Erase()
        {
            Console.WriteLine("Erasing a square.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            Shape triangle = new Triangle();
            Shape square = new Square();

            circle.Draw();
            circle.Erase();
            Console.WriteLine();

            triangle.Draw();
            triangle.Erase();
            Console.WriteLine();

            square.Draw();
            square.Erase();
            Console.WriteLine();
        }
    }
}
