using System;
class Program {
    static void Main() {
        try
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine("Result:" + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error:cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error:Please enter valid numbers only");
        }
        finally
        {
            Console.WriteLine("End of the program");
        }
    }
}




/*try
{
    Console.WriteLine("Enter first number:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int result = num1 / num2;
    Console.WriteLine("Result:" + result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error:cannot divide by zero");
}
catch (FormatException)
{
    Console.WriteLine("Error:Please enter valid numbers only");
}*/
