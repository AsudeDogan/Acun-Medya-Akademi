//Bir dizinin içindeki en büyük sayıyı bulan bir C# programı yazın.

using System;

class FindMaxNumber
{
    public static void Run()
    {
        int[] numbers = { 12, 45, 67, 89, 23 }; // Örnek array
        int maxNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }

        Console.WriteLine("Dizideki en büyük sayı: " + maxNumber);
    }
}


   
