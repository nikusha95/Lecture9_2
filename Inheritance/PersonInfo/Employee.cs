namespace Inheritance.PersonInfo;

public class Employee
{
    private string _companyName;
    private decimal _salary;

    public Employee(string companyName, decimal salary)
    {
        _companyName = companyName;
        _salary = salary;
    }
}