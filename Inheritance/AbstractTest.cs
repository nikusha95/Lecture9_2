namespace Inheritance;

public class AbstractTest
{
    private readonly Shape _shape;
    public AbstractTest(Shape shape)
    {
        _shape = shape;
    }

    public double GetArea => _shape.GetArea();
}