using AreaOfCircleTriangle.Interfaces;

namespace AreaOfCircleTriangle.Shapes;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным.", nameof(radius));

        Radius = radius;
    }

    public double CalculateArea() => Math.PI * Radius * Radius;

    public string GetShapeType() => "Круг";
}