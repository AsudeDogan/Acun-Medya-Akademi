using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hangi işlemi yapmak istiyorsunuz?");
        Console.WriteLine("1 - Girilen sayının tek mi çift mi olduğunu bul.");
        Console.WriteLine("2 - Girilen sayının pozitif, negatif veya sıfır olup olmadığını bul.");
        Console.Write("Seçiminiz: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            EvenOrOdd.Run();
        }
        else if (choice == 2)
        {
            PozsitiveNegativeZero.Run();
        }
        else
        {
            Console.WriteLine("Geçersiz seçim!");
        }
    }
}