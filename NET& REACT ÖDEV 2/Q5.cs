using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] isimler = { "ayşe", "yusuf", "kenan", "muhammed", "naciye", "irem", "mustafa" };

        List<string> enKisaIsimler = new List<string>();
        List<string> enUzunIsimler = new List<string>();

        int enKisaUzunluk = isimler[0].Length;
        int enUzunUzunluk = isimler[0].Length;

        foreach (string isim in isimler)
        {
            if (isim.Length < enKisaUzunluk)
            {
                enKisaUzunluk = isim.Length;
                enKisaIsimler.Clear();
                enKisaIsimler.Add(isim);
            }
            else if (isim.Length == enKisaUzunluk)
            {
                enKisaIsimler.Add(isim);
            }

            if (isim.Length > enUzunUzunluk)
            {
                enUzunUzunluk = isim.Length;
                enUzunIsimler.Clear();
                enUzunIsimler.Add(isim);
            }
            else if (isim.Length == enUzunUzunluk)
            {
                enUzunIsimler.Add(isim);
            }
        }

        Console.WriteLine("En kısa isimler: " + string.Join(", ", enKisaIsimler));
        Console.WriteLine("En uzun isimler: " + string.Join(", ", enUzunIsimler));
    }
}