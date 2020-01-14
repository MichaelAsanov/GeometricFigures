using System;

namespace Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус окружности не может быть отрицательным");
            }
            
            Radius = radius;
        }

        public override double Area => Math.PI * Radius * Radius;
    }
}