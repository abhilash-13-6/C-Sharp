using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourcePath = "source.txt";
        string destinationPath = "destination.txt";

        string content = File.ReadAllText(sourcePath);
        File.WriteAllText(destinationPath, content);
    }
}
