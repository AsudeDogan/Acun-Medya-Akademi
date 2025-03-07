using System;

class Soru1
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        
        if (sayi > 0)
        {
            Console.WriteLine("Pozitif sayı.");
        }
        else if (sayi < 0)
        {
            Console.WriteLine("Negatif sayı.");
        }
        else
        {
            Console.WriteLine("Sıfır.");
        }
    }
}