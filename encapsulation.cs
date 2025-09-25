using System;

class Person
{
    private int age; 
    public int Age
    {
        get { 
            return age; 
        }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Age cannot be negative.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();

        p.Age = 25;      
        Console.WriteLine(p.Age);

        p.Age = -5;       
        Console.WriteLine(p.Age);
        Console.ReadLine();
    }
}
