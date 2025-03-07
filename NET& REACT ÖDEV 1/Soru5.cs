using System;

class Soru5
{
    static void Main()
    {
        Console.Write("Şifrenizi girin: ");
        string sifre = Console.ReadLine();

        if (sifre.Length >= 8 && 
            sifre.Any(c => char.IsUpper(c)) && 
            sifre.Any(c => char.IsPunctuation(c)))
        {
            Console.WriteLine("Şifre güçlü.");
        }
        else
        {
            Console.WriteLine("Şifre zayıf.\nŞifreniz şu şartları sağlamalıdır:\n- En az 8 karakter olmalı.\n- En az bir büyük harf içermeli.\n- @, #, $, % gibi özel karakterler içermeli.");
        }
    }
}