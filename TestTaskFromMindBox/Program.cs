using DK.ShapeLib.Core.Shapes;
using DK.ShapeLib.Core.Shapes.Circle;
using DK.ShapeLib.Core.Shapes.Ellipse;
using DK.ShapeLib.Core.Shapes.Triangle;

IList<Shape> shapes = new List<Shape>();

Shape shape1 = new Triangle(3.0, 4.0, 5.0);
Shape shape2 = new Circle(2.5);
Shape shape3 = new Ellipse(2.5, 3.5);

shapes.Add(shape1);
shapes.Add(shape2);
shapes.Add(shape3);

foreach (var shape in shapes)
{
    Console.WriteLine(shape.GetType() + " " + shape.GetArea());

    if (shape is Triangle)
    {
        Console.WriteLine("Прямоугольный?: " + ((shape as Triangle).IsRightAngled() ? "Yes" : "No"));
    }
}