namespace DK.ShapeLib.Core.Base;

public struct Point2
{
    public double x;
    public double y;

    public double PointDistance(Point2 other)
    {
        return Math.Sqrt(Math.Pow(x - other.x, 2) + Math.Pow(y - other.y, 2));
    }
}