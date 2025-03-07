using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir cümle giriniz:");
        string cumle = Console.ReadLine();
        
        string[] kelimeler = cumle.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        
        Array.Sort(kelimeler);

        Console.WriteLine("Alfabetik sıraya göre kelimeler:");
        foreach (string kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        }
    }
}