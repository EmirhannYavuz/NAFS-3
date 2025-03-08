// See https://aka.ms/new-console-template for more information

using EmployeeAndBankSystem;

Manager manager = new Manager
{
    Id = 1,
    Name = "Ali",
    Salary = 100000,
    Department = "Yazılım Geliştirme",
    TeamSize = 10
};
Developer developer = new Developer
{
    Id = 2,
    Name = "Veli",
    Salary = 80000,
    Department = "Yazılım Geliştirme",
    About = "C# Geliştiricisi"
};

Console.WriteLine($"{manager.Name} adlı yöneticinin maaş primi: {manager.CalculateBonus()} TL");
Console.WriteLine($"{developer.Name} adlı geliştiricinin maaş primi: {developer.CalculateBonus()} TL");
Console.WriteLine("--------------------------------------------------");

SavingsAccount savingsAccount = new SavingsAccount
{
    AccountHolder = "Ali",
    Balance = 5000
};
CheckingAccount checkingAccount = new CheckingAccount
{
    AccountHolder = "Veli",
    Balance = 5000
};

Console.Write($"Hesap sahibi: {savingsAccount.AccountHolder}, ");
savingsAccount.CalculateInterest();
Console.Write($"Hesap sahibi: {checkingAccount.AccountHolder}, ");
checkingAccount.CalculateInterest();