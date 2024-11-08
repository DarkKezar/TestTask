using DK.ShapeLib.Core.Shapes;
using DK.ShapeLib.Core.Shapes.Circle;
using DK.ShapeLib.Core.Shapes.Triangle;

namespace DK.ShapeLib.Tests;

using NUnit.Framework;

[TestFixture]
public class ShapeTests
{
    [Test]
    public void CircleArea_CorrectCalculation()
    {
        Shape circle = new Circle(10);
        Assert.That(circle.GetArea(), Is.EqualTo(314.1592653589793).Within(1e-5));
    }

    [Test]
    public void TriangleArea_CorrectCalculation()
    {
        Shape triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.GetArea(), Is.EqualTo(6).Within(1e-5));
    }

    [Test]
    public void TriangleIsRightAngled_CorrectCheck()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightAngled());

        triangle = new Triangle(2, 2, 3);
        Assert.IsFalse(triangle.IsRightAngled());
    }
}