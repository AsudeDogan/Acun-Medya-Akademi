using System;

public abstract class Vehicle
{
    public abstract void Start();  

    public void Stop() 
    {
        Console.WriteLine("Vehicle has stopped.");
    }
}

public class Car : Vehicle
{
    public override void Start()  
    {
        Console.WriteLine("Car has started.");
    }
}

public class Bike : Vehicle
{
    public override void Start()  
    {
        Console.WriteLine("Bike has started.");
    }
}

class Abstract1
{
    static void Main()
    {
        Vehicle car = new Car();
        car.Start();
        car.Stop();

        Vehicle bike = new Bike();
        bike.Start();
        bike.Stop();
    }
}

