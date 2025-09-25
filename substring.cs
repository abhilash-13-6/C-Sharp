using System;

namespace substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("All substrings:");
            for (int start = 0; start < input.Length; start++)
            {
                for (int length = 1; length <= input.Length - start; length++)
                {
                    string substring = input.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
