using System;

class Program
{
    static void Main()
    {
        try
        {
            // Inner try block to handle user input and division
            try
            {
                Console.WriteLine("Enter 1st number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter 2nd number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by zero error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input format: " + e.Message);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}

