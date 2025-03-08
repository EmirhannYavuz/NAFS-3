namespace EmployeeAndBankSystem;

public class Manager : Employee
{
    public int TeamSize { get; set; }
    
    public override decimal CalculateBonus()
    {
        return Salary * 0.20m;
    }
}