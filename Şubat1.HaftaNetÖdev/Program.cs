using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hangi işlemi yapmak istiyorsunuz?");
        Console.WriteLine("1 - Dizi içindeki en büyük sayıyı bul");
        Console.WriteLine("2 - Kullanıcıdan dizi al ve yazdır");
        Console.Write("Seçiminiz: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            FindMaxNumber.Run();
        }
        else if (choice == 2)
        {
            UserInputArray.Run();
        }
        else
        {
            Console.WriteLine("Hata: Geçersiz seçim!");
        }
    }
}