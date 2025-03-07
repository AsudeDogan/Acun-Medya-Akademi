using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> kelimeler = new List<string>();
        string input;

        Console.WriteLine("Kelime girin (Bitirmek için 'exit' yazın):");

        while (true)
        {
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            kelimeler.Add(input); 
        }

        kelimeler.Reverse(); 

        Console.WriteLine("\nTers Sıralı Liste:");
        foreach (string kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        }
    }
}