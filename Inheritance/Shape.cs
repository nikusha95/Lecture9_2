namespace Inheritance;

public abstract class Shape
{
    public abstract double GetArea();

    public int GetRandomNum()
    {
        return 1;
    }
    public virtual void Print()
    {
        Console.WriteLine("Shape Object");
    }
}