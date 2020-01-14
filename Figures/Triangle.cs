using System;

namespace Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException($"Сторона треугольника не может быть отрицатеьлной");
            }

            (A, B, C) = (a, b, c);
        }

        private void CheckExistsByTriangleInequality(double a, double b, double c)
        {
            if (a > b + c)
            {
                
            }
        }
        
        /// <summary>
        /// Первая сторона
        /// </summary>
        public double A { get; }
        
        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double B { get; }
        
        /// <summary>
        /// Третья сторона
        /// </summary>
        public double C { get; }

        /// <summary>
        /// <inheritdoc cref="Figure"/>
        /// </summary>
        public override double Area
        {
            get { return 0.25 * Math.Sqrt((A + B + C) * (A + B - C) * (A - B + C) * (-A + B + C)); }
        }
    }
}