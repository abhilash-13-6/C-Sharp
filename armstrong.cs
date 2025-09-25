using System;
class Program
{
    static void Main()
    {
        int num, a, b, c, d;
        for(int i = 1; i <= 1000; i++)
        {
            num = i;
            a = num / 100; 
            b = (num / 10) % 10; 
            c = num % 10; 
            d = a * a * a + b * b * b + c * c * c; 
            if (d == num)
            {
                Console.WriteLine(num);
            }
        }
        Console.ReadLine();
    }
}
