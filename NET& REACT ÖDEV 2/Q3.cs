using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> yaslar = new List<int>();

        Console.Write("Yaşınızı girin: ");
        yaslar.Add(int.Parse(Console.ReadLine()));

        foreach (int yas in yaslar)
        {
            string kategori;

            if (yas >= 0 && yas <= 12)
                kategori = "Çocuk";
            else if (yas >= 13 && yas <= 19)
                kategori = "Genç";
            else if (yas >= 20 && yas <= 64)
                kategori = "Yetişkin";
            else
                kategori = "Yaşlı";

            Console.WriteLine($"Yaş: {yas} \nKategori: {kategori}");
        }
    }
}