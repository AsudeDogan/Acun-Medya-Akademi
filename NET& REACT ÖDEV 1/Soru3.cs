using System;

class Soru3
{
    static void Main()
    {
        double num1, num2, result;
        string operation;
        
        
        Console.Write("Birinci sayıyı giriniz: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("İkinci sayıyı giriniz: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Yapmak istediğiniz işlemi belirtin -> (+, -, *, /): ");
        operation = Console.ReadLine();
        
        
        
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Sonuç: {num1} + {num2} = {result}");
                break;

            case "-":
                result = num1 - num2;
                Console.WriteLine($"Sonuç: {num1} - {num2} = {result}");
                break;

            case "*":
                result = num1 * num2;
                Console.WriteLine($"Sonuç: {num1} * {num2} = {result}");
                break;

            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Sonuç: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Sıfıra bölme hatası!");
                }
                break;

            default:
                Console.WriteLine("Geçersiz işlem!");
                break;
        }
    }
}