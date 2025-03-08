namespace EmployeeAndBankSystem;

public class SavingsAccount : BankAccount
{
    public override void CalculateInterest()
    {
        decimal interest = Balance * 0.05m;
        Console.WriteLine($"Vadeli hesabınızın faizi: {interest}");
    }
}