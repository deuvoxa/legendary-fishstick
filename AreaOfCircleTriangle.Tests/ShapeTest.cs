using AreaOfCircleTriangle.Interfaces;
using AreaOfCircleTriangle.Shapes;

namespace AreaOfCircleTriangle.Tests;

public class ShapeTest
{
    [Fact]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        Assert.Equal(Math.PI * 25, circle.CalculateArea(), 5);
    }

    [Fact]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.CalculateArea(), 5);
    }

    [Fact]
    public void TriangleRightTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void ShapeAreaCalculatorTest()
    {
        IShape circle = new Circle(5);
        IShape triangle = new Triangle(3, 4, 5);

        Assert.Equal(Math.PI * 25, circle.CalculateArea(), 5);
        Assert.Equal(6, triangle.CalculateArea(), 5);
    }
}