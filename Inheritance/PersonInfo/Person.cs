namespace Inheritance.PersonInfo;

public class Person
{
    protected string _firstName;
    protected string _lastName;
    protected DateTime _birthDate;

    public Person(string firstName, string lastName, DateTime birthDate)
    {
        _firstName = firstName;
        _lastName = lastName;
        _birthDate = birthDate;
        Console.WriteLine("Person constructor");
    }
    

    public int GetAge()
    {
        int age = DateTime.Now.Year - _birthDate.Year;

        if (DateTime.Now.Month < _birthDate.Month ||
            (DateTime.Now.Month == _birthDate.Month && DateTime.Now.Day < _birthDate.Day))
        {
            age--;
        }

        return age;
    }

    public virtual void Print()
    {
        Console.WriteLine($"{_firstName}---> {_lastName}--->{_birthDate.ToString("G")} ");
    }
    
    public override string ToString()
    {
        return $"{_firstName}---> {_lastName}--->{_birthDate.ToString("G")} ";
    }
}