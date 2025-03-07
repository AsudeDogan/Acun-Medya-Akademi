namespace Soru_2;

public class CheckingAccount : BankAccount
{
    public override void CalculateInterest()
    {
        Console.WriteLine("Checking accounts do not earn interest.");
    }
}
