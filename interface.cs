using System;
public interface Resizable
{
    void resizeWidth(int width);
    void resizeHeight(int height);
}

public class Rectangle : Resizable
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public void resizeWidth(int width)
    {
        Width = width;
    }

    public void resizeHeight(int height)
    {
        Height = height;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(10, 20);
        Console.WriteLine($"Initial: Width={rect.Width}, Height={rect.Height}");

        rect.resizeWidth(30);
        rect.resizeHeight(40);
        Console.WriteLine($"Resized: Width={rect.Width}, Height={rect.Height}");
    }
}
