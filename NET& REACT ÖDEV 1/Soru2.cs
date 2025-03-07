using System;

class Soru2
{
    static void Main()
    {
        Console.Write("1-7'ye bir gün numarası girin: ");
        int gunNumarasi = Convert.ToInt32(Console.ReadLine());
        
        switch (gunNumarasi)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;
            default:
                Console.WriteLine("Geçersiz bir numara girdiniz.");
                break;
        }
    }
}