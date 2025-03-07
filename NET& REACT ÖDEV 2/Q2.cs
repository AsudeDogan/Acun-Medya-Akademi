using System;

class Q2
{
    static void Main()
    {
        int sayi;
        
        while (true)
        {
            Console.Write("10 ile 100 arasında bir sayı girin: ");
            sayi = int.Parse(Console.ReadLine());

            if (sayi >= 10 && sayi <= 100)
            {
                Console.WriteLine(sayi + ": Geçerli sayı girişi.");
                break; 
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen tekrar deneyin.");
            }
        }
    }
}