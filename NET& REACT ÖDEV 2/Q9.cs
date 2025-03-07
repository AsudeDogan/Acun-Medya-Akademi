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

        if (sayilar.Count > 0)
        {
            double ortalama = sayilar.Average(); 
            sayilar.Sort(); 

            Console.WriteLine("\nGirilen sayıların ortalaması: " + ortalama);
            Console.WriteLine("Sıralanmış liste: " + string.Join(", ", sayilar));
        }
        else
        {
            Console.WriteLine("Sayı girilmedi.");
        }
    }
}