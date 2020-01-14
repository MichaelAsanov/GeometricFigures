using System;
using Figures.Exceptions;

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

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new NegativeArgumentException("Радиус круга не может быть отрицательным");
            }
            
            Radius = radius;
        }

        /// <summary>
        /// <inheritdoc cref="Figure"/>
        /// </summary>
        public override double Area => Math.PI * Radius * Radius;
    }
}