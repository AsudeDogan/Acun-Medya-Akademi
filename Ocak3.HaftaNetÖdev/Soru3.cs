//Soru3: Girilen bir sayının pozitif, negatif veya sıfır olup olmadığını belirleyen bir program yazın.

using System;

class PozsitiveNegativeZero
{
    public static void Run()
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine($"{number} pozitif bir sayıdır.");
        }

        else if (number < 0)
        {
            Console.WriteLine($"{number} negatif bir sayıdır.");
        }

        else
        {
            Console.WriteLine($"Girdiğiniz sayı sıfıra eşittir.");
        }
    }
}