namespace Soru_2;

public class SavingsAccount : BankAccount
{
    public override void CalculateInterest()
    {
        double interest = Balance * 0.05;  // Bakiyenin %5'i kadar faiz 
        Console.WriteLine($"Interest for savings account: {interest}");
    }
}
