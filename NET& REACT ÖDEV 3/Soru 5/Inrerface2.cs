using System;

public interface IAnimal
{
    void MakeSound();
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow! Meow!");
    }
}

class Program
{
    static void Main()
    {
        IAnimal dog = new Dog();
        dog.MakeSound();

        IAnimal cat = new Cat();
        cat.MakeSound();
    }
}