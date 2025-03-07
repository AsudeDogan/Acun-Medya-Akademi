using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 5, 1, 7, 5, 9, 3, 6, 1, 8, 7, 7, 9, 10 };

        Dictionary<int, int> frequency = new Dictionary<int, int>();
        
        foreach (int num in numbers)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }

        Console.WriteLine("Tekrar eden sayılar:");
        
        foreach (var item in frequency)
        {
            if (item.Value > 1)
                Console.WriteLine($"{item.Key}: ({item.Value} kez tekrar ediyor.)");
        }
    }
}