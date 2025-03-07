using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> notlar = new List<int>(); 
        string input;

        Console.WriteLine("Öğrenci notlarını girin (Bitirdiğinizde 'exit' yazın):");

        while (true)
        {
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int not))
            {
                notlar.Add(not); 
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
            }
        }

        for (int i = 0; i < notlar.Count; i++)
        {
            if (notlar[i] < 50)
                notlar[i] = 50;
        }

        Console.WriteLine("\nGüncellenmiş Notlar: " + string.Join(", ", notlar));
    }
}