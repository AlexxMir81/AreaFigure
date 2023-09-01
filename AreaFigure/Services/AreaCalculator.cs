namespace AreaFigure.Services
{
    public class AreaCalculator
    {
        public double calulateArea(IAreaFigure figure)
        {
            return figure.CalculateArea();
        }
    }
}
