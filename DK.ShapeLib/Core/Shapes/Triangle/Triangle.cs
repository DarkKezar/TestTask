using DK.ShapeLib.Core.Base;

namespace DK.ShapeLib.Core.Shapes.Triangle;

public class Triangle : Shape, ITriangle
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public Triangle(Point2 a, Point2 b, Point2 c)
    {
        _sideA = a.PointDistance(b);
        _sideB = b.PointDistance(c);
        _sideC = a.PointDistance(c);
    }
    
    public override double GetArea()
    {
        double s = (_sideA + _sideB + _sideC) / 2;
        
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }
   
    public bool IsRightAngled()
    {
        var sides = new[] { _sideA, _sideB, _sideC };
        Array.Sort(sides);
        
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
    }
}