namespace Inheritance;

public class Rectangle : Shape
{
    private readonly double _x;
    private readonly double _y;

    public Rectangle(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public override void Print()
    {
        Console.WriteLine($"{_x} {_y}");
    }

    public override double GetArea()
    {
        return _x * _y;
    }
}