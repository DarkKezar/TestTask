namespace DK.ShapeLib.Core.Shapes.Circle;

public class Circle : Shape, ICircle
{
    /*
     * Не входило в задание создавать также Элипс,
     *  но в рамках добавления новых фигур, считаю
     *  важным показать подход из SOLID-принципов
     *  не фактического наследования, а композиции
     *  классов
     */
    private readonly Ellipse.Ellipse _ellipse;

    public Circle(double radius)
    {
        _ellipse = new Ellipse.Ellipse(radius, radius); 
    }
    
    public override double GetArea()
    {
        return _ellipse.GetArea();
    }
}