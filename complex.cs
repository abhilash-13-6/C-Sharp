using System;

public class Complex
{
    public double Real;
    public double Imaginary;

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }
}

class Program
{
    static void Main()
    {
        double real1 = double.Parse(Console.ReadLine() ?? "0");
        double imag1 = double.Parse(Console.ReadLine() ?? "0");
        double real2 = double.Parse(Console.ReadLine() ?? "0");
        double imag2 = double.Parse(Console.ReadLine() ?? "0");

        Complex c1 = new Complex(real1, imag1);
        Complex c2 = new Complex(real2, imag2);

        Complex sum = c1 + c2;

        Console.WriteLine($"{sum.Real} {sum.Imaginary}");
    }
}
