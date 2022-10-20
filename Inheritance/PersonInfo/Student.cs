namespace Inheritance.PersonInfo;

public class Student : Person
{
    private string _university;
    public string Unversity => _university;
    public Student(string firstName, string lastName, DateTime birthDate, string university)
        : base(firstName, lastName, birthDate)
    {
        // _firstName = firstName;
        // _lastName = lastName;
        // _birthDate=birthDate;
        _university = university;
        Console.WriteLine("Student constructor");
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($" {base.GetAge()} {_university}");
    }
}