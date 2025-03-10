//Soru3: Kullanıcıdan alınan bir sayıya kadar olan sayıların toplamını hesaplayan bir program yazın.

using System;

class Q3
{
    static void Main()
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int total = 0;

        for (int i = 1; i <= number; i++)
        {
           total += i;
        }
        Console.WriteLine($"1'den {number}'a kadar olan sayıların toplamı: {total}");
    }
}   
    
