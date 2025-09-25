using System;


class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}


class Program
{
    static void Main()
    {
      
        Dog myDog = new Dog();

        myDog.Eat();

        myDog.Bark();
        Console.ReadLine();
    }
}
