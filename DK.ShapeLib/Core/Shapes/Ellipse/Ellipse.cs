namespace DK.ShapeLib.Core.Shapes.Ellipse;

public class Ellipse : Shape, IEllipse
{
    /*
     * Названия возможно некорретны с точки зрения разработки,
     *  но отражают математическую суть
     */
    private readonly double _a; // Полуось по главной оси
    private readonly double _b;  // Полуось по малой оси

    public Ellipse(double a, double b)
    {
        _a = a;
        _b = b;
    }
    
    public override double GetArea()
    {
        return Math.PI * _a * _b;
    }
}
