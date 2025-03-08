namespace EmployeeAndBankSystem;

public class Developer : Employee
{
    public string About { get; set; }
    
    public override decimal CalculateBonus()
    {
        return Salary * 0.10m;
    }
}