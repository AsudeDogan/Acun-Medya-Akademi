using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> sayilar = new List<int>(); 
        string input;

        Console.WriteLine("Sayıları girin (Bitirmek için 'exit' yazın):");

        while (true)
        {
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int sayi))
            {
                sayilar.Add(sayi); 
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
            }
        }

        sayilar.RemoveAll(s => s < 10);

        Console.WriteLine("\n10’dan küçük olanlar silindi.");
        Console.WriteLine("Kalan sayılar: " + string.Join(", ", sayilar));
    }
}