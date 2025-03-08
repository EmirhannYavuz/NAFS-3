namespace EmployeeAndBankSystem;

public class CheckingAccount : BankAccount
{
    public override void CalculateInterest()
    {
        Console.WriteLine("Vadesiz hesaplar faiz kazandırmaz.");
    }
}