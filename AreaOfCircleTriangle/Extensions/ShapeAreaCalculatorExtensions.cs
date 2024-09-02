using AreaOfCircleTriangle.Interfaces;

namespace AreaOfCircleTriangle.Extensions;

public static class ShapeAreaCalculatorExtensions
{
    public static double CalculateArea(this IShape shape)
        => shape.CalculateArea();
}