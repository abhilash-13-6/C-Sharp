/*using System;
class Program
{
    static void Main()
    {
        int divisor = 0;
        try
        {
            try
            {
                int divideByZero = 6 / divisor;
            }
            catch (IndexOutOfRangeException e)
            { 
                Console.WriteLine("Inner catch is executed"+e.Message);
            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Outer catch is executed"+e.Message);
        }
    }
}*/


using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a divisor: ");
        try
        {
            try
            {
                int divideByZero = 6 / divisor;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Inner catch is executed" + e.Message);
            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Outer catch is executed" + e.Message);
        }
    }
}
