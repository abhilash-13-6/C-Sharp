using System;
class program
{
    static void Main(string[] args)
    {
     Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        int last = num % 10 ;
        int first = num;
        while (first >= 10)
        {
            first /= 10;
        }
        Console.WriteLine("First digit: " + first);
        Console.WriteLine("Last digit: " + last);
    }
}
