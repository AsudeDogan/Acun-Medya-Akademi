using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> stringList = new List<string>(); 
        string input;

        Console.WriteLine("Listeye eklemek için kelimeler girin (Bitirmek için 'exit' yazın):");

        while (true)
        {
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            stringList.Add(input); 
            Console.WriteLine("Şu anki liste: " + string.Join(", ", stringList));
        }

        Console.WriteLine("\nSon Liste: " + string.Join(", ", stringList));
    }
}