namespace EmployeeAndBankSystem;

public class BankAccount
{
    public string AccountHolder { get; set; }
    public decimal Balance { get; set; }

    public virtual void CalculateInterest()
    {}
}