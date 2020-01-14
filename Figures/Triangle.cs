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
            CheckAllSidesAreNonNegative(a, b, c);
            CheckTriangleInequality(a, b, c);
            
            (A, B, C) = (a, b, c);
        }

        /// <summary>
        /// Проверка, что все стороны неотрицательны
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <exception cref="NegativeArgumentException"></exception>
        private void CheckAllSidesAreNonNegative(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new NegativeArgumentException($"Переданы отрицательные стороны: " +
                                                    (a < 0 ? $"{nameof(a)} = {a}. " : string.Empty) +
                                                    (b < 0 ? $"{nameof(b)} = {b}. " : string.Empty) +
                                                    (c < 0 ? $"{nameof(c)} = {c}. " : string.Empty) +
                                                    $"Стороны треугольника не могут быть отрицательными");
            }
        }
        
        /// <summary>
        /// Проверка неравенства треугольника
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <exception cref="NegativeArgumentException"></exception>
        private void CheckTriangleInequality(double a, double b, double c)
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
        /// <inheritdoc cref="Figure.Area"/>
        /// </summary>
        public override double Area
        {
            //Вычисляем площадь по формуле Герона
            get { return 0.25 * Math.Sqrt((A + B + C) * (A + B - C) * (A - B + C) * (-A + B + C)); }
        }

        /// <summary>
        /// Не вырождается ли наш треугольник в точку?
        /// </summary>
        private bool IsPoint => A == 0 && B == 0 && C == 0;

        /// <summary>
        /// Не вырождается ли наш треугольник в отрезок?
        /// </summary>
        private bool IsLine
        {
            get { return !IsPoint && (A == B + C || B == A + C || C == A + B); }
        }
        
        /// <summary>
        /// Прямоугольный ли треугольник
        /// </summary>
        public bool IsRectangular
        {
            get
            {
                //Проверяем прямоугольность по обратной теореме Пифагора
                double a_2 = A * A;
                double b_2 = B * B;
                double c_2 = C * C;
                
                return !IsPoint && !IsLine && (a_2 == b_2 + c_2 || b_2 == a_2 + c_2 || c_2 == a_2 + b_2);
            }
        }
    }
}