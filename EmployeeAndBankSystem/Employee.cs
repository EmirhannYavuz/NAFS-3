namespace EmployeeAndBankSystem;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
    
    public virtual decimal CalculateBonus()
    {
        return 0;
    }
}