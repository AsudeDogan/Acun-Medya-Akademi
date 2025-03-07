namespace Soru_2;

using System;

class Program
{
    static void Main()
    {
        // Vadeli Hesap 
        BankAccount savings = new SavingsAccount()
        {
            AccountHolder = "Alice",
            Balance = 1000
        };

        // Vadesiz Hesap 
        BankAccount checking = new CheckingAccount()
        {
            AccountHolder = "Bob",
            Balance = 500
        };

        // faiz hesaplama
        savings.CalculateInterest();

        // Vadesiz hesap için faiz hesaplanamıyor, mesaj gösteriliyor.
        checking.CalculateInterest();
    }
}
