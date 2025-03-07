namespace Question1;

using System;

class Program
{
    static void Main()
    {
        Manager manager = new Manager(1, "Asude", 5000, "HR", 10);
        Developer developer = new Developer(2, "Ahmet", 4000, "IT", "Backend Developer");

        Console.WriteLine($"{manager.Name} bonus: {manager.CalculateBonus()}");
        Console.WriteLine($"{developer.Name} bonus: {developer.CalculateBonus()}");
    }
}
