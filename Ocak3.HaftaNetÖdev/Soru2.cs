//Soru2: Kullanıcıdan bir sayı alıp tek mi çift mi olduğunu bulan bir C# programı yazın.


using System;

class EvenOrOdd
{
    public static void Run()
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} çift bir sayıdır.");
        }
        else
        {
            Console.WriteLine($"{number} tek bir sayıdır.");
        }
    }
}
