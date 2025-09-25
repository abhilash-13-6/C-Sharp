using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lucky ticket numbers (multiples of both 4 and 6):");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 4 == 0 && i % 6 == 0)
            {
                Console.WriteLine(i);
                

            }
        }
        Console.ReadLine();
    }
}
