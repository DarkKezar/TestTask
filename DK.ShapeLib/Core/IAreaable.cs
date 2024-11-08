namespace DK.ShapeLib.Core;

public interface IAreaable
{
    /*
     * В веб-разработке методы как правило ассинхронные
     * В данном случае async/await не требуется т.к. нет зависимости от
     *  внешних сервисов/классов
     */
    double GetArea();
}