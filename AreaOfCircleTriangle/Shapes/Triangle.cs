using AreaOfCircleTriangle.Interfaces;

namespace AreaOfCircleTriangle.Shapes;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Стороны должны быть положительными.");
        if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Стороны не образуют правильного треугольника.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    private static bool IsValidTriangle(double a, double b, double c)
        => a + b > c && a + c > b && b + c > a;

    public double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public string GetShapeType() => "Треугольник";

    public bool IsRightTriangle()
    {
        var sides = new[] { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 0.0001;
    }
}