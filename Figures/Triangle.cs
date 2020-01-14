using System;
using Figures.Exceptions;

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
                throw new NegativeArgumentException($"Переданы отрицательные стороны: " +
                                                    (a < 0 ? $"{nameof(a)} = {a}. " : string.Empty) +
                                                    (b < 0 ? $"{nameof(b)} = {b}. " : string.Empty) +
                                                    (c < 0 ? $"{nameof(c)} = {c}. " : string.Empty) +
                                                    $"Стороны треугольника не могут быть отрицательными");
            }

            CheckExistsByTriangleInequality(a, b, c);
            (A, B, C) = (a, b, c);
        }

        private void CheckExistsByTriangleInequality(double a, double b, double c)
        {
            bool noncompliance1 = a > b + c;
            bool noncompliance2 = b > a + c;
            bool noncompliance3 = c > a + b;
            
            if (noncompliance1 || noncompliance2 || noncompliance3)
            {
                throw new NegativeArgumentException($"Нарушение неравенства треугольника: " +
                                                    (noncompliance1 ? $"{nameof(a)} > {nameof(b)} + {nameof(c)}. " : string.Empty) +
                                                    (noncompliance2 ? $"{nameof(b)} > {nameof(a)} + {nameof(c)}. " : string.Empty) +
                                                    (noncompliance3 ? $"{nameof(c)} > {nameof(a)} + {nameof(b)}. " : string.Empty) +
                                                    "Каждая сторона треугольника должна быть меньше суммы двух других сторон." 
                                                   );
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
            //Вычисляем площадь по формуле Герона
            get { return 0.25 * Math.Sqrt((A + B + C) * (A + B - C) * (A - B + C) * (-A + B + C)); }
        }
    }
}