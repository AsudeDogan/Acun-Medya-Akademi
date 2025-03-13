//5 elemanlı bir int dizisi oluşturup,
//kullanıcıdan aldığı değerlerle diziyi dolduran ve ekrana yazdıran bir program yazın.


using System;

class UserInputArray
{
    public static void Run()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Lütfen 5 adet sayı giriniz:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{i + 1}. sayı: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Girdiğiniz sayılar:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}


