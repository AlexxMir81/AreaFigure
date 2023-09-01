namespace AreaFigure.Services
{
    public class Circle : IAreaFigure
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            var result = radius * radius * Math.PI;
            return result;
        }
    }
}
